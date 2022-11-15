using Microsoft.AspNetCore.Mvc;
using System.Drawing;
using web_app.Models;
using web_app.Services;

namespace web_app.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        private UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }


        [HttpGet(Name = "GetUser")]
        public User Get()
        {
            User result = _userService.GetUser();
            result.Username = "Something else";
            return result;
        }
    }
}
