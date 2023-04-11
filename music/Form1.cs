using MaterialSkin.Controls;
using music.DAOfolder;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace music
{
    public partial class Form1 : Form
    {
        BindingSource titlesBindingSource = new BindingSource();
        BindingSource artistBindingSource = new BindingSource();

        public Form1()
        {
            InitializeComponent();
            TitlesDAO titlesDAO = new TitlesDAO();
            titlesBindingSource.DataSource = titlesDAO.getAllTitles();
            dataGridView1.DataSource = titlesBindingSource;

            ArtistsDAO artistsDAO = new ArtistsDAO();
            artistBindingSource.DataSource = artistsDAO.getAllArtists();
            dataGridView2.DataSource = artistBindingSource;

            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.HeaderText = "";
            deleteButtonColumn.Text = "Delete";
            deleteButtonColumn.UseColumnTextForButtonValue = true;

            hideUselessButtons();
        }
        public void hideUselessButtons()
        {

            RefreshConcertListButton.Width = 0;
            RefreshConcertListButton.Height = 0;
            AddConcertButton.Width = 0;
            AddConcertButton.Height = 0;
            materialButton3.Height = 0;
            materialButton3.Width = 0;
            materialButton5.Width = 0;
            materialButton5.Height = 0;

        }
        public void showUsefullButtons()
        {

            RefreshConcertListButton.Width = 84;
            RefreshConcertListButton.Height = 36;
            AddConcertButton.Width = 179;
            AddConcertButton.Height = 36;
            materialButton3.Height = 84;
            materialButton3.Width = 36;
            materialButton5.Width = 153;
            materialButton5.Height = 36;

        }
        public void UpdateLabel(string username)
        {
            dataGridView1.Visible = true;
            materialButton1.Visible = false;
            materialButton2.Visible = false;
            label1.Visible = true;
            materialLabel3.Visible = false;
            RefreshConcertListButton.Visible = true;
            AddConcertButton.Visible = true;
            dataGridView2.Visible = true;
            materialLabel4.Visible = false;
            materialButton3.Visible = true;
            materialButton5.Visible = true;


        }

        private void materialButton1_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();
            form2.FormBorderStyle = FormBorderStyle.None;
            form2.TopMost = true;
            form2.StartPosition = FormStartPosition.CenterParent;
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.FormBorderStyle = FormBorderStyle.None;
            registerForm.TopMost = true;
            registerForm.StartPosition = FormStartPosition.CenterParent;
            registerForm.ShowDialog();
        }



        private void RefreshConcertListButton_Click(object sender, EventArgs e)
        {
            TitlesDAO titlesDAO = new TitlesDAO();
            titlesBindingSource.DataSource = titlesDAO.getAllTitles();
            dataGridView1.DataSource = titlesBindingSource;
            dataGridView1.Refresh();
        }


        public void materialButton3_Click(object sender, EventArgs e)
        {
            ArtistsDAO titlesDAO = new ArtistsDAO();
            artistBindingSource.DataSource = titlesDAO.getAllArtists();
            dataGridView2.DataSource = artistBindingSource;
            dataGridView2.Refresh();
        }

        private void materialButton5_Click(object sender, EventArgs e)
        {
            addNewArtist addartist = new addNewArtist();
            addartist.FormBorderStyle = FormBorderStyle.None;
            addartist.TopMost = true;
            addartist.StartPosition = FormStartPosition.CenterParent;
            addartist.ShowDialog();
        }

        private void AddConcertButton_Click(object sender, EventArgs e)
        {
            addNewConcert addconcert = new addNewConcert();
            addconcert.FormBorderStyle = FormBorderStyle.None;
            addconcert.TopMost = true;
            addconcert.StartPosition = FormStartPosition.CenterParent;
            addconcert.ShowDialog();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {


            if (e.ColumnIndex == dataGridView1.Columns["deleteConcert"].Index && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this row?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {


                    string concertName = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["concert_name"].Value);
                    string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=music";
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        string query = "DELETE FROM concert WHERE concert_name = @concert_name";
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@concert_name", concertName);
                            connection.Open();
                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {

                                dataGridView1.Rows.RemoveAt(e.RowIndex);
                                dataGridView1.Refresh();
                            }
                            else
                            {
                            }
                        }

                    }
                }
            }
        }
        public void RefreshDataGridView()
        {

            dataGridView1.Refresh();
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == dataGridView2.Columns["deleteArtist"].Index && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this row?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {


                    string artistName = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells["artist_name"].Value);
                    string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=music";
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        string query = "DELETE FROM artist WHERE artist_name = @artist_name";
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@artist_name", artistName);
                            connection.Open();
                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                dataGridView2.Rows.RemoveAt(e.RowIndex);
                                dataGridView2.Refresh();
                            }
                            else
                            {
                            }
                        }

                    }
                }

            }
        }
    }
}