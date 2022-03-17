using System.Collections.Generic;
using System.Threading.Tasks;
using BLL.DTOS;
using BLL.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PerfumeShop.Controllers;

namespace BrilliantAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger, IProductService ProductService)
        {
            _logger = logger;
            _productService = ProductService;
        }

        [HttpGet("Get")]
        public async Task<ActionResult<IEnumerable<ProductDTO>>> Get()
        {
            return Ok(await _productService.GetAllProducts());
        }

        [HttpGet("GetById")]
        public async Task<ActionResult<IEnumerable<ProductDTO>>> GetById(int id)
        {
            if (id <= 0) return BadRequest();
            return Ok(await _productService.GetProductById(id));
        }
        [HttpPost("Add")]
        public async Task<IActionResult> Add(ProductDTO Product)
        {
            if (Product == null) return BadRequest();
            await _productService.AddProduct(Product);
            return Ok("Successfully created new Product!");
        }
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            if (id == 0) return BadRequest();
            await _productService.DeleteProductById(id);
            return Ok("Successfully deleted selected Product!");
        }

        [HttpPut]
        public async Task<IActionResult> EditProduct(ProductDTO Product)
        {
            await _productService.EditProduct(Product);
            return Ok("Successfully edited Product!");
        }
    }
}
