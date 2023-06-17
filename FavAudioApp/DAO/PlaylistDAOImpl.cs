using FavAudioApp.DAO.DBUtil;
using FavAudioApp.Model;
using System.Data.SqlClient;

namespace FavAudioApp.DAO
{
    /// <summary>
    /// Playlist Implementation.
    /// </summary>
    public class PlaylistDAOImpl : IPlaylistDAO
    {
        /// <summary>
        /// Inserts a new playlist into the DB.
        /// </summary>
        /// <param name="playlist"></param>
        public void Insert(Playlist playlist)
        {
            if (playlist == null)
            {
                return;
            }
            try
            {
                using SqlConnection connection = DBHelper.MakeConnection();
                connection.Open();
                string sql = "INSERT INTO PLAYLISTS (NAME, URL, GENRE) VALUES (@name, @url, @genre)";
                using SqlCommand command = new(sql, connection);

                command.Parameters.AddWithValue("@name", playlist.Name);
                command.Parameters.AddWithValue("@url", playlist.Url);
                command.Parameters.AddWithValue("@genre", playlist.Genre);
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                throw;
            }
        }

        /// <summary>
        /// Updates an existing playlist.
        /// </summary>
        /// <param name="playlist"></param>
        public void Update(Playlist playlist)
        {
            if (playlist == null)
            {
                return;
            }

            try
            {
                using SqlConnection connection = DBHelper.MakeConnection();
                connection.Open();
                string sql = "UPDATE PLAYLISTS SET NAME=@name, URL=@url, GENRE=@genre WHERE ID=@id";

                using SqlCommand command = new(sql, connection);
                command.Parameters.AddWithValue("@name", playlist.Name);
                command.Parameters.AddWithValue("@url", playlist.Url);
                command.Parameters.AddWithValue("@genre", playlist.Genre);
                command.Parameters.AddWithValue("@id", playlist.Id);
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                throw;
            }
        }

        /// <summary>
        /// Deletes a Playlist.
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            try
            {
                using SqlConnection connection = DBHelper.MakeConnection();
                connection.Open();
                string sql = "DELETE FROM PLAYLISTS WHERE ID=@id";
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
        /// Returns a playlist by its id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>playlist</returns>
        public Playlist GetById(int id)
        {
            Playlist playlist = null;
            try
            {
                using SqlConnection connection = DBHelper.MakeConnection();
                connection.Open();
                string sql = "SELECT * FROM PLAYLISTS WHERE ID=@id";
                using SqlCommand command = new(sql, connection);
                command.Parameters.AddWithValue("@id", id);

                using SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    playlist = new()
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Url = reader.GetString(2),
                        Genre = reader.GetString(3)
                    };
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                throw;
            }

            return playlist;
        }

        /// <summary>
        /// Returns all playlists of the DB.
        /// </summary>
        /// <returns>playlists</returns>
        public List<Playlist> GetAll()
        {
            List<Playlist> playlists = new List<Playlist>();
            try
            {
                using SqlConnection connection = DBHelper.MakeConnection();
                connection.Open();
                string sql = "SELECT * FROM PLAYLISTS";
                using SqlCommand command = new(sql, connection);
                using SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Playlist playlist = new()
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Url = reader.GetString(2),
                        Genre = reader.GetString(3)
                    };

                    playlists.Add(playlist);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                throw;
            }
            return playlists;
        }        
    }
}
