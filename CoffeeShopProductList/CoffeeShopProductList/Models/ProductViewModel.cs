using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CoffeeShopProductList.Models
{
    public class ProductViewModel
    {
        [DisplayName("Product ID")]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        [DisplayName("Product Name")]
        public string Name { get; set; }
        [MaxLength(20)]
        [DisplayName("Product Description")]
        public string Description { get; set; }

        [DisplayName("Product Price")]
        public decimal Price { get; set; }

        [DisplayName("Product Category")]
        public string Category { get; set; }
    }
}
