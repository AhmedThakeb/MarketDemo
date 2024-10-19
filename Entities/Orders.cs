using MarketDemo.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace MarketDemo.Entities
{
    public class Orders:CommonDate<int>
    {
        internal string Name;

        public  int SalesId { get; set; }
        [ForeignKey("SalesId")]
        public Sales Sales { get; set; }
        public int CustomesId { get; set;}
        [ForeignKey("CustomesId")]
        public Customers Customers { get; set; }
        public int ItemsId { get;set;}
        [ForeignKey("ItemsId")]
        public Items Items { get; set; }
    }
}
