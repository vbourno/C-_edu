namespace FavAudioApp.Model
{
    /// <summary>
    /// Playlist model class.
    /// </summary>
    public class Playlist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string? Genre { get; set; }
    }
}
