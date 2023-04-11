﻿using music.classFolder;
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
        string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=music";

        public List<Title> getAllTitles()
        {
            List<Title> returnAllTitles = new List<Title>();

            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();

            MySqlCommand command = new MySqlCommand("SELECT * FROM concert", connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Title A = new Title()
                    {
                        concert_ID = reader.GetInt16(0),
                        concert_name = reader.GetString(1),
                        concert_hour = reader.GetString(2),
                        concert_artist = reader.GetString(3),
                        concert_date = reader.GetString(4),

                    };
                    returnAllTitles.Add(A);

                }

            }
            connection.Close();
            return returnAllTitles;

        }
    }
}
