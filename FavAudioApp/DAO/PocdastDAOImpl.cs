using FavAudioApp.DAO.DBUtil;
using FavAudioApp.Model;
using System.Data.SqlClient;

namespace FavAudioApp.DAO
{
    /// <summary>
    /// Podcast implementation.
    /// </summary>
    public class PocdastDAOImpl : IPodcastDAO
    {
        /// <summary>
        /// Inserts a new podcast to the DB.
        /// </summary>
        /// <param name="podcast"></param>
        public void Insert(Podcast podcast)
        {
            if (podcast == null)
            {
                return;
            }
            try
            {
                using SqlConnection connection = DBHelper.MakeConnection();
                connection.Open();
                string sql = "INSERT INTO PODCASTS (NAME, URL) VALUES (@name, @url)";
                using SqlCommand command = new(sql, connection);

                command.Parameters.AddWithValue("@name", podcast.Name);
                command.Parameters.AddWithValue("@url", podcast.Url);
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                throw;
            }
        }

        /// <summary>
        /// Updates an existing podcast.
        /// </summary>
        /// <param name="podcast"></param>
        public void Update(Podcast podcast)
        {
            if (podcast == null)
            {
                return;
            }

            try
            {
                using SqlConnection connection = DBHelper.MakeConnection();
                connection.Open();
                string sql = "UPDATE PODCASTS SET NAME=@name, URL=@url WHERE ID=@id";

                using SqlCommand command = new(sql, connection);
                command.Parameters.AddWithValue("@id", podcast.Id);
                command.Parameters.AddWithValue("@name", podcast.Name);
                command.Parameters.AddWithValue("@url", podcast.Url);
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                throw;
            }
        }

        /// <summary>
        /// Deletes a podcast from the DB.
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            try
            {
                using SqlConnection connection = DBHelper.MakeConnection();
                connection.Open();
                string sql = "DELETE FROM PODCASTS WHERE ID=@id";
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
        /// Returns a podcast by its id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>podcast</returns>
        public Podcast GetById(int id)
        {
            Podcast podcast = null;
            try
            {
                using SqlConnection connection = DBHelper.MakeConnection();
                connection.Open();
                string sql = "SELECT * FROM PODCASTS WHERE ID=@id";
                using SqlCommand command = new(sql, connection);
                command.Parameters.AddWithValue("@id", id);

                using SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    podcast = new()
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Url = reader.GetString(2)
                    };
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                throw;
            }

            return podcast;
        }

        /// <summary>
        /// Returns all podcasts of th DB.
        /// </summary>
        /// <returns>podcasts</returns>
        public List<Podcast> GetAll()
        {
            List<Podcast> podcasts = new List<Podcast>();
            try
            {
                using SqlConnection connection = DBHelper.MakeConnection();
                connection.Open();
                string sql = "SELECT * FROM PODCASTS";
                using SqlCommand command = new(sql, connection);
                using SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Podcast podcast = new()
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Url = reader.GetString(2)
                    };

                    podcasts.Add(podcast);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                throw;
            }
            return podcasts;
        }        
    }
}
