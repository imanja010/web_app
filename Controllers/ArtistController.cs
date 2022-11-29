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
        public IEnumerable<Artist> Get([FromQuery]string? search=null)
        {
            if (search == null)
            {
                return _artistService.GetArtists();
            }
            return _artistService.GetArtists()
                .Where(x => x.Name
                .Contains(search, StringComparison.OrdinalIgnoreCase));

        }
        [HttpPost]
        public Artist Post([FromBody] Artist artists)
        {
            _artistService.AddArtist(artists);
            return artists;
        }

        [HttpDelete("{id:long}")]
        public void Delete(long id)
        {
            _artistService.Remove(id);
        }
    }
}
