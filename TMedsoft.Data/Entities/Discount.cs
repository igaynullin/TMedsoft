using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMedsoft.Interfaces;
using Dapper;

namespace TMedsoft.Data.Entities
{
    [Table("ref_Discounts")]
    public class Discount : IHasID<long>, IHasName
    {
        [Key]
        public long ID { get; set; }

        public string Name { get; set; }
        public decimal Percentage { get; set; }
        public string CouponCode { get; set; }

        public IEnumerable<long> DiscountGenres { get; set; }
        public IEnumerable<long> DiscountBooks { get; set; }

        public long BookRequired { get; set; }
        public TypeDiscount TypeDiscount { get; set; }
    }
}