using web_app.Models;

namespace web_app.Services
{
    public class ArtistService
    {
        private List<Artist> _artistlist = new List<Artist> {
            new Artist()
            {
                Id=1,
                Album = "Album",
                Name= "Test",
                Song = "_Song"
            },
            new Artist()
            {
                Id=2,
                Song = "Song",
                Album= "Test",
                Name= "Test1",
            }
        };


        public Artist GetArtist(long id)
        {
            return _artistlist.FirstOrDefault(a => a.Id == id);
        }
        public List<Artist> GetArtists()
        {
            return _artistlist;
        }

    }


}
