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
        public List<Favourites> Get()
        {

            return _exampleService.GetAll();
        }
    }
}
