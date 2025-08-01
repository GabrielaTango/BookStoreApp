using MySql.Data.MySqlClient;

namespace DAL
{
    public class Connection
    {
        private readonly string connString = "server=179.43.121.202;database=BookstoreApp;user=chami;password=Lolo4865!;";

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connString);
        }

    }
}
