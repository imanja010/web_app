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
        [HttpGet("{id:long}")]
        public Artist Get(long id)
        {
            Artist result = _artistService.GetArtist(id);
            return result;
        }

        [HttpGet()]
        public List<Artist> Get()
        {
            return _artistService.GetArtists();

        }

    }
}
