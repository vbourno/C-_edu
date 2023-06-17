using FavAudioApp.Model;

namespace FavAudioApp.DAO
{
    /// <summary>
    /// DAO interface for Song.
    /// </summary>
    public interface ISongDAO
    {
        void Insert(Song song);
        void Update(Song song);
        void Delete(int id);
        Song GetById(int id);
        List<Song> GetAll();
    }
}
