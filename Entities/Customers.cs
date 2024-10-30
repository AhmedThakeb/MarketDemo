using MarketDemo.Common;

namespace MarketDemo.Entities
{
    public class Customers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
    }
}
