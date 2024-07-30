using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GroceryServiceProject.Models
{
    [Table("product_category")]
    public class ProductCategory
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
    }
}
