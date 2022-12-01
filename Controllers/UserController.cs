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

        private DbService<User> _userService;

        public UserController(DbService<User> userService)
        {
            _userService = userService;
        }


        [HttpGet("{id:long}")]
        public User Get(long id)
        {
            return _userService.GetById(id);
        }
        [HttpGet()]
        public IEnumerable<User> Get(string? search=null)
        {
            if (search == null)
            {
                return _userService.GetAll();
            }
            return _userService.GetAll().Where(x => x.Username.Contains(search, StringComparison.OrdinalIgnoreCase));
        }

        [HttpPost]
        public User Post([FromBody]User user)
        {
            _userService.Add(user);
            return user;
        }
    }
}
