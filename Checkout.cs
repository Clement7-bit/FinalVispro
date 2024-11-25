using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace saloon
{
    public partial class Checkout : Form
    {
        private MySqlConnection con;
        private string server, database, uid, password;
        private int userId;
        private decimal totalPrice;
        private string appliedVoucherCode;
        private decimal appliedDiscountPercentage;
        private List<(string productName, int quantity, decimal totalPrice)> products;        
        public event Action PurchaseCompleted;

        public Checkout(List<(string productName, int quantity, decimal totalPrice)> products, int userId)
        {
            InitializeComponent();

            this.products = products ?? new List<(string productName, int quantity, decimal totalPrice)>();
            DisplayProducts(this.products);            

            this.userId = userId; // Store userId for later use

            server = "localhost";
            database = "saloon";
            uid = "root";
            password = "";

            string conString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};";
            con = new MySqlConnection(conString);

            // Calculate the total price
            totalPrice = this.products.Any() ? this.products.Sum(p => p.totalPrice) : 0;
        }

        private void DisplayProducts(List<(string productName, int quantity, decimal totalPrice)> products)
        {
            decimal grandTotal = 0;

            // Display each product's details in a ListBox
            foreach (var product in products)
            {
                string productInfo = $"{product.productName} x {product.quantity} - Rp. {product.totalPrice:N2}";
                ProductsListBox.Items.Add(productInfo);
                grandTotal += product.totalPrice;
            }

            // Display total price in a label
            TotalPriceLabel.Text = "Total: Rp. " + grandTotal.ToString("N2");
            TotalPriceAfterDiscountLbl.Text = $"Total After Discount: Rp. " + grandTotal.ToString("N2");
        }

        private void SetInitialTotalPrice()
        {
            TotalPriceAfterDiscountLbl.Text = $"Total After Discount: Rp. {totalPrice:N2}";
        }

        private void UseVoucherBtn_Click(object sender, EventArgs e)
        {
            string voucherCode = InputVoucher.Text.Trim();

            if (string.IsNullOrEmpty(voucherCode))
            {
                MessageBox.Show("Please enter a voucher code.");
                return;
            }

            // Validate and apply the voucher
            ApplyVoucher(voucherCode);
        }

        private void ApplyVoucher(string voucherCode)
        {
            if (openConnection())
            {
                try
                {
                    // Check if the voucher exists, is active, and meets the conditions
                    string query = @"
                    SELECT discount, max_discount_amount, min_order_amount, expiration_date
                    FROM voucher
                    WHERE code = @voucherCode AND is_active = 1 AND expiration_date >= CURDATE()";

                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@voucherCode", voucherCode);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Get voucher details
                            decimal discountPercentage = reader.GetDecimal("discount");
                            decimal maxDiscountAmount = reader.IsDBNull(reader.GetOrdinal("max_discount_amount")) ? decimal.MaxValue : reader.GetDecimal("max_discount_amount");
                            decimal minOrderAmount = reader.GetDecimal("min_order_amount");
                            DateTime expirationDate = reader.GetDateTime("expiration_date");

                            // Check if total order amount meets the minimum required
                            if (totalPrice >= minOrderAmount)
                            {
                                // Calculate the discount amount with max limit
                                decimal discountAmount = totalPrice * (discountPercentage / 100);
                                if (discountAmount > maxDiscountAmount) discountAmount = maxDiscountAmount;

                                // Calculate total after discount
                                decimal totalAfterDiscount = totalPrice - discountAmount;

                                // Update UI with discount information
                                DiscountLabel.Text = $"Discount: Rp. {discountAmount:N2}";
                                TotalPriceAfterDiscountLbl.Text = $"Total After Discount: Rp. {totalAfterDiscount:N2}";

                                // Store the voucher details for later use in Buy button
                                appliedVoucherCode = voucherCode;
                                appliedDiscountPercentage = discountPercentage;

                                MessageBox.Show($"Voucher applied successfully! You saved Rp. {discountAmount:N2}.");
                            }
                            else
                            {
                                MessageBox.Show($"Minimum order amount to apply this voucher is Rp. {minOrderAmount:N2}.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid or expired voucher.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    closeConnection();
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

        private void closeConnection()
        {
            if (con != null && con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        private void BuyBtn_Click(object sender, EventArgs e)
        {
            if (openConnection())
            {
                try
                {
                    decimal discountAmount = 0;
                    decimal finalTotalPrice = totalPrice;

                    if (!string.IsNullOrEmpty(appliedVoucherCode))
                    {
                        discountAmount = totalPrice * (appliedDiscountPercentage / 100);
                        finalTotalPrice = totalPrice - discountAmount;

                        string insertVoucherUsageQuery = "INSERT INTO voucher_usage (user_id, voucher_code) VALUES (@userId, @voucherCode)";
                        MySqlCommand insertVoucherUsageCmd = new MySqlCommand(insertVoucherUsageQuery, con);
                        insertVoucherUsageCmd.Parameters.AddWithValue("@userId", userId);
                        insertVoucherUsageCmd.Parameters.AddWithValue("@voucherCode", appliedVoucherCode);
                        insertVoucherUsageCmd.ExecuteNonQuery();
                    }

                    // Buat string produk dan kuantitas untuk disimpan dalam satu kolom
                    string productNames = string.Join(",", products.Select(p => p.productName));
                    string quantities = string.Join(",", products.Select(p => p.quantity.ToString()));

                    // Query untuk menyimpan data ke tabel purchase
                    string insertPurchaseQuery = @"
                INSERT INTO purchase (user_id, product_names, quantities, total_price, discount_amount, final_total_price, voucher_code)
                VALUES (@userId, @productNames, @quantities, @totalPrice, @discountAmount, @finalTotalPrice, @voucherCode)";

                    MySqlCommand insertPurchaseCmd = new MySqlCommand(insertPurchaseQuery, con);
                    insertPurchaseCmd.Parameters.AddWithValue("@userId", userId);
                    insertPurchaseCmd.Parameters.AddWithValue("@productNames", productNames);
                    insertPurchaseCmd.Parameters.AddWithValue("@quantities", quantities);
                    insertPurchaseCmd.Parameters.AddWithValue("@totalPrice", totalPrice);
                    insertPurchaseCmd.Parameters.AddWithValue("@discountAmount", discountAmount);
                    insertPurchaseCmd.Parameters.AddWithValue("@finalTotalPrice", finalTotalPrice);
                    insertPurchaseCmd.Parameters.AddWithValue("@voucherCode", string.IsNullOrEmpty(appliedVoucherCode) ? (object)DBNull.Value : appliedVoucherCode);

                    insertPurchaseCmd.ExecuteNonQuery();

                    MessageBox.Show("Purchase successful! Thank you for your order.", "Purchase Completed");

                    // Trigger event PurchaseCompleted
                    PurchaseCompleted?.Invoke();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    closeConnection();
                }
            }
        }


        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
