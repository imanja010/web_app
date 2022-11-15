using Microsoft.AspNetCore.Mvc;
using web_app.Models;

namespace web_app.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        [HttpGet(Name = "User")]
        public User Get()
        {
            return new User()
            {
                Username = "Test Username",
                Password = "Test Password",
                Email = "Test Email"
            };
        }
    }
}
