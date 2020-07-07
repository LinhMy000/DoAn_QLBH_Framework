using MySql.Data.MySqlClient;

namespace Admin1.Models
{
    public class Connection
    {
        public static MySqlConnection GetConnection()
        {
            string str = "server=127.0.0.1; user id=root; password=; port=3306; database=banquanao;";
            return new MySqlConnection(str);
        }
    }
}
