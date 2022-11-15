using Microsoft.AspNetCore.Mvc;
using web_app.Models;
using web_app.Services;

namespace web_app.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArtistController : Controller
    {
        private ArtistService _artistService;
        public ArtistController(ArtistService exempleService)
        {
            _artistService = exempleService;
        }
        [HttpGet(Name = "GetArtist")]
        public Artist Get()
        {
            Artist result = _artistService.GetArtist();
            return result;
        }
    }
}
