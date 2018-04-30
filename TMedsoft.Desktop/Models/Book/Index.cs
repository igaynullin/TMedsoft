using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TMedsoft.ViewModels.Books;

using JsonConvert = TMedsoft.Desktop.Utils.Json.JsonConvert;

namespace TMedsoft.Desktop.Models.Book
{
    public class Index : IIndex
    {
        [JsonConverter(typeof(JsonConvert.ConcreteConverter<List<IndexItem>>))]
        public List<IIndexItem> Items { get; set; }

        public int Rows { get; set; }
    }

    public class IndexItem
    : IIndexItem
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string GenreName { get; set; }
        public decimal Cost { get; set; }
        public long Quantity { get; set; }
        public string CouponCode { get; set; }

        public long CartQuantity { get; set; } = 0;
    }
}