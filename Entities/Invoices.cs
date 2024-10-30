using MarketDemo.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MarketDemo.Entities
{
    public class Invoices : CommonDate<int>
    {
        [Required]
        [StringLength(15)]
        public string Name { get; set; }
        public int OrderId { get; set; }
        [ForeignKey("OrderId")]
        public Orders Order { get; set; }
    }
}
