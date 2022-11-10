using Microsoft.AspNetCore.Mvc;
using web_app.Models;

namespace web_app.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArtistController : Controller
    {
        [HttpGet(Name = "GetArtist")]
        public Artist Get()
        {
            return new Artist()
            {
                Name = "TestName",
                Album = "TestAlbum",
                Song = "TestSong"
            };

        }
    }
}
