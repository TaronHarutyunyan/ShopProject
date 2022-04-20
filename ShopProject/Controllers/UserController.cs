using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopProject.Models;
using ShopProject.Services;
using System;

namespace ShopProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult GetAllUsers()
        {
            try
            {
                var users = _userService.GetAllUsers();
                if(users == null) return NotFound();
                else return Ok(users);
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
        }
        [HttpPost]
        public IActionResult CreateUser(User user)
        {
            try
            {
                if (user == null) return BadRequest();
                _userService.CreateUser(user);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
        [HttpDelete]
        public IActionResult DeleteUser(int id)
        {
            try
            {
                _userService.DeleteUser(id);
                return Ok();
            }
            catch(Exception ex)
            {
                return NotFound(ex);
            }
        }
        [HttpGet("{id}")]
        public IActionResult GetUserById(int id)
        {
            try
            {
                var user = _userService.GetUserById(id);
                return Ok(user);
            }
            catch(Exception ex)
            {
                return NotFound(ex);
            }
        }

    }
}
