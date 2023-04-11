using music.classFolder;
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
    public partial class addNewConcert : Form
    {
        public addNewConcert()
        {
            InitializeComponent();
            PopulateComboBox();
        }
        private void PopulateComboBox()
        {
            string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=music";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT artist_name FROM artist";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            choseArtistName.Items.Add(reader.GetString("artist_name"));
                        }
                    }
                }
            }
        }
        Form1 mainForm = new Form1();
        private void AddConcertToDB()
        {
            string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=music";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                
                string query = "INSERT INTO concert (concert_name, concert_hour, concert_artist, concert_date) VALUES (@name, @hour, @artist, @date)";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    
                    string selectedValue = choseArtistName.SelectedItem.ToString();

                    
                    command.Parameters.AddWithValue("@name", addConcertNameBox.Text); ;
                    command.Parameters.AddWithValue("@hour", materialMaskedTextBox1.Text);
                    command.Parameters.AddWithValue("@artist", selectedValue);
                    command.Parameters.AddWithValue("@date", materialMaskedTextBox2.Text);

                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        materialLabel6.Visible = true;
                        mainForm.RefreshDataGridView();

                    }
                    else
                    {
                        materialLabel5.Visible = true;
                    }
                }

                connection.Close();
                this.Close();
            }
        }

        private void AddArtistInDB_Click(object sender, EventArgs e)
        {
            AddConcertToDB();
        }
    }
}
