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

        public void AddArtist(Artist artists)
        {
            _artistlist.Add(artists);
        }

        internal void Remove(long id)
        {
            var item = _artistlist.FirstOrDefault(_ => _.Id == id);
            if (item != null)
            {
                _artistlist.Remove(item);
            }
        }
    }


}
