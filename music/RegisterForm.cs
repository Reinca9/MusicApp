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
using BCrypt.Net;

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
            string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=music";

            MySqlConnection connection = new MySqlConnection(connectionString);

            string query = "INSERT INTO user (user_email, user_pw, user_bd, user_gender) VALUES (@user_email, @user_pw, @user_bd, @user_gender)";

            MySqlCommand command = new MySqlCommand(query, connection);
            string gender = GetGender();
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(materialTextBox24.Text); // Hash the password

            command.Parameters.AddWithValue("@user_email", materialTextBox21.Text);
            command.Parameters.AddWithValue("@user_pw", hashedPassword); // Use the hashed password
            command.Parameters.AddWithValue("@user_bd", maskedTextBox1.Text);
            command.Parameters.AddWithValue("@user_gender", gender);

            connection.Open();
            int result = command.ExecuteNonQuery();
            connection.Close();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Close();
        }

        private void materialLabel3_Load(object sender, EventArgs e)
        {
            materialLabel3.Width = 250;
            materialLabel3.Font = new Font("Arial", 12);
            materialLabel3.BackColor = Color.White;
        }

        private bool _userHasEnteredTextInMaterialTextBox21 = false;

        private void materialTextBox21_Enter(object sender, EventArgs e)
        {

            if (!_userHasEnteredTextInMaterialTextBox21)
            {
                materialTextBox21.Text = "";
            }
        }
        private bool _userHasEnteredTextInMaterialTextBox22 = false;
        private void materialTextBox22_Enter(object sender, EventArgs e)
        {
            if (!_userHasEnteredTextInMaterialTextBox22)
            {
                materialTextBox22.Text = "";
            }
        }
        private bool _userHasEnteredTextInMaterialTextBox23 = false;
        private void materialTextBox23_Enter(object sender, EventArgs e)
        {
            if (!_userHasEnteredTextInMaterialTextBox23)
            {
                materialTextBox23.Text = "";
            }
        }
        private bool _userHasEnteredTextInMaterialTextBox24 = false;
        private void materialTextBox24_Enter(object sender, EventArgs e)
        {
            if (!_userHasEnteredTextInMaterialTextBox24)
            {
                materialTextBox24.Text = "";
            }
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
            else
            {
                
                materialLabel6.Visible = true;
                if (myString.Length < 8)
                {
                    materialLabel6.Text = "must be at least 8 characters";
                    materialButton2.Enabled = false;
                }
                else if (!Regex.IsMatch(myString, @"[A-Z]"))
                {
                    materialLabel6.Text = "at least one uppercase";
                    materialButton2.Enabled = false;
                }
                else if (!Regex.IsMatch(myString, @"[a-z]"))
                {
                    materialButton2.Enabled = false;
                    materialLabel6.Text = "at least one lowercase";
                }
                else if (!Regex.IsMatch(myString, @"\d"))
                {
                    materialButton2.Enabled = false;
                    materialLabel6.Text = "au moins un chiffre";
                }
                else
                {

                    materialLabel6.Visible = false;
                }
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



        private void materialTextBox21_TextChanged(object sender, EventArgs e)
        {
            UpdateButtonStatus();
            _userHasEnteredTextInMaterialTextBox21 = true;
            string emailPattern = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";
            Regex regex = new Regex(emailPattern);
            bool isValid = regex.IsMatch(materialTextBox21.Text);

            materialLabel4.Visible = !isValid;

            if (!isValid)
            {
                materialButton2.Enabled = false;
                materialLabel4.Text = "Invalid email";
                materialLabel4.ForeColor = Color.Red;
                materialButton2.Enabled = false;
            }
            else
            {
            }
        }

        private void materialTextBox22_TextChanged(object sender, EventArgs e)

        {
            UpdateButtonStatus();
            _userHasEnteredTextInMaterialTextBox22 = true;
        }

        private void materialTextBox23_TextChanged(object sender, EventArgs e)
        {
            UpdateButtonStatus();
            _userHasEnteredTextInMaterialTextBox23 = true;
        }

        private void materialTextBox24_TextChanged(object sender, EventArgs e)
        {
            UpdateButtonStatus();
            _userHasEnteredTextInMaterialTextBox24 = true;
        }
        private void UpdateButtonStatus()
        {
            bool allInputsFilled = !string.IsNullOrEmpty(materialTextBox21.Text) &&
                                   !string.IsNullOrEmpty(materialTextBox22.Text) &&
                                   !string.IsNullOrEmpty(materialTextBox23.Text) &&
                                   !string.IsNullOrEmpty(materialTextBox24.Text) &&
                                   !string.IsNullOrEmpty(maskedTextBox1.Text) &&
                                   (materialCheckbox1.Checked || materialCheckbox2.Checked);

            materialButton2.Enabled = allInputsFilled;
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            UpdateButtonStatus();
        }

        private void materialCheckbox1_CheckedChanged(object sender, EventArgs e)
        {

            UpdateButtonStatus();
        }

        private void materialCheckbox2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateButtonStatus();
        }
    }

}
