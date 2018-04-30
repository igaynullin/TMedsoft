using Dapper;
using TMedsoft.Interfaces;

namespace TMedsoft.Data.Entities
{
    [Table("ref_Books")]
    public class Book : IHasID<long>, IHasName
    {
        [Key]
        public long ID { get; set; }

        public string Name { get; set; }
        public long GenreID { get; set; }
        public long Quantity { get; set; }
        public decimal Cost { get; set; }

        public Genre Genre { get; set; }
    }
}