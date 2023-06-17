using FavAudioApp.DAO.DBUtil;
using FavAudioApp.Model;
using System.Data.SqlClient;

namespace FavAudioApp.DAO
{
    /// <summary>
    /// Radio implementation.
    /// </summary>
    public class RadioDAOImpl : IRadioDAO
    {
        /// <summary>
        /// Inserts a new radio into the DB.
        /// </summary>
        /// <param name="radio"></param>
        public void Insert(Radio radio)
        {
            if (radio == null)
            {
                return;
            }
            try
            {
                using SqlConnection connection = DBHelper.MakeConnection();
                connection.Open();
                string sql = "INSERT INTO RADIO (NAME, URL, GENRE, REGION) VALUES (@name, @url, @genre, @region)";
                using SqlCommand command = new(sql, connection);

                command.Parameters.AddWithValue("@name", radio.Name);
                command.Parameters.AddWithValue("@url", radio.Url);
                command.Parameters.AddWithValue("@genre", radio.Genre);
                command.Parameters.AddWithValue("@region", radio.Region);
                command.ExecuteNonQuery();
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.StackTrace);
                throw;
            }
        }

        /// <summary>
        /// Updates an existing radio.
        /// </summary>
        /// <param name="radio"></param>
        public void Update(Radio radio)
        {
            if (radio == null)
            {
                return;
            }

            try
            {
                using SqlConnection connection = DBHelper.MakeConnection();
                connection.Open();
                string sql = "UPDATE RADIO SET NAME=@name, URL=@url, GENRE=@genre, REGION=@region WHERE ID=@id";

                using SqlCommand command = new(sql, connection);
                command.Parameters.AddWithValue("@name", radio.Name);
                command.Parameters.AddWithValue("@url", radio.Url);
                command.Parameters.AddWithValue("@genre", radio.Genre);
                command.Parameters.AddWithValue("@region", radio.Region);
                command.Parameters.AddWithValue("@id", radio.Id);
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                throw;
            }
        }

        /// <summary>
        /// Deletes a radio from the DB.
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            try
            {
                using SqlConnection connection = DBHelper.MakeConnection();
                connection.Open();
                string sql = "DELETE FROM RADIO WHERE ID=@id";
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
        /// Returns a radio by its id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>radio</returns>
        public Radio GetById(int id)
        {
            Radio radio = null;
            try
            {
                using SqlConnection connection = DBHelper.MakeConnection();
                connection.Open();
                string sql = "SELECT * FROM RADIO WHERE ID=@id";
                using SqlCommand command = new(sql, connection);
                command.Parameters.AddWithValue("@id", id);

                using SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    radio = new()
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Url = reader.GetString(2),
                        Genre = reader.GetString(3),
                        Region = reader.GetString(4)
                    };
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                throw;
            }

            return radio;
        }

        /// <summary>
        /// Returns all radios of the DB.
        /// </summary>
        /// <returns>radios</returns>
        public List<Radio> GetAll()
        {
            List<Radio> radios = new List<Radio>();
            try
            {
                using SqlConnection connection = DBHelper.MakeConnection();
                connection.Open();
                string sql = "SELECT * FROM RADIO";
                using SqlCommand command = new(sql, connection);
                using SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Radio radio = new()
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Url = reader.GetString(2),
                        Genre = reader.GetString(3),
                        Region = reader.GetString(4)
                    };

                    radios.Add(radio);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                throw;
            }
            return radios;
        }    
    }
}
