﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace music
{
    public partial class Form2 : Form
    {
        Form1 mainform = new Form1();

        public Form2(Form1 form1)
        {
            InitializeComponent();
            mainform = form1;
        }

        public static class GlobalVariables
        {
            public static bool isLoggedIn = false;
        }
        private Form1 _form1;

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








        private void materialButton1_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=music";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string username = materialTextBox21.Text;
                string password = materialTextBox22.Text;

                string query = "SELECT user_pw FROM user WHERE user_email=@username";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                object result = command.ExecuteScalar();

                if (result != null && BCrypt.Net.BCrypt.Verify(password, result.ToString()))
                {
                    // Login successful
                    GlobalVariables.isLoggedIn = true;
                    Debug.WriteLine($"isLoggedIn value: {GlobalVariables.isLoggedIn}");
                    mainform.checkToken();
                    this.DialogResult = DialogResult.OK;
                    mainform.Show();
                }
                else
                {
                    // Login failed
                    ConnectionFail.Visible = true;
                }

                connection.Close();
            }
        }


        private void materialButton2_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
           
            Debug.WriteLine("closed");

        }
    }


}

