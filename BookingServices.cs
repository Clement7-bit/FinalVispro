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
using MySql.Data.MySqlClient;

namespace saloon
{
    public partial class BookingServices : Form
    {
        private MySqlConnection con;
        private string server, database, uid, password;
        private int userId;
        private string username;
        private List<Service> selectedServices = new List<Service>();
        private decimal discountedTotalPrice;

        public BookingServices(int userId, string username)
        {
            InitializeComponent();
            server = "localhost";
            database = "saloon";
            uid = "root";
            password = "";

            string conString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};";
            con = new MySqlConnection(conString);

            this.userId = userId;
            this.username = username;
        }

        private void BookingServices_Load(object sender, EventArgs e)
        {
            if (openConnection())
            {
                DisplayServices(FetchServices());
                closeConnection();
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

        private void closeConnection()
        {
            if (con != null && con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        private List<Service> FetchServices(string category = null)
        {
            List<Service> services = new List<Service>();
            string query = "SELECT service_id, category, name, description, price FROM services";

            if (!string.IsNullOrEmpty(category))
            {
                query += " WHERE category = @category";
            }

            try
            {
                MySqlCommand cmd = new MySqlCommand(query, con);
                if (!string.IsNullOrEmpty(category))
                {
                    cmd.Parameters.AddWithValue("@category", category);
                }

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Service service = new Service
                    {
                        ServiceId = reader.GetInt32("service_id"),
                        Category = reader.GetString("category"),
                        Name = reader.GetString("name"),
                        Description = reader.IsDBNull("description") ? string.Empty : reader.GetString("description"),
                        Price = reader.GetDecimal("price")
                    };
                    services.Add(service);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching services: " + ex.Message);
            }

            return services;
        }

        private void DisplayServices(List<Service> services)
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (var service in services)
            {
                ServicesCom serviceCom = new ServicesCom();
                serviceCom.SetServiceData(service);
                flowLayoutPanel1.Controls.Add(serviceCom);
            }
        }

        // Button event handlers for filtering by category
        private void HairBtn_Click(object sender, EventArgs e)
        {
            if (openConnection())
            {
                DisplayServices(FetchServices("Hair"));
                closeConnection();
            }
        }

        private void NaiBtn_Click(object sender, EventArgs e)
        {
            if (openConnection())
            {
                DisplayServices(FetchServices("Nail"));
                closeConnection();
            }
        }

        private void SpaBtn_Click(object sender, EventArgs e)
        {
            if (openConnection())
            {
                DisplayServices(FetchServices("Spa"));
                closeConnection();
            }
        }

        private void AllBtn_Click(object sender, EventArgs e)
        {
            if (openConnection())
            {
                DisplayServices(FetchServices());
                closeConnection();
            }
        }

        public void UpdateSelectedServices(Service service, bool isSelected)
        {
            if (isSelected)
            {
                selectedServices.Add(service);
            }
            else
            {
                selectedServices.Remove(service);
            }

            // Update the SelectedItemLbl and TotalPriceLbl
            UpdateSelectedItemsLabel();
            UpdateTotalPriceLabel();
        }

        private void UpdateSelectedItemsLabel()
        {
            // Display selected items
            SelectedItemLbl.Text = string.Join(", ", selectedServices.Select(s => s.Name));
        }

        private void UpdateTotalPriceLabel()
        {
            // Calculate total price
            decimal totalPrice = selectedServices.Sum(s => s.Price);
            TotalPriceLbl.Text = $"Rp. {totalPrice:N0}";
        }

        private void BookBtn_Click(object sender, EventArgs e)
        {
            if (openConnection())
            {
                try
                {


                    // Insert booking into the database
                    string query = "INSERT INTO booking (user_id, username, booking_date, total_price, services) " +
                                   "VALUES (@user_id, @username, @booking_date, @total_price, @services)";

                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@user_id", userId);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@booking_date", monthCalendar1.SelectionStart);
                    cmd.Parameters.AddWithValue("@total_price", selectedServices.Sum(s => s.Price));
                    cmd.Parameters.AddWithValue("@services", string.Join(", ", selectedServices.Select(s => s.Name)));

                    cmd.ExecuteNonQuery();

                    // Record the voucher usage
                    if (!string.IsNullOrEmpty(VoucherInput.Text))
                    {
                        RecordVoucherUsage(userId, VoucherInput.Text);
                    }

                    MessageBox.Show("Booking successful!");

                    // Reset the form controls
                    ResetFormControls();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while booking: " + ex.Message);
                }
                finally
                {
                    closeConnection();
                }
            }
        }

        private bool HasVoucherBeenUsed(int userId, string voucherCode)
        {
            string query = "SELECT COUNT(*) FROM voucher_usage WHERE user_id = @user_id AND voucher_code = @voucher_code";
            using (MySqlCommand cmd = new MySqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@user_id", userId);
                cmd.Parameters.AddWithValue("@voucher_code", voucherCode);

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close(); // Close the connection after the query is executed

                return count > 0;
            }
        }

        private void RecordVoucherUsage(int userId, string voucherCode)
        {
            string query = "INSERT INTO voucher_usage (user_id, voucher_code) VALUES (@user_id, @voucher_code)";
            using (MySqlCommand cmd = new MySqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@user_id", userId);
                cmd.Parameters.AddWithValue("@voucher_code", voucherCode);

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.ExecuteNonQuery();
                con.Close(); // Close the connection after the command is executed
            }
        }



        private void ResetFormControls()
        {
            // Clear selected services
            selectedServices.Clear();
            VoucherInput.Clear();
            SelectedItemLbl.Text = string.Empty; // Clear the selected items label
            TotalPriceLbl.Text = "Rp. 0"; // Reset total price label

            // Reset the checkboxes in the user controls
            foreach (var control in flowLayoutPanel1.Controls)
            {
                if (control is ServicesCom serviceCom)
                {
                    serviceCom.ResetCheckBox();
                }
            }

            // Reset the MonthCalendar to the current date or a default date
            monthCalendar1.SetDate(DateTime.Now);
        }

        private void UserVoucher_Click(object sender, EventArgs e)
        {
            string voucherCode = VoucherInput.Text.Trim();
            if (string.IsNullOrEmpty(voucherCode))
            {
                MessageBox.Show("Please enter a voucher code.");
                return;
            }

            if (openConnection())
            {
                Voucher voucher = FetchVoucher(voucherCode);
                closeConnection();

                if (voucher == null)
                {
                    MessageBox.Show("Invalid or expired voucher code.");
                    return;
                }

                // Check if voucher is within valid date range
                DateTime today = DateTime.Now;
                if (today < voucher.StartDate || today > voucher.ExpirationDate)
                {
                    MessageBox.Show("Voucher is not valid for the current date.");
                    return;
                }

                // Check if the minimum order amount is met
                decimal totalPrice = selectedServices.Sum(s => s.Price);
                if (totalPrice < voucher.MinOrderAmount)
                {
                    MessageBox.Show($"Minimum order amount for this voucher is Rp. {voucher.MinOrderAmount:N0}");
                    return;
                }

                // Check if voucher has already been used by this user
                if (HasVoucherBeenUsed(userId, voucherCode))
                {
                    MessageBox.Show("This voucher has already been used.");
                    VoucherInput.Clear();
                    closeConnection();
                    return;
                }

                // Calculate discount amount
                decimal discountAmount = totalPrice * (voucher.Discount / 100);
                if (voucher.MaxDiscountAmount.HasValue && discountAmount > voucher.MaxDiscountAmount.Value)
                {
                    discountAmount = voucher.MaxDiscountAmount.Value;
                }

                // Apply the discount and update total price
                discountedTotalPrice = totalPrice - discountAmount;
                TotalPriceLbl.Text = $"Rp. {discountedTotalPrice:N0}";
                MessageBox.Show($"Voucher applied! You saved Rp. {discountAmount:N0}");
            }
        }



        private Voucher FetchVoucher(string code)
        {
            Voucher voucher = null;
            string query = "SELECT * FROM voucher WHERE code = @code AND is_active = TRUE";

            try
            {
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@code", code);

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    voucher = new Voucher
                    {
                        VoucherId = reader.GetInt32("voucher_id"),
                        Code = reader.GetString("code"),
                        Discount = reader.GetDecimal("discount"),
                        MaxDiscountAmount = reader.IsDBNull("max_discount_amount") ? (decimal?)null : reader.GetDecimal("max_discount_amount"),
                        MinOrderAmount = reader.GetDecimal("min_order_amount"),
                        StartDate = reader.GetDateTime("start_date"),
                        ExpirationDate = reader.GetDateTime("expiration_date"),
                        IsActive = reader.GetBoolean("is_active")
                    };
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching voucher: " + ex.Message);
            }

            return voucher;
        }

    }

    public class Service
    {
        public int ServiceId { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }

    public class Voucher
    {
        public int VoucherId { get; set; }
        public string Code { get; set; }
        public decimal Discount { get; set; } // Discount percentage (e.g., 10 for 10%)
        public decimal? MaxDiscountAmount { get; set; } // Maximum discount in Rp
        public decimal MinOrderAmount { get; set; } // Minimum order amount to apply voucher
        public DateTime StartDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsActive { get; set; } // Whether the voucher is active
    }
}