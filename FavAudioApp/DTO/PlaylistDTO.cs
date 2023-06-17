namespace FavAudioApp.DTO
{
    /// <summary>
    /// DTO interface for Playlist.
    /// </summary>
    public class PlaylistDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string? Genre { get; set; }
    }
}
