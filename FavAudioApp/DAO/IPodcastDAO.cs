using FavAudioApp.Model;

namespace FavAudioApp.DAO
{
    /// <summary>
    /// DAO interface for Podcast.
    /// </summary>
    public interface IPodcastDAO
    {
        void Insert(Podcast podcast);
        void Update(Podcast podcast);
        void Delete(int id);
        Podcast GetById(int id);
        List<Podcast> GetAll();
    }
}
