using MaterialSkin.Controls;
using music.DAOfolder;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Security.Cryptography;
using System.Windows.Forms;
using static music.Form2;

namespace music
{
    public partial class Form1 : Form
    {
        BindingSource titlesBindingSource = new BindingSource();



        public Form1()
        {
            InitializeComponent();




            TitlesDAO titlesDAO = new TitlesDAO();
            titlesBindingSource.DataSource = titlesDAO.getAllTitles();
            dataGridView1.DataSource = titlesBindingSource;



            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.HeaderText = "";
            deleteButtonColumn.Text = "Delete";
            deleteButtonColumn.UseColumnTextForButtonValue = true;



            Debug.WriteLine($"isLoggedIn value: {GlobalVariables.isLoggedIn}");
            checkToken();
        }


        
          


        
        public void checkToken()
        {


            if (GlobalVariables.isLoggedIn == true)
            {
                UpdateLabel();
                showUsefullButtons();

            }
            else
            {

                hideUselessButtons();

            }
        }

        public void hideUselessButtons()
        {

            Controls.Remove(RefreshConcertListButton);
            Controls.Remove(AddConcertButton);
            Controls.Remove(materialButton3);
            Controls.Remove(dataGridView1);

        }
        public void showUsefullButtons()
        {
            Controls.Add(RefreshConcertListButton);
            Controls.Add(AddConcertButton);
            Controls.Add(materialButton3);
            Controls.Add(dataGridView1);


        }
        public void UpdateLabel()
        {
            dataGridView1.Visible = true;
            materialButton1.Visible = false;
            materialButton2.Visible = false;
            label1.Visible = true;
            materialLabel3.Visible = false;
            RefreshConcertListButton.Visible = true;
            AddConcertButton.Visible = true;
            materialButton3.Visible = true;

        }

        private void materialButton1_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.TopMost = true;
            form2.StartPosition = FormStartPosition.CenterParent;
            
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
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





        private void AddConcertButton_Click(object sender, EventArgs e)
        {
            addNewConcert addconcert = new addNewConcert(this);
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

        private void materialButton3_Click(object sender, EventArgs e)
        {
           
            ArtisteData artistedata = new ArtisteData(this);
            artistedata.TopMost = true;
            artistedata.StartPosition = FormStartPosition.CenterParent;
            artistedata.Show();
        }

        public void refreshConcertList()
        {
            dataGridView1.Refresh();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {

           
            Form2 loginform = new Form2(this);
            loginform.TopMost = true;
            loginform.StartPosition = FormStartPosition.CenterParent;
            loginform.ShowDialog();

        }


    }
}