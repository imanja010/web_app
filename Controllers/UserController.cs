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


        [HttpGet("{id:long}")]
        public User Get(long id)
        {
            User result = _userService.GetUser(id);
            result.Username = "Something else";
            return result;
        }
        [HttpGet()]
        public List<User> Get()
        {
            return _userService.Get();
        }
    }
}
