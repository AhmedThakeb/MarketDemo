using MarketDemo.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace MarketDemo.Entities
{
    public class Orders:CommonDate<int>
    {
        internal string Name { get; set; }
        public int Qty { get; set; }
        public decimal TotalItemPrice { get; set; }
        [ForeignKey("Sales")]
        public  int SaleId { get; set; }
        public Sales Sales { get; set; }
        [ForeignKey("Customers")]
        public int CustomeId { get; set;}
        public Customers Customers { get; set; }
        [ForeignKey("Items")]
        public int ItemId { get;set;}
        public Items Items { get; set; }
    }
}
