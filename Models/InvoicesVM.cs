namespace MarketDemo.Models
{
    public class InvoicesVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int OrdersId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
    }
}
