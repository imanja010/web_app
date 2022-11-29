using web_app.Models;

namespace web_app.Services
{
    public class SongService
    {
        public Song GetSong(long id)
        {
            return songList.FirstOrDefault(x => x.Id == id);


        }
        public List<Song> GetAll()
        {
            return songList;


        }
        private List<Song> songList = new List<Song>
        {
            new Song()
            {
                Id = 1,
                SongName = "Insomnia",
                SongArtist = "Karleusa",
                SongDescription = "Najjaca pesma ikada, nasa najbolja umetnica je kreirala najjaca je",
                SongAlbum = "Diva"

            },
            new Song() 
            {
                Id= 2,
                SongAlbum="Kokain",
                SongArtist ="Aca Lukas",
                SongName = "Volis li me",
                SongDescription = "Volis li me kad sam mrtav pijan, volis li me kad pravi sam grubijan, volis li me kad okolo se ku*vam"
            },
            new Song()
            {
                Id =3,
                SongAlbum="Core",
                SongArtist="Stone temple pilots",
                SongDescription="A IM SMELLING LIKE THE ROSES SOMEBODY GAVE ME ON MY BIRTHDAY DEATHBED",
                SongName="Dead and bloated"
                
            },
        };
    }
}
