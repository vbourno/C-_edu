using FavAudioApp.Model;

namespace FavAudioApp.DAO
{
    /// <summary>
    /// DAO interface for Playlist.
    /// </summary>
    public interface IPlaylistDAO
    {
        void Insert(Playlist playlist);
        void Update(Playlist playlist);
        void Delete(int id);
        Playlist GetById(int id);
        List<Playlist> GetAll();
    }
}
