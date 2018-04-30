using TMedsoft.Interfaces;

namespace TMedsoft.Data.Entities
{
    public class DiscountRule : IHasID<long>, IHasName
    {
        public long DiscountID { get; set; }

        public int BookRequired
        {
            get;
            set;
        }

        public long ID { get; set; }

        public string Name
        {
            get;
            set;
        }
    }
}