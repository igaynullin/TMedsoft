using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMedsoft.ViewModels.Books;

namespace TMedsoft.Desktop.Models.Cart
{
    public class Create
    {
        public List<CreateItem> Items { get; set; }
        public string CouponCode { get; set; }
    }

    public class CreateItem
    {
        public long Quantity { get; set; }
        public string ID { get; set; }
        public long GenreID { get; set; }
        public decimal Cost { get; set; }
        public decimal DiscountSum { get; set; }
    }
}