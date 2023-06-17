namespace FavAudioApp.DTO
{
    /// <summary>
    /// DTO interface for Song.
    /// </summary>
    public class SongDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string? Artist { get; set; }
        public string? Genre { get; set; }
    }
}
