using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GroceryWebApi.DTO;
using GroceryServiceProject.Models;
using GroceryWebApi.Maps;
using GroceryServiceProject;

namespace GroceryWebApi.Servicies
{
    public class CategoryService
    {
        private readonly List<CategoryType> _categories;
        private MapCategoryType ctMapper;
        private GroceryWorkflow groceryWorkflow;

        public CategoryService()
        {
            groceryWorkflow = new GroceryWorkflow();
            groceryWorkflow.Connect();
            ctMapper = new MapCategoryType(groceryWorkflow.Categories);
            _categories = ctMapper.Category;
        }



        public IEnumerable<CategoryType> GetAll() => _categories;

        public CategoryType GetById(int id) => _categories.FirstOrDefault(p => p.CategoryId == id);
    }
}