using System.ComponentModel.DataAnnotations;

namespace Crud_Web.Models
{
    public class Product
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
