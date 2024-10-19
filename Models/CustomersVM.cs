namespace MarketDemo.Models
{using System.ComponentModel.DataAnnotations;
    public class CustomersVM
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="You Must Import Data")] 
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
    }
}
