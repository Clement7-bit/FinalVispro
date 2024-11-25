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
    public partial class Form1 : Form
    {
        private MySqlConnection con;
        private string server, database, uid, password;

        public Form1()
        {
            InitializeComponent();
            server = "localhost";
            database = "saloon";
            uid = "root";
            password = "";

            string conString;
            conString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            con = new MySqlConnection(conString);
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordTextBox.Text;

            int userId = AuthenticateUser(username, password);

            if (userId != -1)
            {
                this.Hide();
                Home h1 = new Home(userId);
                h1.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Login Failed!");
            }
        }

        private int AuthenticateUser(string username, string password)
        {
            if (openConnection())
            {
                try
                {
                    string query = "SELECT UserId FROM userlog WHERE username=@username AND password=@password";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        // Authentication successful, return the UserId
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        // Authentication failed
                        return -1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return -1;
                }
                finally
                {
                    con.Close();
                }
            }
            return -1;
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
