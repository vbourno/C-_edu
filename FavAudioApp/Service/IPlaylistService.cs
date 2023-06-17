using FavAudioApp.DTO;
using FavAudioApp.Model;

namespace FavAudioApp.Service
{
    /// <summary>
    /// Playlist service interface.
    /// </summary>
    public interface IPlaylistService
    {
        void InsertPlaylist(PlaylistDTO? dto);
        void UpdatePlaylist(PlaylistDTO dto);
        Playlist DeletePlaylist(int id);
        Playlist GetPlaylistById(int id);
        List<Playlist> GetAllPlaylists();
    }
}
