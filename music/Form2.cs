using MySql.Data.MySqlClient;
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
        private Form1 mainForm = new Form1();
        private ArtisteData artisteForm = new ArtisteData();

        public Form2()
        {
            InitializeComponent();


        }




        



        private void materialButton3_Click(object sender, EventArgs e)
        {


            RegisterForm registerForm = new RegisterForm();
            registerForm.FormBorderStyle = FormBorderStyle.None;
            registerForm.TopMost = true;
            registerForm.StartPosition = FormStartPosition.CenterParent;
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



        public string loginToken = "";

        public string materialButton1_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=music";
            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();

            string username = materialTextBox21.Text;
            string password = materialTextBox22.Text;

            

            string query = "SELECT user_pw FROM user WHERE user_email='" + username + "'";
            MySqlCommand command = new MySqlCommand(query, connection);
            object result = command.ExecuteScalar();

            if (result != null)
            {
                string storedHash = result.ToString();
                if (BCrypt.Net.BCrypt.Verify(password, storedHash))
                {
                    mainForm.showUsefullButtons();
                    artisteForm.showUsefullButtons2();

                    mainForm.Show();
                    this.Close();
                }
                else
                {
                    return loginToken = "";
                    ConnectionFail.Visible = true;
                }
            }

            connection.Close();
            loginToken = GenerateToken();
            return loginToken;
        }
        private string GenerateToken()
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
            char[] tokenChars = new char[16];
            for (int i = 0; i < tokenChars.Length; i++)
            {
                tokenChars[i] = chars[random.Next(chars.Length)];
            }
            return new string(tokenChars);
        }
        private void materialButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
