using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMedsoft.Interfaces;

namespace TMedsoft.Data.Entities
{
    [Table("doc_OrderBooks")]
    public class OrderBook
    {
        [Key]
        public long OrderID { get; set; }

        public Order Order { get; set; }
        public long BookID { get; set; }
        public long Quantity { get; set; }
        public decimal Cost { get; set; }
        public decimal DiscountSum { get; set; }
    }
}