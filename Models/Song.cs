namespace web_app.Models
{
    public class Song: Entity
    {
        public string SongName { get; set; }
        public string SongArtist { get; set; }
        public string SongDescription { get; set; }
        public string SongAlbum { get; set; }
    }
}
