using MaterialSkin.Controls;
using music.DAOfolder;
using MySql.Data.MySqlClient;

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
            DeleteConcertButton.Visible = true;
            dataGridView2.Visible = true;
            materialLabel4.Visible = false;
            materialButton3.Visible = true;
            materialButton5.Visible = true;
            materialButton4.Visible = true;

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


        private void materialButton3_Click(object sender, EventArgs e)
        {
            ArtistsDAO titlesDAO = new ArtistsDAO();
            artistBindingSource.DataSource = titlesDAO.getAllArtists();
            dataGridView2.DataSource = artistBindingSource;
            dataGridView2.Refresh();
        }

        private void materialButton5_Click(object sender, EventArgs e)
        {
            AddNewArtist.cs addartist = new addNewArtist();
        }
    }
}