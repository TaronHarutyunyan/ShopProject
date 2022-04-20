using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopProject.Models;
using ShopProject.Services;
using System;

namespace ShopProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private IOrderService _service;
        public OrderController(IOrderService service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult GetAllOrders()
        {
            try
            {
                var orders = _service.GetAllOrders();
                if(orders == null) return NotFound("No Orders");
                return Ok(orders);
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
        }
        [HttpGet("{id}")]
        public IActionResult GetOrderById(int id)
        {
            try
            {
               var user = _service.GetOrderById(id);
                if (user == null) return NotFound();
                return Ok(user);    
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
        [HttpPost]
        public IActionResult CreateOrder(Order Order)
        {
            try
            {
                if (Order == null) return BadRequest("Argument is Null");
                _service.CreateOrder(Order);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
        [HttpDelete]
        public IActionResult DeleteOrder(int id)
        {
            try
            {
                _service.DeleteOrder(id);
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
        }

    }
}
