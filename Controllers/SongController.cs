using Microsoft.AspNetCore.Mvc;
using web_app.Models;
using web_app.Services;

namespace web_app.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SongController : Controller
    {
        private SongService _songService;

        public SongController(SongService  songService)
        {
            _songService = songService;
        }
        [HttpGet("{id:long}")]
        public Song Get(long id)
        {
           Song result = _songService.GetSong(id);
           return result;
        }
        [HttpGet()]
        public IEnumerable<Song> Get([FromQuery] string? search = null)
        {
            if (search == null)
            {
                return _songService.GetAll();
            }
            IEnumerable<Song> result = _songService.GetAll()
                .Where(x=> x.SongName
                .Contains(search, StringComparison.OrdinalIgnoreCase));
            return result;
        }
        [HttpPost]
        public Song Post([FromBody] Song song)
        {
            
            _songService.AddSong(song);
            return song;
        }
        [HttpDelete("{id:long}")]
        public void Delete( long id)
        {

            _songService.Remove(id);
        }
    }
}
