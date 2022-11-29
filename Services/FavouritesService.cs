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

        public void AddFav(Favourites favourites)
        {
            favouritesList.Add(favourites);
        }

        internal void Remove(long id)
        {
            var itemForRemoval = favouritesList.FirstOrDefault(x => x.Id == id);
            if (itemForRemoval != null)
            {
                favouritesList.Remove(itemForRemoval);
            }
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
