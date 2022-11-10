using Microsoft.AspNetCore.Mvc;
using web_app.Models;

namespace web_app.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FavouritesController : Controller
    {
        [HttpGet(Name = "GetFavourites")]
        public Favourites Get()
        {
            return new Favourites()
            {
                Song = "TestSong",
                Artist = "TestArtist",
                Album = "TestAlbum"
            };
        }
    }
}
