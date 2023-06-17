namespace FavAudioApp.DTO
{
    /// <summary>
    /// DTO interface for Radio.
    /// </summary>
    public class RadioDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string? Genre { get; set; }
        public string? Region { get; set; }
    }
}
