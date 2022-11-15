using Microsoft.AspNetCore.Mvc;
using web_app.Models;

namespace web_app.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SongController : Controller
    {
        [HttpGet(Name = "GetSong")]
        public Song Get()
        {
            return new Song()
            {
                SongName = "Insomnia",
                SongArtist = "Karleusa",
                SongDescription = "Najjaca pesma ikada, nasa najbolja umetnica je kreirala najjaca je",
                SongAlbum = "Diva"
            };

        }
    }
}
