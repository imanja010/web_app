using Microsoft.AspNetCore.Mvc;
using web_app.Models;
using web_app.Services;

namespace web_app.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArtistController : Controller
    {
        private DbService<Artist> _artistService;
        public ArtistController(DbService<Artist> exempleService)
        {
            _artistService = exempleService;
        }
        [HttpGet("{id:long}")]
        public Artist Get(long id)
        {
            Artist result = _artistService.GetById(id);
            return result;
        }

        [HttpGet()]
        public IEnumerable<Artist> Get([FromQuery]string? search=null)
        {
            if (search == null)
            {
                return _artistService.GetAll();
            }
            return _artistService.GetAll()
                .Where(x => x.Name
                .Contains(search, StringComparison.OrdinalIgnoreCase));

        }
        [HttpPost]
        public Artist Post([FromBody] Artist artists)
        {
            _artistService.Add(artists);
            return artists;
        }

        [HttpDelete("{id:long}")]
        public void Delete(long id)
        {
            _artistService.Remove(id);
        }
        [HttpPut]
        public Artist Put([FromBody]Artist artist)
        {
            _artistService.Put(artist);
            return artist;
        }
    }

}
