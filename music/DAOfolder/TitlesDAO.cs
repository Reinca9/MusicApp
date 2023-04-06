using music.classFolder;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace music.DAOfolder
{
    internal class TitlesDAO
    {
        string connectionString = "datasource=localhost;port=3306;username=root;password=;database=music";

        public List<Title> getAllTitles()
        {
            List<Title> returnAllTitles = new List<Title>();

            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();

            MySqlCommand command = new MySqlCommand("SELECT * FROM music_titles", connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Title A = new Title()
                    {

                        title_name = reader.GetString(1),
                        title_author = reader.GetString(2),
                        title_img = reader.GetString(3),

                    };
                    returnAllTitles.Add(A);

                }

            }
            connection.Close();
            return returnAllTitles;

        }
    }
}
