using FavAudioApp.DAO;
using FavAudioApp.DTO;
using FavAudioApp.Model;

namespace FavAudioApp.Service
{
    /// <summary>
    /// Song service implementation.
    /// </summary>
    public class SongServiceImpl : ISongService
    {
        private readonly ISongDAO dao;

        public SongServiceImpl(ISongDAO dao)
        {
            this.dao = dao;
        }

        /// <summary>
        /// Inserts song.
        /// </summary>
        /// <param name="dto"></param>
        public void InsertSong(SongDTO? dto)
        {
            if (dto == null) return;

            Song song = Map(dto);

            try
            {
                dao.Insert(song);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                throw;
            }
        }

        /// <summary>
        /// Updates song.
        /// </summary>
        /// <param name="dto"></param>
        public void UpdateSong(SongDTO dto)
        {
            if (dto == null) return;

            Song song = Map(dto);

            try
            {
                dao.Update(song);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                throw;
            }
        }

        /// <summary>
        /// Deletes song.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>song</returns>
        public Song DeleteSong(int id)
        {
            Song song;
            try
            {
                song = dao.GetById(id);
                if (song is null) return null;
                dao.Delete(id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                throw;
            }
            return song;
        }

        /// <summary>
        /// Returns song by its id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>song</returns>
        public Song GetSongById(int id)
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
        /// Returns all songs.
        /// </summary>
        /// <returns>songs</returns>
        public List<Song> GetAllsongs()
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
        /// Converts song to DAO
        /// </summary>
        /// <param name="dto"></param>
        /// <returns>song</returns>
        private Song Map(SongDTO dto)
        {
            if (dto == null) return null;
            Song song = new Song()
            {
                Id = dto.Id,
                Title = dto.Title,
                Url = dto.Url,
                Artist = dto.Artist,
                Genre = dto.Genre,
            };

            return song;
        }
    }
}
