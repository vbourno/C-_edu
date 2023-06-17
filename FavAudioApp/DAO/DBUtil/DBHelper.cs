using System.Data.SqlClient;

namespace FavAudioApp.DAO.DBUtil
{
    public class DBHelper
    {
        private static SqlConnection connection;

        /// <summary>
        /// No instances of this class should be available.
        /// </summary>
        private DBHelper() { }

        /// <summary>
        /// Connection to the DB.
        /// </summary>
        /// <returns>connection</returns>
        public static SqlConnection MakeConnection()
        {
            connection = null;
            try
            {
                ConfigurationManager configurationManager = new ConfigurationManager();
                configurationManager.AddJsonFile("appsettings.json");

                string url = configurationManager.GetConnectionString("DefaultConnection");
                connection = new SqlConnection(url);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            return connection;
        }

        /// <summary>
        /// Closes the connection to the DB.
        /// </summary>
        public static void CloseConnection()
        {
            connection.Close();
        }
    }
}
