using FavAudioApp.DAO.DBUtil;
using FavAudioApp.Model;
using System.Data.SqlClient;

namespace FavAudioApp.DAO
{
    /// <summary>
    /// Song implementation.
    /// </summary>
    public class SongDAOImpl : ISongDAO
    {
        /// <summary>
        /// Inserts a new song into the DB.
        /// </summary>
        /// <param name="song"></param>
        public void Insert(Song song)
        {
            if (song == null)
            {
                return;
            }
            try
            {
                using SqlConnection connection = DBHelper.MakeConnection();
                connection.Open();
                string sql = "INSERT INTO SONGS (TITLE, URL, ARTIST, GENRE) VALUES (@title, @url, @artist, @genre)";
                using SqlCommand command = new(sql, connection);

                command.Parameters.AddWithValue("@title", song.Title);
                command.Parameters.AddWithValue("@url", song.Url);
                command.Parameters.AddWithValue("@artist", song.Artist);
                command.Parameters.AddWithValue("@genre", song.Genre);
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                throw;
            }
        }

        /// <summary>
        /// Updates an existing song.
        /// </summary>
        /// <param name="song"></param>
        public void Update(Song song)
        {
            if (song == null)
            {
                return;
            }

            try
            {
                using SqlConnection connection = DBHelper.MakeConnection();
                connection.Open();
                string sql = "UPDATE SONGS SET TITLE=@title, URL=@url, ARTIST=@artist, GENRE=@genre WHERE ID=@id";

                using SqlCommand command = new(sql, connection);
                command.Parameters.AddWithValue("@title", song.Title);
                command.Parameters.AddWithValue("@url", song.Url);
                command.Parameters.AddWithValue("@artist", song.Artist);
                command.Parameters.AddWithValue("@genre", song.Genre);
                command.Parameters.AddWithValue("@id", song.Id);
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                throw;
            }
        }

        /// <summary>
        /// Deletes a song from the DB.
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            try
            {
                using SqlConnection connection = DBHelper.MakeConnection();
                connection.Open();
                string sql = "DELETE FROM SONGS WHERE ID=@id";
                using SqlCommand command = new(sql, connection);
                command.Parameters.AddWithValue("@id", id);
                int rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                throw;
            }
        }

        /// <summary>
        /// Returns a song by its id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>song</returns>
        public Song GetById(int id)
        {
            Song song = null;
            try
            {
                using SqlConnection connection = DBHelper.MakeConnection();
                connection.Open();
                string sql = "SELECT * FROM SONGS WHERE ID=@id";
                using SqlCommand command = new(sql, connection);
                command.Parameters.AddWithValue("@id", id);

                using SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    song = new()
                    {
                        Id = reader.GetInt32(0),
                        Title = reader.GetString(1),
                        Url = reader.GetString(2),
                        Artist = reader.GetString(3),
                        Genre = reader.GetString(4)
                    };
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                throw;
            }

            return song;
        }

        /// <summary>
        /// Returns all songs of the DB.
        /// </summary>
        /// <returns>songs</returns>
        public List<Song> GetAll()
        {
            List<Song> songs = new List<Song>();
            try
            {
                using SqlConnection connection = DBHelper.MakeConnection();
                connection.Open();
                string sql = "SELECT * FROM SONGS";
                using SqlCommand command = new(sql, connection);
                using SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Song song = new()
                    {
                        Id = reader.GetInt32(0),
                        Title = reader.GetString(1),
                        Url = reader.GetString(2),
                        Artist = reader.GetString(3),
                        Genre = reader.GetString(4)
                    };

                    songs.Add(song);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                throw;
            }
            return songs;
        }        
    }
}
