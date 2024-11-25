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
    public partial class Home : Form
    {
        private Button activeButton;
        private MySqlConnection con;
        private string server, database, uid, password;
        private int userId;

        public Home(int userId)
        {
            InitializeComponent();
            server = "localhost";
            database = "saloon";
            uid = "root";
            password = "";

            string conString;
            conString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            con = new MySqlConnection(conString);
            this.userId = userId;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            SetActiveButton(ProfileBtn);
            Profile PB = new Profile(userId);
            PB.TopLevel = false;
            panel2.Controls.Clear();
            panel2.Controls.Add(PB);
            PB.Show();
        }

        private void SetActiveButton(Button button)
        {
            if (activeButton != null)
            {
                activeButton.BackColor = SystemColors.Desktop;
                activeButton.ForeColor = SystemColors.ControlDark;
            }

            activeButton = button;
            activeButton.BackColor = Color.DarkOrange;
            activeButton.ForeColor = Color.White;

        }

        private void ProfileBtn_Click(object sender, EventArgs e)
        {
            SetActiveButton(ProfileBtn);

            Profile PB = new Profile(userId);
            PB.TopLevel = false;
            panel2.Controls.Clear();
            panel2.Controls.Add(PB);
            PB.Show();
        }

        private void ProductBtn_Click(object sender, EventArgs e)
        {
            SetActiveButton(ProductBtn);

            Product ProductPanel = new Product(userId);
            ProductPanel.TopLevel = false;
            panel2.Controls.Clear();
            panel2.Controls.Add(ProductPanel);
            ProductPanel.Show();
        }

        private void OrderHistoryBtn_Click(object sender, EventArgs e)
        {
            SetActiveButton(OrderHistoryBtn);

            OrderHistory OrderHistoryPannel = new OrderHistory(userId);
            OrderHistoryPannel.TopLevel = false;
            panel2.Controls.Clear();
            panel2.Controls.Add(OrderHistoryPannel);
            OrderHistoryPannel.Show();
        }

        private void BookingServiceBtn_Click(object sender, EventArgs e)
        {
            SetActiveButton(BookingServiceBtn);

            Profile profile = new Profile(userId);
            profile.LoadUserData();

            BookingServices bookingServicesPanel = new BookingServices(userId, profile.Username);
            bookingServicesPanel.TopLevel = false;
            panel2.Controls.Clear();
            panel2.Controls.Add(bookingServicesPanel);
            bookingServicesPanel.Show();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 LoginForm = new Form1();
            LoginForm.ShowDialog();
            this.Close();
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}