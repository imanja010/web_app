using Microsoft.AspNetCore.Mvc;
using web_app.Models;
using web_app.Services;

namespace web_app.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FavouritesController : Controller
    {
        private DbService<Favourites> _exampleService;

        public FavouritesController(DbService<Favourites> exampleService)
        {
            _exampleService = exampleService;
        }

        [HttpGet("{id:long}")]
        public Favourites Get(long id)
        {
            return _exampleService.GetById(id);
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
            _exampleService.Add(favourites);
            return favourites;
        }

        [HttpDelete("{id:long}")]
        public void Delete(long id)
        {
            _exampleService.Remove(id);
        }
        [HttpPut]
        public Favourites Put([FromBody] Favourites favourites)
        {
            _exampleService.Put(favourites);
            return favourites;
        }
    }
}
