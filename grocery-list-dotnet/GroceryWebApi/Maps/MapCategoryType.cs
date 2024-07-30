using GroceryWebApi.DTO;
using GroceryServiceProject.Models;

namespace GroceryWebApi.Maps
{
    public class MapCategoryType
    {
        public List<CategoryType> Category {get;}

        public MapCategoryType(List<ProductCategory> productCategory)
        {
            Category = new List<CategoryType>();

            foreach(var category in productCategory)
            {
                var ct = new CategoryType (){CategoryId = category.id, CategoryName = category.name};
                Category.Add(ct);
            }
        }
    }
}