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
        [HttpGet(Name = "GetSong")]
        public Song Get()
        {
           Song result = _songService.GetSong();
            result.SongArtist = "Nesto drugo";
            return result;
        }
    }
}
