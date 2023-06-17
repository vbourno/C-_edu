using FavAudioApp.DTO;
using FavAudioApp.Model;

namespace FavAudioApp.Service
{
    /// <summary>
    /// Song service interface.
    /// </summary>
    public interface ISongService
    {
        void InsertSong(SongDTO? dto);
        void UpdateSong(SongDTO dto);
        Song DeleteSong(int id);
        Song GetSongById(int id);
        List<Song> GetAllsongs();
    }
}
