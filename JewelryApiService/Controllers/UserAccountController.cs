using JewelryApiService.DAL.Interfaces;
using JewelryApiService.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JewelryApiService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserAccountController : ControllerBase
    {

        private readonly ILogger<UserAccountController> _logger;

        private readonly iUserAccountDAL _iUserAccountDAL;
        public UserAccountController(ILogger<UserAccountController> logger, iUserAccountDAL iUserAccountDAL)
        {
            _logger = logger;
            _iUserAccountDAL = iUserAccountDAL;
        }
        // User Login
        [HttpPost("UserLogin")]
        public async Task<IActionResult> Login([FromBody] User user)
        {
            //Model check

            if (user != null && !ModelState.IsValid)
            {
                return BadRequest();
            }
            var userObject = await _iUserAccountDAL.UserLogin(user);
            if (userObject == null)
            {
                return NoContent();
            }
            return Ok(userObject);
        }
    }
}
