using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Depitest.Model
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }

        public string Description { get; set; } = string.Empty;
        public int quantity { get; set; }
        public string ImageAddress { get; set; } = string.Empty;

        public int CategoryId { get; set; }
        public virtual User? Categoray { get; set; }
    }
}
