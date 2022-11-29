using web_app.Models;

namespace web_app.Services
{
    public class FavouritesService
    {
        public Favourites GetFavourites(long id)
        {
           return favouritesList.FirstOrDefault(x => x.Id == id);
        }
        public List<Favourites> GetAll()
        {
            return favouritesList;
        }
        private List<Favourites> favouritesList = new List<Favourites>
        {
         new Favourites()
         {
             Album ="Album1",
             Song = "Song1",
             Artist= "Artist2",
             Id=1

         },
         new Favourites()
         {
             Album ="Album2",
             Song = "Song3",
             Artist= "Artist1",
             Id=2


         }
        };
    }
}
