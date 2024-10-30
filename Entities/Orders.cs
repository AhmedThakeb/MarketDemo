using MarketDemo.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace MarketDemo.Entities
{
    public class Orders:CommonDate<int>
    {
        internal string Name;

        public  int SaleId { get; set; }
        [ForeignKey("SaleId")]
        public Sales Sales { get; set; }
        public int CustomeId { get; set;}
        [ForeignKey("CustomeId")]
        public Customers Customers { get; set; }
        public int ItemId { get;set;}
        [ForeignKey("ItemId")]
        public Items Items { get; set; }
    }
}
