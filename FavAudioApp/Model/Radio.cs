namespace FavAudioApp.Model
{
    /// <summary>
    /// Radio model class.
    /// </summary>
    public class Radio
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string? Genre { get; set; }
        public string? Region { get; set; }
    }
}
