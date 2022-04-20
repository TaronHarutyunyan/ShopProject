using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopProject.Models;
using ShopProject.Services;
using System;

namespace ShopProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductService _service;
        public ProductController(IProductService service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult GetAllProducts()
        {
            try
            {
                var products = _service.GetAllProducts();
                if(products == null) return NotFound("No Products");
                return Ok(products);
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
        }
        [HttpGet("{id}")]
        public IActionResult GetProductById(int id)
        {
            try
            {
                return Ok(_service.GetProductById(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
        [HttpDelete]
        public IActionResult DeleteProduct(int id)
        {
            try
            {
                _service.DeleteProduct(id);
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
        }
        [HttpPost]
        public IActionResult CreateProduct(Product product)
        {
            try
            {
                if (product == null) return BadRequest("Argument Is Null");
                _service.CreateProduct(product);
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
        }
        
    }
}
