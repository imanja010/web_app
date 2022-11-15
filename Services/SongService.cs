using web_app.Models;

namespace web_app.Services
{
    public class SongService
    {
        public Song GetSong()
        {
            return new Song()
            {
                SongName = "Insomnia",

                SongArtist = "Karleusa",

                SongDescription = "Najjaca pesma ikada, nasa najbolja umetnica je kreirala najjaca je",

                SongAlbum = "Diva"

            };
        }
        private List<Song> songList = new List<Song>
        {
            new Song() 
            {
                SongAlbum="Kokain",
                SongArtist ="Aca Lukas",
                SongName = "Volis li me",
                SongDescription = "Volis li me kad sam mrtav pijan, volis li me kad pravi sam grubijan, volis li me kad okolo se ku*vam"
            },
            new Song()
            {
                SongAlbum="Core",
                SongArtist="Stone temple pilots",
                SongDescription="A IM SMELLING LIKE THE ROSES SOMEBODY GAVE ME ON MY BIRTHDAY DEATHBED",
                SongName="Dead and bloated"
                
            },
        };
    }
}
