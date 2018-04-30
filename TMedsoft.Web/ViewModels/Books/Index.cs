using System.Collections.Generic;
using TMedsoft.ViewModels.Books;

namespace TMedsoft.Web.ViewModels.Books
{
    public class Index : IIndex
    {
        public List<IIndexItem> Items { get; set; }
        public int Rows { get; set; }
    }

    public class IndexItem : IIndexItem
    {
        public string GenreName { get; set; }
        public decimal Cost { get; set; }
        public long Quantity { get; set; }
        public string CouponCode { get; set; }
        public string ID { get; set; }
        public string Name { get; set; }
    }
}