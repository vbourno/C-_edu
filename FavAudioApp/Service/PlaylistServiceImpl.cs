using FavAudioApp.DAO;
using FavAudioApp.DTO;
using FavAudioApp.Model;

namespace FavAudioApp.Service
{
    /// <summary>
    /// Playlist service implementation.
    /// </summary>
    public class PlaylistServiceImpl : IPlaylistService
    {
        private readonly IPlaylistDAO dao;

        public PlaylistServiceImpl(IPlaylistDAO dao)
        {
            this.dao = dao;
        }

        /// <summary>
        /// Inserts playlist.
        /// </summary>
        /// <param name="dto"></param>
        public void InsertPlaylist(PlaylistDTO? dto)
        {
            if (dto == null) return;

            Playlist playlist = Map(dto);

            try
            {
                dao.Insert(playlist);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                throw;
            }
        }

        /// <summary>
        /// Updates playlist.
        /// </summary>
        /// <param name="dto"></param>
        public void UpdatePlaylist(PlaylistDTO dto)
        {
            if (dto == null) return;

            Playlist playlist = Map(dto);

            try
            {
                dao.Update(playlist);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                throw;
            }
        }

        /// <summary>
        /// Deletes playlist.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>playlist</returns>
        public Playlist DeletePlaylist(int id)
        {
            Playlist playlist;
            try
            {
                playlist = dao.GetById(id);
                if (playlist is null) return null;
                dao.Delete(id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                throw;
            }
            return playlist;
        }

        /// <summary>
        /// Returns a playlist by its id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>playlist</returns>
        public Playlist GetPlaylistById(int id)
        {
            try
            {
                return dao.GetById(id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                throw;
            }
        }

        /// <summary>
        /// Returns all playlists.
        /// </summary>
        /// <returns>playlists</returns>
        public List<Playlist> GetAllPlaylists()
        {
            try
            {
                return dao.GetAll();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                throw;
            }
        }

        /// <summary>
        /// Converts playlist to DAO.
        /// </summary>
        /// <param name="dto"></param>
        /// <returns>playlist</returns>
        private Playlist Map(PlaylistDTO dto)
        {
            if (dto == null) return null;
            Playlist playlist = new Playlist()
            {
                Id = dto.Id,
                Name = dto.Name,
                Url = dto.Url,
                Genre = dto.Genre,
            };

            return playlist;
        }
    }
}
