using FavAudioApp.DTO;
using FavAudioApp.Model;

namespace FavAudioApp.Service
{
    /// <summary>
    /// Podcast service interface.
    /// </summary>
    public interface IPodcastService
    {
        void InsertPodcast(PodcastDTO? dto);
        void UpdatePodcast(PodcastDTO dto);
        Podcast DeletePodcast(int id);
        Podcast GetPodcastById(int id);
        List<Podcast> GetAllPodcasts();
    }
}
