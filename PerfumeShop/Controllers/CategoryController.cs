using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using BLL.DTOS;
using BLL.Interfaces;
using DAL.Data;
using DAL.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace PerfumeShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly ILogger<CategoryController> _logger;

        public CategoryController(ILogger<CategoryController> logger, ICategoryService categoryService)
        {
            _logger  = logger;
            _categoryService = categoryService;
        }

        [HttpGet("Get")]
        public async Task<ActionResult<IEnumerable<CategoryDTO>>> Get()
        {
            return Ok(await _categoryService.GetAllCategoriesAsync());
        }

        [HttpGet("GetById")]
        public async Task<ActionResult<IEnumerable<CategoryDTO>>> GetById(int id)
        {
            if (id <= 0) return BadRequest();
            return Ok(await _categoryService.GetCategoryById(id));
        }
        [HttpPost("Add")]
        public async Task<IActionResult> Add(CategoryDTO category)
        {
            if (category == null) return BadRequest();
            await _categoryService.AddCategory(category);
            return Ok("Successfully created new category!");
        }
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            if (id == 0) return BadRequest();
            await _categoryService.DeleteCategoryById(id);
            return Ok("Successfully deleted selected category!");
        }

        [HttpPut]
        public async Task<IActionResult> EditCategory(CategoryDTO category)
        {
            await _categoryService.EditCategory(category);
            return Ok("Successfully edited category!");
        }
    }
}
