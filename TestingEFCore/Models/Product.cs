using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestingEFCore.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Price { get; set; }

        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
