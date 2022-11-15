using web_app.Models;

namespace web_app.Services
{
    public class FavouritesService
    {
        public Favourites GetFavourites()
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
