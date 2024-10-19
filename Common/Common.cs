using System.ComponentModel.DataAnnotations;

namespace MarketDemo.Common
{
    public class Common<T>
    {
        [Key]
        public int Id { get; set; }
    }
}
