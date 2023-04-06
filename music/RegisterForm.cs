using MahApps.Metro.Controls;
using music.DAOfolder;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Mysqlx.Datatypes.Scalar.Types;
using System.Security.Cryptography;
using MaterialSkin.Controls;

namespace music
{
    public partial class RegisterForm : Form
    {
        private object materialCheckBox1;
        string? checkBoxValue;
        string? password;






        public string GetGender()
        {
            string gender = "";
            if (materialCheckbox1.Checked)
            {
                gender = "man";
            }
            else
            {
                gender = "women";
            }
            return gender;
        }


        public void RegisterForm_Load()
        {

        }
        private void maskedTextBox1_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
           
        }
        public RegisterForm()
        {
            InitializeComponent();
            RegisterForm_Load();


        }


        public void materialButton2_Click(object sender, EventArgs e)

        {
            string connectionString = "datasource=localhost;port=3306;username=root;password=;database=music";

            MySqlConnection connection = new MySqlConnection(connectionString);

            string query = "INSERT INTO user (user_email, user_pw, user_bd, user_gender) VALUES (@user_email, @user_pw, @user_bd, @user_gender)";

            MySqlCommand command = new MySqlCommand(query, connection);
            string gender = GetGender();
            command.Parameters.AddWithValue("@user_email", materialTextBox21.Text);
            command.Parameters.AddWithValue("@user_pw", materialTextBox24.Text);
            command.Parameters.AddWithValue("@user_bd", maskedTextBox1.Text);
            command.Parameters.AddWithValue("@user_gender", gender);



            connection.Open();
            int result = command.ExecuteNonQuery();
            connection.Close();
        }

        private void materialLabel3_Load(object sender, EventArgs e)
        {
            materialLabel3.Width = 250;
            materialLabel3.Font = new Font("Arial", 12);
            materialLabel3.BackColor = Color.White;
        }



        private void materialTextBox21_Enter(object sender, EventArgs e)

        {
            materialTextBox21.Text = "";
        }

        private void materialTextBox22_Enter(object sender, EventArgs e)
        {
            materialTextBox22.Text = "";

        }

        private void materialTextBox23_Enter(object sender, EventArgs e)
        {
            materialTextBox23.Text = "";

        }

        private void materialTextBox24_Enter(object sender, EventArgs e)
        {
            materialTextBox24.Text = "";

        }


        private void materialTextBox21_Leave_1(object sender, EventArgs e)
        {
            string myString = materialTextBox21.Text;
            if (string.IsNullOrWhiteSpace(myString))
            {
                materialTextBox21.Text = "Your e-mail @";
            }
        }
        private void materialTextBox22_Leave(object sender, EventArgs e)
        {
            string myString = materialTextBox22.Text;
            if (string.IsNullOrEmpty(myString))
            {
                materialTextBox22.Text = "Repeat your email @";
            }
        }
        private void materialTextBox23_Leave(object sender, EventArgs e)
        {
            string myString = materialTextBox23.Text;
            if (string.IsNullOrEmpty(myString))
            {
                materialTextBox23.Text = "Your password";
            }
        }

        private void materialTextBox24_Leave(object sender, EventArgs e)
        {
            string myString = materialTextBox24.Text;
            if (string.IsNullOrEmpty(myString))
            {
                materialTextBox24.Text = "Repeat your password";
            }
        }



        private void materialTextBox21_Validating(object sender, CancelEventArgs e)
        {
            string email = materialTextBox21.Text;


            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");


            if (!regex.IsMatch(email))
            {
                materialLabel4.Visible = false;
            }
            else
            {
                materialLabel4.Visible = true;
            }
            string email2 = materialTextBox21.Text;
            string verifyMail = materialTextBox22.Text;

            if (email2 != verifyMail)
            {
                materialLabel5.Text = "Emails @ are not the same";
                materialLabel5.Visible = true;
            }
            else
            {
                materialLabel5.Visible = false;
            }
        }

        private void materialTextBox22_Validating(object sender, CancelEventArgs e)
        {

            string email = materialTextBox21.Text;
            string verifyMail = materialTextBox22.Text;

            if (email != verifyMail)
            {
                materialLabel5.Text = "Emails @ are not the same";
                materialLabel5.Visible = true;
            }
            else
            {
                materialLabel5.Visible = false;
            }
            string email2 = materialTextBox21.Text;
            string verifyMail2 = materialTextBox22.Text;
            if (email2 != verifyMail2)
            {
                materialLabel4.Text = "Emails @ are not the same";
                materialLabel4.Visible = true;
            }
            else
            {
                materialLabel4.Visible = false;
            }


        }
        private void materialTextBox23_Validating_1(object sender, CancelEventArgs e)
        {
            string password = materialTextBox23.Text;
            Regex regex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$");

            if (!regex.IsMatch(password))
            {
                materialLabel6.Text = "Entrez un e-mail @ valide";
                materialLabel6.Visible = false;
            }
            else
            {
                materialLabel6.Visible = true;

            }
        }
        private void materialTextBox24_Validating(object sender, CancelEventArgs e)
        {
            string? verifyString = materialTextBox23.Text;
            string? myString = materialTextBox24.Text;

            if (string.IsNullOrWhiteSpace(verifyString))
            {
                if (verifyString != myString)
                {
                    materialLabel7.Text = "Not the same password";
                    materialLabel7.Visible = true;
                }
                else
                {
                    materialLabel7.Visible = false;

                }
            }

        }


    }
}
