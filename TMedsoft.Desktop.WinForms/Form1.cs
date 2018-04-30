using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TMedsoft.Desktop.Constants;
using TMedsoft.Desktop.Models.Book;
using TMedsoft.Desktop.Models.Cart;
using TMedsoft.Desktop.Services;
using TMedsoft.Desktop.Validators;
using TMedsoft.Interfaces;
using TMedsoft.ViewModels;

namespace TMedsoft.Desktop.WinForms
{
    public partial class Form1 : Form
    {
        private readonly BookService _bookService;
        private readonly GenreService _genreService;
        private readonly BookValidator _bookValidator;
        private int _pageNumber;
        private readonly int _rowsPerPage;
        private long? _genreId;
        private string _name;
        private int _rows;
        private List<string> _messages;
        private readonly CartService _cartService;

        public Form1()
        {
            _bookService = new BookService();
            _cartService = new CartService();
            _genreService = new GenreService();
            _bookValidator = new BookValidator();

            _pageNumber = 1;
            _messages = new List<string>();
            _rowsPerPage = 20;
            _genreId = (long?)null;
            _name = "";
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            RefreshGridViewBooks();

            var genres = _genreService.GetLookup().ToList();
            genres.Insert(0, new Lookup { Text = "Выбрать...", Value = "" });
            this.cmb_Genres.DataSource = genres;
            this.cmb_Genres.ValueMember = "Value";
            this.cmb_Genres.DisplayMember = "Text";
            this.ltb_Messages.DataSource = _messages;
            base.OnLoad(e);
        }

        private void gv_Books_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
        }

        private void RefreshGridViewBooks()
        {
            var lookup = (ILookup)this.cmb_Genres.SelectedItem;

            if (lookup != null && !string.IsNullOrEmpty(lookup.Value))
            {
                long.TryParse(lookup.Value, out var temp);
                this._genreId = temp;
            }
            else
            {
                this._genreId = null;
            }

            var books = _bookService.Get(this._pageNumber, this._rowsPerPage, this._genreId, this._name);
            this._rows = books.Rows;
            this.lbl_CurPage.Text = this._pageNumber.ToString();
            this.lbl_TotalPages.Text = (this._rows / _rowsPerPage).ToString();
            gv_Books.DataSource = books.Items;

            gv_Books.DataSource = books.Items;
        }

        private void UpdateCartInfo()
        {
            long tempQuantity = 0;
            decimal tempCost = 0;
            foreach (DataGridViewRow row in gv_Cart.Rows)
            {
                var quantityValue = row.Cells[this.gv_Cart_clm_Quantity.Name].Value;
                var costValue = row.Cells[this.gv_Cart_clm_Cost.Name].Value;

                if (quantityValue != null && costValue != null)
                {
                    tempQuantity += Convert.ToInt64(quantityValue.ToString());
                    tempCost += Convert.ToDecimal(costValue.ToString());
                }
            }
            this.grb_Cart_lbl_Cost.Text = tempCost.ToString();
            this.grb_Cart_lbl_Quantity.Text = tempQuantity.ToString();
        }

        private void btn_Refresh_Click(object sender, System.EventArgs e)
        {
            RefreshGridViewBooks();
        }

        private void btn_filter_Click(object sender, System.EventArgs e)
        {
            this._pageNumber = 1;
            RefreshGridViewBooks();
        }

        private void btn_Next_Click(object sender, System.EventArgs e)
        {
            this._pageNumber++;
            RefreshGridViewBooks();
            if (this._pageNumber == this._rows / this._rowsPerPage)
            {
                btn_Next.Enabled = false;
                btn_Prev.Enabled = true;
            }
        }

        private void btn_PreViewOrder_Click(object sender, EventArgs e)
        {
        }

        private void tbx_Name_Leave(object sender, EventArgs e)
        {
            this._name = this.tbx_Name.Text;
        }

        private void btn_Prev_Click(object sender, EventArgs e)
        {
            this._pageNumber--;
            RefreshGridViewBooks();
            if (this._pageNumber == 1)
            {
                btn_Next.Enabled = true;
                btn_Prev.Enabled = false;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void gv_Books_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > -1 && e.RowIndex > -1)
            {
                var cell = gv_Books.CurrentCell;
                var quantity = Convert.ToInt64(gv_Books.Rows[e.RowIndex].Cells[gv_Books_clm_CartQuantity.Name].Value.ToString());
                var cartQuantity = cell.Value?.ToString();
                var result = _bookValidator.ValidateQuantity(quantity, cartQuantity);

                if (!result.State)
                {
                    cell.ErrorText = result.Result;
                    cell.Value = "0";
                }
                else { cell.ErrorText = ""; }
            }
        }

        private void gv_Books_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > -1 && e.RowIndex > -1 && gv_Books.Rows[e.RowIndex].Cells[this.gv_Books_clm_CartQuantity.Name].Value != null)
            {
                var curBookRow = gv_Books.Rows[e.RowIndex];

                var updated = false;
                foreach (DataGridViewRow cartRow in this.gv_Cart.Rows)
                {
                    if (cartRow.Cells[gv_Cart_clm_Name.Name].Value.ToString() == curBookRow.Cells[gv_Books_clm_Name.Name].Value.ToString())
                    {
                        var quantity = Convert.ToInt64(curBookRow.Cells[gv_Books_clm_Quantity.Name].Value.ToString());
                        var cartCurQuantity = curBookRow.Cells[gv_Books_clm_CartQuantity.Name].Value.ToString();
                        var cartQuantity = cartRow.Cells[gv_Cart_clm_Quantity.Name].Value.ToString();
                        var validateResult = _bookValidator.ValidateAddingCartQuantity(quantity, cartQuantity, cartCurQuantity);
                        if (validateResult.State)
                        {
                            cartRow.Cells[this.gv_Cart_clm_Quantity.Name].Value =
                                Convert.ToInt64(cartRow.Cells[this.gv_Cart_clm_Quantity.Name].Value) + Convert.ToInt64(curBookRow.Cells[this.gv_Books_clm_CartQuantity.Name].Value);
                            cartRow.Cells[this.gv_Cart_clm_Cost.Name].Value
                                = Convert.ToDecimal(curBookRow.Cells[this.gv_Books_clm_Cost.Name].Value) * (Convert.ToInt64(cartRow.Cells[this.gv_Cart_clm_Quantity.Name].Value) + Convert.ToInt64(curBookRow.Cells[this.gv_Books_clm_CartQuantity.Name].Value));
                        }
                        else
                        {
                            curBookRow.Cells[gv_Books_clm_CartQuantity.Name].Value = "0";
                            curBookRow.Cells[gv_Books_clm_CartQuantity.Name].ErrorText = validateResult.Result;
                        }
                        updated = true;
                        break;
                    }
                }
                if (!updated)
                {
                    var newRowIndex = gv_Cart.Rows.Add();
                    var newRow = gv_Cart.Rows[newRowIndex];
                    newRow.Cells[this.gv_Cart_clm_BookCost.Name].Value = curBookRow.Cells[this.gv_Books_clm_Cost.Name].Value;
                    newRow.Cells[this.gv_Cart_clm_BookQuantity.Name].Value = curBookRow.Cells[this.gv_Books_clm_Quantity.Name].Value;
                    newRow.Cells[this.gv_Cart_clm_Name.Name].Value = curBookRow.Cells[this.gv_Books_clm_Name.Name].Value;
                    newRow.Cells[this.gv_Cart_clm_ID.Name].Value = curBookRow.Cells[this.gv_Books_clm_ID.Name].Value;
                    newRow.Cells[this.gv_Cart_clm_Quantity.Name].Value = curBookRow.Cells[this.gv_Books_clm_CartQuantity.Name].Value;
                    newRow.Cells[this.gv_Cart_clm_Cost.Name].Value = Convert.ToDecimal(curBookRow.Cells[this.gv_Books_clm_Cost.Name].Value) * Convert.ToInt64(curBookRow.Cells[this.gv_Books_clm_CartQuantity.Name].Value);
                }
                UpdateCartInfo();
            }
        }

        private void gv_Cart_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
        }

        private void gv_Cart_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            UpdateCartInfo();
        }

        private void gv_Cart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == -1 || e.RowIndex == -1)
                return;
            if ((e.ColumnIndex == 4 || e.ColumnIndex == 5))
            {
                var cartRow = gv_Cart.Rows[e.RowIndex];

                long quantity = Convert.ToInt64(cartRow.Cells[gv_Cart_clm_BookQuantity.Name].Value.ToString());

                var cartCurQuantity = e.ColumnIndex == 4 ? "1" : "-1";
                var cartQuantity = cartRow.Cells[gv_Cart_clm_Quantity.Name].Value.ToString();
                var validateResult = _bookValidator.ValidateAddingCartQuantity(quantity, cartQuantity, cartCurQuantity);
                if (validateResult.State)
                {
                    cartRow.Cells[this.gv_Cart_clm_Quantity.Name].Value =
                        Convert.ToInt64(cartCurQuantity) + Convert.ToInt64(cartQuantity);
                    cartRow.Cells[this.gv_Cart_clm_Cost.Name].Value
                        = Convert.ToDecimal(cartRow.Cells[this.gv_Cart_clm_BookCost.Name].Value) * (Convert.ToInt64(cartRow.Cells[this.gv_Cart_clm_Quantity.Name].Value));
                }
                else
                {
                    _messages.Add(validateResult.Result);
                }
                UpdateCartInfo();
            }
            else if (e.ColumnIndex == 6)
            {
                gv_Cart.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void btn_PreviewOrder_Click_1(object sender, EventArgs e)
        {
            var cart = new Create { Items = new List<CreateItem>(), CouponCode = grb_Cart_tbx_Сoupon.Text };
            foreach (DataGridViewRow row in gv_Cart.Rows)
            {
                cart.Items.Add(new CreateItem
                {
                    ID = row.Cells[gv_Cart_clm_ID.Name].Value.ToString(),
                    Quantity = Convert.ToInt64(row.Cells[gv_Cart_clm_Quantity.Name].Value.ToString()),
                });
            }
            grb_Cart_lbl_Discount.Text = _cartService.GetDiscount(cart).ToString("C");
            btn_PreviewOrder.Enabled = false;
            btn_CreateOrder.Enabled = true;
        }

        private void btn_CreateOrder_Click(object sender, EventArgs e)
        {
            var cart = new Create { Items = new List<CreateItem>(), CouponCode = grb_Cart_tbx_Сoupon.Text };
            foreach (DataGridViewRow row in gv_Cart.Rows)
            {
                cart.Items.Add(new CreateItem
                {
                    ID = row.Cells[gv_Cart_clm_ID.Name].Value.ToString(),
                    Quantity = Convert.ToInt64(row.Cells[gv_Cart_clm_Quantity.Name].Value.ToString()),
                });
            }
            _cartService.GetDiscount(cart);
        }
    }
}