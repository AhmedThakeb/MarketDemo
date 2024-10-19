namespace MarketDemo.Models
{
    public class OrdersVM
    {
        public int Id { get; set; }
        public int SalesId { get; set; }
        public int CustomersId { get; set; }
        public int ItemsId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
    }
}
