using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace music
{
    public partial class addNewArtist : Form
    {
        public addNewArtist()
        {
            InitializeComponent();
        }

        private void AddArtistInDB_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=music";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO artist (artist_name, artist_info) VALUES (@name, @info)";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", AddArtistNameBox.Text);
                    command.Parameters.AddWithValue("@info", AddArtistInfoBox.Text);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        materialLabel3.Visible = true;
                    }
                    else
                    {
                        materialLabel4.Visible = false;
                    }
                }
            }
        }
    }
}
