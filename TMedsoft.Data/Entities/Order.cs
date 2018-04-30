using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMedsoft.Interfaces;
using Dapper;

namespace TMedsoft.Data.Entities
{
    [Table("doc_Orders")]
    public class Order : IHasID<long>, IHasName
    {
        [Key]
        public long ID { get; set; }

        public List<OrderBook> Books { get; set; }
        public string Name { get; set; }
        public long Quantity { get; set; }
        public decimal Cost { get; set; }
        public decimal DiscountSum { get; set; }
    }
}