// Controllers/ProductController.cs
using Microsoft.AspNetCore.Mvc;
using GroceryServiceProject.Models;
using GroceryWebApi.Servicies;
using System.Collections.Generic;
using GroceryWebApi.Maps;
using GroceryWebApi.DTO;

namespace GroceryWebApi.Controllers
{
    [ApiController]
    [Route("api/categories")]
    public class CategoryController : ControllerBase
    {
        private readonly CategoryService categoryService;

        public CategoryController()
        {
            categoryService = new CategoryService();
        }

        [HttpGet]
        public ActionResult<IEnumerable<CategoryType>> Get()
        {
            var categories = categoryService.GetAll();
            return Ok(categories);
        }

        // GET: api/categories/{id}
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            var category = categoryService.GetById(id);
            if (category == null)
            {
                return NotFound();
            }
            return Ok(category);
        }
    }
}
