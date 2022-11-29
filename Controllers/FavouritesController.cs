using Microsoft.AspNetCore.Mvc;
using web_app.Models;
using web_app.Services;

namespace web_app.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FavouritesController : Controller
    {
        private FavouritesService _exampleService;

        public FavouritesController(FavouritesService exampleService)
        {
            _exampleService = exampleService;
        }

        [HttpGet("{id:long}")]
        public Favourites Get(long id)
        {
            return _exampleService.GetFavourites(id);
        }

        [HttpGet()]
        public IEnumerable<Favourites> Get([FromQuery] string? search = null)
        {
            if (search == null)
            {
                return _exampleService.GetAll();
            }

            return _exampleService.GetAll()
                .Where(x => x.Song
                .Contains(search, StringComparison.OrdinalIgnoreCase));
        }

        [HttpPost]
        public Favourites Post([FromBody] Favourites favourites)
        {
            _exampleService.AddFav(favourites);
            return favourites;
        }

        [HttpDelete("{id:long}")]
        public void Delete(long id)
        {
            _exampleService.Remove(id);
        }
    }
}
