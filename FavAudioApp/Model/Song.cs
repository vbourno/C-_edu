namespace FavAudioApp.Model
{
    /// <summary>
    /// Song model class.
    /// </summary>
    public class Song
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string? Artist { get; set; }
        public string? Genre { get; set; }
    }
}
