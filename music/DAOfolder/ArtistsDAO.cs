using music.classFolder;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace music.DAOfolder
{
    internal class ArtistsDAO
    {
        string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=music";

        public List<Artist> getAllArtists()
        {
            List<Artist> returnAllArtists = new List<Artist>();

            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();

            MySqlCommand command = new MySqlCommand("SELECT * FROM artist", connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Artist A = new Artist()
                    {

                        artist_name = reader.GetString(1),
                        artist_info = reader.GetString(2),

                    };
                    returnAllArtists.Add(A);

                }

            }
            connection.Close();
            return returnAllArtists;

        }
    }
}
