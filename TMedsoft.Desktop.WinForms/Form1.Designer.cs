

using TMedsoft.Desktop.Models.Book;

namespace TMedsoft.Desktop.WinForms
{
    partial class Form1
    {
        public IndexItem Book;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tb_Container = new System.Windows.Forms.TabControl();
            this.tbp_Books = new System.Windows.Forms.TabPage();
            this.gv_Books = new System.Windows.Forms.DataGridView();
            this.gv_Books_clm_AddCart = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lbl_TotalPages = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_CurPage = new System.Windows.Forms.Label();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.lbl_CurPageText = new System.Windows.Forms.Label();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_Prev = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_filter = new System.Windows.Forms.Button();
            this.tbx_Name = new System.Windows.Forms.TextBox();
            this.cmb_Genres = new System.Windows.Forms.ComboBox();
            this.tbp_Cart = new System.Windows.Forms.TabPage();
            this.gv_Cart = new System.Windows.Forms.DataGridView();
            this.btn_CreateOrder = new System.Windows.Forms.Button();
            this.grb_Cart = new System.Windows.Forms.GroupBox();
            this.grb_Cart_tbx_Сoupon = new System.Windows.Forms.TextBox();
            this.grb_Cart_lbl_Discount = new System.Windows.Forms.Label();
            this.grb_Cart_lbl_Cost = new System.Windows.Forms.Label();
            this.grb_Cart_lbl_Quantity = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ltb_Messages = new System.Windows.Forms.ListBox();
            this.btn_PreviewOrder = new System.Windows.Forms.Button();
            this.gv_Cart_clm_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gv_Cart_clm_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gv_Cart_clm_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gv_Cart_clm_Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gv_Cart_clm_Increase = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gv_Cart_clm_Decrease = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gv_Cart_Remove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gv_Cart_clm_BookQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gv_Cart_clm_BookCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_Container.SuspendLayout();
            this.tbp_Books.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Books)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tbp_Cart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Cart)).BeginInit();
            this.grb_Cart.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_Container
            // 
            this.tb_Container.Controls.Add(this.tbp_Books);
            this.tb_Container.Controls.Add(this.tbp_Cart);
            this.tb_Container.Location = new System.Drawing.Point(12, 12);
            this.tb_Container.Name = "tb_Container";
            this.tb_Container.SelectedIndex = 0;
            this.tb_Container.Size = new System.Drawing.Size(748, 426);
            this.tb_Container.TabIndex = 0;
            // 
            // tbp_Books
            // 
            this.tbp_Books.AutoScroll = true;
            this.tbp_Books.Controls.Add(this.gv_Books);
            this.tbp_Books.Controls.Add(this.lbl_TotalPages);
            this.tbp_Books.Controls.Add(this.label5);
            this.tbp_Books.Controls.Add(this.lbl_CurPage);
            this.tbp_Books.Controls.Add(this.btn_Refresh);
            this.tbp_Books.Controls.Add(this.lbl_CurPageText);
            this.tbp_Books.Controls.Add(this.btn_Next);
            this.tbp_Books.Controls.Add(this.btn_Prev);
            this.tbp_Books.Controls.Add(this.groupBox1);
            this.tbp_Books.Location = new System.Drawing.Point(4, 22);
            this.tbp_Books.Name = "tbp_Books";
            this.tbp_Books.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_Books.Size = new System.Drawing.Size(740, 400);
            this.tbp_Books.TabIndex = 0;
            this.tbp_Books.Text = "Книги";
            this.tbp_Books.UseVisualStyleBackColor = true;
            // 
            // gv_Books
            // 
            this.gv_Books.AllowUserToAddRows = false;
            this.gv_Books.AllowUserToDeleteRows = false;
            this.gv_Books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Books.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gv_Books_clm_AddCart});
            this.gv_Books.Location = new System.Drawing.Point(7, 68);
            this.gv_Books.Name = "gv_Books";
            this.gv_Books.Size = new System.Drawing.Size(727, 297);
            this.gv_Books.TabIndex = 9;
            this.gv_Books.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_Books_CellContentClick);
            this.gv_Books.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_Books_CellEndEdit);
            // 
            // gv_Books_clm_AddCart
            // 
            this.gv_Books_clm_AddCart.HeaderText = "";
            this.gv_Books_clm_AddCart.Name = "gv_Books_clm_AddCart";
            this.gv_Books_clm_AddCart.Text = "В корзину";
            this.gv_Books_clm_AddCart.UseColumnTextForButtonValue = true;
            // 
            // lbl_TotalPages
            // 
            this.lbl_TotalPages.AutoSize = true;
            this.lbl_TotalPages.Location = new System.Drawing.Point(277, 377);
            this.lbl_TotalPages.Name = "lbl_TotalPages";
            this.lbl_TotalPages.Size = new System.Drawing.Size(13, 13);
            this.lbl_TotalPages.TabIndex = 8;
            this.lbl_TotalPages.Text = "1";
            this.lbl_TotalPages.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(252, 377);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "из";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_CurPage
            // 
            this.lbl_CurPage.AutoSize = true;
            this.lbl_CurPage.Location = new System.Drawing.Point(233, 377);
            this.lbl_CurPage.Name = "lbl_CurPage";
            this.lbl_CurPage.Size = new System.Drawing.Size(13, 13);
            this.lbl_CurPage.TabIndex = 6;
            this.lbl_CurPage.Text = "1";
            this.lbl_CurPage.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(659, 371);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_Refresh.TabIndex = 5;
            this.btn_Refresh.Text = "Обновить";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // lbl_CurPageText
            // 
            this.lbl_CurPageText.AutoSize = true;
            this.lbl_CurPageText.Location = new System.Drawing.Point(169, 377);
            this.lbl_CurPageText.Name = "lbl_CurPageText";
            this.lbl_CurPageText.Size = new System.Drawing.Size(58, 13);
            this.lbl_CurPageText.TabIndex = 4;
            this.lbl_CurPageText.Text = "Страница:";
            this.lbl_CurPageText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(88, 372);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(75, 23);
            this.btn_Next.TabIndex = 3;
            this.btn_Next.Text = "Туда";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_Prev
            // 
            this.btn_Prev.Enabled = false;
            this.btn_Prev.Location = new System.Drawing.Point(7, 372);
            this.btn_Prev.Name = "btn_Prev";
            this.btn_Prev.Size = new System.Drawing.Size(75, 23);
            this.btn_Prev.TabIndex = 2;
            this.btn_Prev.Text = "Сюда";
            this.btn_Prev.UseVisualStyleBackColor = true;
            this.btn_Prev.Click += new System.EventHandler(this.btn_Prev_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_filter);
            this.groupBox1.Controls.Add(this.tbx_Name);
            this.groupBox1.Controls.Add(this.cmb_Genres);
            this.groupBox1.Location = new System.Drawing.Point(7, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(727, 55);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Панель фильтрации";
            // 
            // btn_filter
            // 
            this.btn_filter.Location = new System.Drawing.Point(626, 16);
            this.btn_filter.Name = "btn_filter";
            this.btn_filter.Size = new System.Drawing.Size(92, 23);
            this.btn_filter.TabIndex = 2;
            this.btn_filter.Text = "Фильтровать";
            this.btn_filter.UseVisualStyleBackColor = true;
            this.btn_filter.Click += new System.EventHandler(this.btn_filter_Click);
            // 
            // tbx_Name
            // 
            this.tbx_Name.Location = new System.Drawing.Point(135, 20);
            this.tbx_Name.Name = "tbx_Name";
            this.tbx_Name.Size = new System.Drawing.Size(130, 20);
            this.tbx_Name.TabIndex = 1;
            this.tbx_Name.Leave += new System.EventHandler(this.tbx_Name_Leave);
            // 
            // cmb_Genres
            // 
            this.cmb_Genres.FormattingEnabled = true;
            this.cmb_Genres.Location = new System.Drawing.Point(7, 20);
            this.cmb_Genres.Name = "cmb_Genres";
            this.cmb_Genres.Size = new System.Drawing.Size(121, 21);
            this.cmb_Genres.TabIndex = 0;
            // 
            // tbp_Cart
            // 
            this.tbp_Cart.AutoScroll = true;
            this.tbp_Cart.Controls.Add(this.gv_Cart);
            this.tbp_Cart.Location = new System.Drawing.Point(4, 22);
            this.tbp_Cart.Name = "tbp_Cart";
            this.tbp_Cart.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_Cart.Size = new System.Drawing.Size(740, 400);
            this.tbp_Cart.TabIndex = 1;
            this.tbp_Cart.Text = "Корзина";
            this.tbp_Cart.UseVisualStyleBackColor = true;
            // 
            // gv_Cart
            // 
            this.gv_Cart.AllowUserToAddRows = false;
            this.gv_Cart.AllowUserToDeleteRows = false;
            this.gv_Cart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Cart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gv_Cart_clm_ID,
            this.gv_Cart_clm_Name,
            this.gv_Cart_clm_Quantity,
            this.gv_Cart_clm_Cost,
            this.gv_Cart_clm_Increase,
            this.gv_Cart_clm_Decrease,
            this.gv_Cart_Remove,
            this.gv_Cart_clm_BookQuantity,
            this.gv_Cart_clm_BookCost});
            this.gv_Cart.Location = new System.Drawing.Point(6, 6);
            this.gv_Cart.Name = "gv_Cart";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gv_Cart.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gv_Cart.Size = new System.Drawing.Size(728, 388);
            this.gv_Cart.TabIndex = 0;
            this.gv_Cart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_Cart_CellContentClick);
            this.gv_Cart.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gv_Cart_RowsAdded);
            this.gv_Cart.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.gv_Cart_RowsRemoved);
            // 
            // btn_CreateOrder
            // 
            this.btn_CreateOrder.Enabled = false;
            this.btn_CreateOrder.Location = new System.Drawing.Point(900, 140);
            this.btn_CreateOrder.Name = "btn_CreateOrder";
            this.btn_CreateOrder.Size = new System.Drawing.Size(128, 23);
            this.btn_CreateOrder.TabIndex = 1;
            this.btn_CreateOrder.Text = "Сохранить";
            this.btn_CreateOrder.UseVisualStyleBackColor = true;
            this.btn_CreateOrder.Click += new System.EventHandler(this.btn_CreateOrder_Click);
            // 
            // grb_Cart
            // 
            this.grb_Cart.Controls.Add(this.grb_Cart_tbx_Сoupon);
            this.grb_Cart.Controls.Add(this.grb_Cart_lbl_Discount);
            this.grb_Cart.Controls.Add(this.grb_Cart_lbl_Cost);
            this.grb_Cart.Controls.Add(this.grb_Cart_lbl_Quantity);
            this.grb_Cart.Controls.Add(this.label4);
            this.grb_Cart.Controls.Add(this.label3);
            this.grb_Cart.Controls.Add(this.label2);
            this.grb_Cart.Controls.Add(this.label1);
            this.grb_Cart.Location = new System.Drawing.Point(766, 34);
            this.grb_Cart.Name = "grb_Cart";
            this.grb_Cart.Size = new System.Drawing.Size(262, 100);
            this.grb_Cart.TabIndex = 3;
            this.grb_Cart.TabStop = false;
            this.grb_Cart.Text = "Корзина покупок";
            // 
            // grb_Cart_tbx_Сoupon
            // 
            this.grb_Cart_tbx_Сoupon.Location = new System.Drawing.Point(96, 68);
            this.grb_Cart_tbx_Сoupon.Name = "grb_Cart_tbx_Сoupon";
            this.grb_Cart_tbx_Сoupon.Size = new System.Drawing.Size(100, 20);
            this.grb_Cart_tbx_Сoupon.TabIndex = 8;
            // 
            // grb_Cart_lbl_Discount
            // 
            this.grb_Cart_lbl_Discount.AutoSize = true;
            this.grb_Cart_lbl_Discount.Location = new System.Drawing.Point(95, 52);
            this.grb_Cart_lbl_Discount.Name = "grb_Cart_lbl_Discount";
            this.grb_Cart_lbl_Discount.Size = new System.Drawing.Size(22, 13);
            this.grb_Cart_lbl_Discount.TabIndex = 7;
            this.grb_Cart_lbl_Discount.Text = "0.0";
            // 
            // grb_Cart_lbl_Cost
            // 
            this.grb_Cart_lbl_Cost.AutoSize = true;
            this.grb_Cart_lbl_Cost.Location = new System.Drawing.Point(95, 36);
            this.grb_Cart_lbl_Cost.Name = "grb_Cart_lbl_Cost";
            this.grb_Cart_lbl_Cost.Size = new System.Drawing.Size(22, 13);
            this.grb_Cart_lbl_Cost.TabIndex = 6;
            this.grb_Cart_lbl_Cost.Text = "0.0";
            // 
            // grb_Cart_lbl_Quantity
            // 
            this.grb_Cart_lbl_Quantity.AutoSize = true;
            this.grb_Cart_lbl_Quantity.Location = new System.Drawing.Point(95, 20);
            this.grb_Cart_lbl_Quantity.Name = "grb_Cart_lbl_Quantity";
            this.grb_Cart_lbl_Quantity.Size = new System.Drawing.Size(13, 13);
            this.grb_Cart_lbl_Quantity.TabIndex = 5;
            this.grb_Cart_lbl_Quantity.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Сумма скидки:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Купон:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Общая сумма:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество:";
            // 
            // ltb_Messages
            // 
            this.ltb_Messages.FormattingEnabled = true;
            this.ltb_Messages.Location = new System.Drawing.Point(766, 173);
            this.ltb_Messages.Name = "ltb_Messages";
            this.ltb_Messages.Size = new System.Drawing.Size(262, 264);
            this.ltb_Messages.TabIndex = 4;
            // 
            // btn_PreviewOrder
            // 
            this.btn_PreviewOrder.Location = new System.Drawing.Point(766, 140);
            this.btn_PreviewOrder.Name = "btn_PreviewOrder";
            this.btn_PreviewOrder.Size = new System.Drawing.Size(128, 23);
            this.btn_PreviewOrder.TabIndex = 5;
            this.btn_PreviewOrder.Text = "Рассчитать";
            this.btn_PreviewOrder.UseVisualStyleBackColor = true;
            this.btn_PreviewOrder.Click += new System.EventHandler(this.btn_PreviewOrder_Click_1);
            // 
            // gv_Cart_clm_ID
            // 
            this.gv_Cart_clm_ID.HeaderText = "ID";
            this.gv_Cart_clm_ID.Name = "gv_Cart_clm_ID";
            this.gv_Cart_clm_ID.ReadOnly = true;
            this.gv_Cart_clm_ID.Visible = false;
            // 
            // gv_Cart_clm_Name
            // 
            this.gv_Cart_clm_Name.DataPropertyName = "Name";
            this.gv_Cart_clm_Name.HeaderText = "Название";
            this.gv_Cart_clm_Name.Name = "gv_Cart_clm_Name";
            this.gv_Cart_clm_Name.ReadOnly = true;
            // 
            // gv_Cart_clm_Quantity
            // 
            this.gv_Cart_clm_Quantity.DataPropertyName = "CartQuantity";
            this.gv_Cart_clm_Quantity.HeaderText = "Кол-во";
            this.gv_Cart_clm_Quantity.Name = "gv_Cart_clm_Quantity";
            // 
            // gv_Cart_clm_Cost
            // 
            this.gv_Cart_clm_Cost.DataPropertyName = "Cost";
            this.gv_Cart_clm_Cost.HeaderText = "Цена";
            this.gv_Cart_clm_Cost.Name = "gv_Cart_clm_Cost";
            this.gv_Cart_clm_Cost.ReadOnly = true;
            // 
            // gv_Cart_clm_Increase
            // 
            this.gv_Cart_clm_Increase.HeaderText = "+";
            this.gv_Cart_clm_Increase.Name = "gv_Cart_clm_Increase";
            this.gv_Cart_clm_Increase.Text = "+";
            this.gv_Cart_clm_Increase.ToolTipText = "Увеличить";
            this.gv_Cart_clm_Increase.UseColumnTextForButtonValue = true;
            // 
            // gv_Cart_clm_Decrease
            // 
            this.gv_Cart_clm_Decrease.HeaderText = "-";
            this.gv_Cart_clm_Decrease.Name = "gv_Cart_clm_Decrease";
            this.gv_Cart_clm_Decrease.Text = "-";
            this.gv_Cart_clm_Decrease.ToolTipText = "Уменьшить";
            this.gv_Cart_clm_Decrease.UseColumnTextForButtonValue = true;
            // 
            // gv_Cart_Remove
            // 
            this.gv_Cart_Remove.HeaderText = "Убрать";
            this.gv_Cart_Remove.Name = "gv_Cart_Remove";
            this.gv_Cart_Remove.Text = "--";
            this.gv_Cart_Remove.ToolTipText = "Убрать";
            this.gv_Cart_Remove.UseColumnTextForButtonValue = true;
            // 
            // gv_Cart_clm_BookQuantity
            // 
            this.gv_Cart_clm_BookQuantity.HeaderText = "";
            this.gv_Cart_clm_BookQuantity.Name = "gv_Cart_clm_BookQuantity";
            this.gv_Cart_clm_BookQuantity.ReadOnly = true;
            this.gv_Cart_clm_BookQuantity.Visible = false;
            // 
            // gv_Cart_clm_BookCost
            // 
            this.gv_Cart_clm_BookCost.HeaderText = "";
            this.gv_Cart_clm_BookCost.Name = "gv_Cart_clm_BookCost";
            this.gv_Cart_clm_BookCost.ReadOnly = true;
            this.gv_Cart_clm_BookCost.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 450);
            this.Controls.Add(this.btn_PreviewOrder);
            this.Controls.Add(this.ltb_Messages);
            this.Controls.Add(this.btn_CreateOrder);
            this.Controls.Add(this.grb_Cart);
            this.Controls.Add(this.tb_Container);
            this.Name = "Form1";
            this.Text = "Shop";
            this.tb_Container.ResumeLayout(false);
            this.tbp_Books.ResumeLayout(false);
            this.tbp_Books.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Books)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tbp_Cart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_Cart)).EndInit();
            this.grb_Cart.ResumeLayout(false);
            this.grb_Cart.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.TabControl tb_Container;
        private System.Windows.Forms.TabPage tbp_Books;
        private System.Windows.Forms.TabPage tbp_Cart;
        private System.Windows.Forms.DataGridView gv_Cart;
        private System.Windows.Forms.GroupBox grb_Cart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_CreateOrder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox ltb_Messages;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_filter;
        private System.Windows.Forms.TextBox tbx_Name;
        private System.Windows.Forms.ComboBox cmb_Genres;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Label lbl_CurPageText;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_Prev;
        private System.Windows.Forms.Label lbl_CurPage;
        private System.Windows.Forms.Label lbl_TotalPages;
        private System.Windows.Forms.Label label5;
  
        private System.Windows.Forms.DataGridView gv_Books;
        private System.Windows.Forms.DataGridViewTextBoxColumn gv_Books_clm_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gv_Books_clm_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn gv_Books_clm_GenreName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gv_Books_clm_Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn gv_Books_clm_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn gv_Books_clm_CartQuantity;
        private System.Windows.Forms.DataGridViewButtonColumn gv_Books_clm_AddCart;
        private System.Windows.Forms.Label grb_Cart_lbl_Discount;
        private System.Windows.Forms.Label grb_Cart_lbl_Cost;
        private System.Windows.Forms.Label grb_Cart_lbl_Quantity;
        private System.Windows.Forms.Button btn_PreviewOrder;
        private System.Windows.Forms.TextBox grb_Cart_tbx_Сoupon;
        private System.Windows.Forms.DataGridViewTextBoxColumn gv_Cart_clm_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gv_Cart_clm_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn gv_Cart_clm_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn gv_Cart_clm_Cost;
        private System.Windows.Forms.DataGridViewButtonColumn gv_Cart_clm_Increase;
        private System.Windows.Forms.DataGridViewButtonColumn gv_Cart_clm_Decrease;
        private System.Windows.Forms.DataGridViewButtonColumn gv_Cart_Remove;
        private System.Windows.Forms.DataGridViewTextBoxColumn gv_Cart_clm_BookQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn gv_Cart_clm_BookCost;
    }





   
}

