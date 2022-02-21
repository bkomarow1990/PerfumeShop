using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using BLL.DTOS;
using BLL.Interfaces;
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

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CategoryDTO>>> Get()
        {
            return Ok(await _categoryService.GetAllCategoriesAsync());
        }
    }
}
