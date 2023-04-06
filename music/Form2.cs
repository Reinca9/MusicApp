using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace music
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void materialButton3_Click(object sender, EventArgs e)
        {


            RegisterForm registerForm = new RegisterForm();

            // Set Form2 properties
            registerForm.FormBorderStyle = FormBorderStyle.None;
            registerForm.TopMost = true;
            registerForm.StartPosition = FormStartPosition.CenterParent;

            // Show Form2 as a dialog box
            registerForm.ShowDialog();


        }

        private void materialTextBox21_Enter(object sender, EventArgs e)
        {
            materialTextBox21.Text = "";
        }

        private void materialTextBox22_Enter(object sender, EventArgs e)
        {
            materialTextBox22.Text = "";
        }

        private void materialTextBox21_Leave(object sender, EventArgs e)
        {
            string myString = materialTextBox21.Text;
            if (string.IsNullOrEmpty(myString))
            {
                materialTextBox21.Text = "Your e-mail @";
            }
        }

        private void materialTextBox22_Leave(object sender, EventArgs e)
        {
            string myString = materialTextBox22.Text;
            if (string.IsNullOrEmpty(myString))
            {
                materialTextBox22.Text = "Your password";
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=music";
            SqlConnection connection = new SqlConnection(connectionString);

            string username = materialTextBox21.Text;
            string password = materialTextBox22.Text;
            string query = "SELECT COUNT(*) FROM users WHERE user_email='" + username + "' AND user_pw='" + password + "'";
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            int count = (int)command.ExecuteScalar();
            connection.Close();


            if (count > 0)
            {

                this.Hide();
            }
            else
            {
                ConnectionFail.Visible = true;
            }
           
        }
    }
}
