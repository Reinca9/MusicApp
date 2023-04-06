using music.DAOfolder;

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
        }


        private void materialButton1_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.FormBorderStyle = FormBorderStyle.None;
            form2.TopMost = true;
            form2.StartPosition = FormStartPosition.CenterParent;
            form2.ShowDialog();

        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.FormBorderStyle = FormBorderStyle.None;
            registerForm.TopMost = true;
            registerForm.StartPosition = FormStartPosition.CenterParent;
            registerForm.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}