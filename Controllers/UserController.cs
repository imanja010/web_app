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
            return result;
        }
        [HttpGet()]
        public IEnumerable<User> Get(string? search=null)
        {
            if (search == null)
            {
                return _userService.Get();
            }
            return _userService.Get().Where(x => x.Username.Contains(search, StringComparison.OrdinalIgnoreCase));
        }

        [HttpPost]
        public User Post([FromBody]User user)
        {
            _userService.AddUser(user);
            return user;
        }
    }
}
