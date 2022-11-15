using web_app.Models;

namespace web_app.Services
{
    public class ArtistService
    {
        private List<Artist> _artistlist = new List<Artist> {
            new Artist()
            {
                Album = "Album",
                Name= "Test",
                Song = "_Song"
            },
            new Artist()
            {
                Song = "Song",
                Album= "Test",
                Name= "Test1",
            }
        };


        public Artist GetArtist()
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
