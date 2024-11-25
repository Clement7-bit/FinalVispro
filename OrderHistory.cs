using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace saloon
{
    public partial class OrderHistory : Form
    {
        private MySqlConnection con;
        private string server, database, uid, password;
        private int userId;

        public OrderHistory(int userId)
        {
            InitializeComponent();
            server = "localhost";
            database = "saloon";
            uid = "root";
            password = "";

            string conString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};";
            con = new MySqlConnection(conString);

            this.userId = userId;
        }

        private void OrderHistory_Load(object sender, EventArgs e)
        {
            LoadBookingHistory();
            LoadPurchaseHistory();
        }

        private void LoadBookingHistory()
        {
            if (openConnection())
            {
                try
                {
                    string query = "SELECT username, booking_date, total_price, services, created_at FROM booking WHERE user_id=@userId";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@userId", userId);

                    DataTable dataTable = new DataTable();

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }

                    dataGridView1.DataSource = dataTable;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    dataGridView1.Columns["username"].HeaderText = "Username";
                    dataGridView1.Columns["booking_date"].HeaderText = "Booking Date";
                    dataGridView1.Columns["total_price"].HeaderText = "Total Price";
                    dataGridView1.Columns["services"].HeaderText = "Services";
                    dataGridView1.Columns["created_at"].HeaderText = "Created At";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading booking history: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void LoadPurchaseHistory()
        {
            if (openConnection())
            {
                try
                {
                    string query = "SELECT product_names, quantities, total_price, final_total_price, purchase_date FROM purchase WHERE user_id=@userId";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@userId", userId);

                    DataTable dataTable = new DataTable();

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }

                    dataGridView2.DataSource = dataTable;
                    dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    dataGridView2.Columns["product_names"].HeaderText = "Product Name";
                    dataGridView2.Columns["quantities"].HeaderText = "Quantity";
                    dataGridView2.Columns["total_price"].HeaderText = "Price (IDR)";
                    dataGridView2.Columns["final_total_price"].HeaderText = "Discount Price (IDR)";
                    dataGridView2.Columns["purchase_date"].HeaderText = "Purchase Date";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading purchase history: " + ex.Message);
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
    }
}
