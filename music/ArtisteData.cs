﻿using MaterialSkin.Controls;
using music.DAOfolder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace music
{
    public partial class ArtisteData : Form
    {
        BindingSource artistBindingSource = new BindingSource();
        public ArtisteData()
        {
            InitializeComponent();

        }



        public void showUsefullButtons2()
        {
            Controls.Add(materialButton3);
            Controls.Add(materialButton5);
        }
        public void hideUselessButtons2()
        {


            Controls.Remove(materialButton3);
            Controls.Remove(materialButton5);

        }
        public void UpdateLabel2(string username)
        {

            dataGridView2.Visible = true;
            materialLabel4.Visible = false;
            materialButton3.Visible = true;
            materialButton5.Visible = true;


        }


        private void materialButton3_Click(object sender, EventArgs e)
        {
            ArtistsDAO titlesDAO = new ArtistsDAO();
            artistBindingSource.DataSource = titlesDAO.getAllArtists();
            dataGridView2.DataSource = artistBindingSource;
            dataGridView2.Refresh();
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

        private void materialButton5_Click(object sender, EventArgs e)
        {
            addNewArtist addartist = new addNewArtist();
            addartist.FormBorderStyle = FormBorderStyle.None;
            addartist.TopMost = true;
            addartist.StartPosition = FormStartPosition.CenterParent;
            addartist.ShowDialog();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            Form1 mainForm = new Form1();
            mainForm.FormBorderStyle = FormBorderStyle.None;
            mainForm.TopMost = true;
            mainForm.StartPosition = FormStartPosition.CenterParent;
            mainForm.Show();
            this.Close();

        }
    }
}
