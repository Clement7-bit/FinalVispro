using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace saloon
{
    public partial class EditProfile : Form
    {
        private MySqlConnection con;
        private string server, database, uid, password;
        private int userId;

        public EditProfile(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            server = "localhost";
            database = "saloon";
            uid = "root";
            password = "";

            string conString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};";
            con = new MySqlConnection(conString);
        }

        private void EditProfile_Load(object sender, EventArgs e)
        {
            LoadUserData();
        }

        private bool OpenConnection()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }

        private void CloseConnection()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        private void LoadUserData()
        {
            if (OpenConnection())
            {
                string query = "SELECT username, password, nama, address, number FROM userlog WHERE userId = @userId";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@userId", userId);

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    InputName.Text = reader["nama"].ToString();
                    InputPassword.Text = reader["password"].ToString();
                    InputAddress.Text = reader["address"].ToString();
                    InputNumber.Text = reader["number"].ToString();
                }
                reader.Close();
                CloseConnection();
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (OpenConnection())
            {
                // Initialize the base query
                string query = "UPDATE userlog SET ";
                List<string> updateClauses = new List<string>();
                MySqlCommand cmd = new MySqlCommand();

                // Only add non-empty fields to the update statement
                if (!string.IsNullOrEmpty(InputName.Text))
                {
                    updateClauses.Add("nama = @nama");
                    cmd.Parameters.AddWithValue("@nama", InputName.Text);
                }
                if (!string.IsNullOrEmpty(InputPassword.Text))
                {
                    updateClauses.Add("password = @password");
                    cmd.Parameters.AddWithValue("@password", InputPassword.Text);
                }
                if (!string.IsNullOrEmpty(InputAddress.Text))
                {
                    updateClauses.Add("address = @address");
                    cmd.Parameters.AddWithValue("@address", InputAddress.Text);
                }
                if (!string.IsNullOrEmpty(InputNumber.Text))
                {
                    updateClauses.Add("number = @number");
                    cmd.Parameters.AddWithValue("@number", InputNumber.Text);
                }

                // If there are fields to update, complete and execute the query
                if (updateClauses.Count > 0)
                {
                    query += string.Join(", ", updateClauses) + " WHERE userId = @userId";
                    cmd.CommandText = query;
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@userId", userId);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Profile updated successfully!");
                        this.Close();
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Error updating profile: " + ex.Message);
                    }
                    finally
                    {
                        CloseConnection();
                    }
                }
                else
                {
                    MessageBox.Show("No changes to update.");
                }
            }
        }


        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the form without saving
        }
    }
}
