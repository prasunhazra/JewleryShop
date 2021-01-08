using JewleryAPI.Modal;
using JewleryAPI.service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JewleryAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {
        private IUserService UserService;
        public LoginController(IUserService userService)
        {
            UserService = userService;
        }
      
        [HttpPost]
        public IActionResult Login([FromBody]AuthenticationModal modal)
        {
            User user = UserService.Authenticate(modal.UserName, modal.Password);
            if (user == null)
                return BadRequest("Ivalid Username/password");
            return Ok();
        }
    }
}
