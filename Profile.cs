using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using System.Xml;
using MySql.Data.MySqlClient;

namespace saloon
{
    public partial class Profile : Form
    {
        private MySqlConnection con;
        private string server, database, uid, password;
        private int userId;
        private string username;

        public Profile(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            server = "localhost";
            database = "saloon";
            uid = "root";
            password = "";

            string conString;
            conString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            con = new MySqlConnection(conString);

        }

        public string Username
        {
            get { return username; }
            private set { username = value; }
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            LoadUserData();
        }

        public void LoadUserData()
        {
            if (openConnection())
            {
                try
                {
                    string query = "SELECT * FROM userlog WHERE userId=@userId";
                    MySqlCommand cmd = new(query, con);
                    cmd.Parameters.AddWithValue("@userId", userId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Assuming "Name" and "Phone" are column names in your table
                            string name = reader["nama"].ToString();
                            string phoneNumber = reader["number"].ToString();
                            Username = reader["username"].ToString();
                            string address = reader["address"].ToString();

                            // Set the data in the form
                            NameLabel.Text = name;
                            NumberLabel.Text = "+" + phoneNumber;
                            UsernameLabel.Text = Username;
                            AddressLabel.Text = address;
                        }
                        else
                        {
                            MessageBox.Show("User data not found!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private bool openConnection()
        {
            try
            {
                con.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }

        private void EditProfileBtn_Click(object sender, EventArgs e)
        {
            EditProfile EP = new EditProfile(userId);
            EP.ShowDialog();
        }
    }
}
