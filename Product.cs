using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace saloon
{
    public partial class Product : Form
    {
        private MySqlConnection con;
        private string server, database, uid, password;
        private int userId;

        // Dictionary to hold selected products
        private Dictionary<int, (string productName, int quantity, decimal price)> selectedProducts = new Dictionary<int, (string, int, decimal)>();

        public Product(int userId)
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

        private void Product_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            if (openConnection())
            {
                string query = "SELECT * FROM product";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = reader.GetInt32("id");
                    string productName = reader.GetString("product_name");
                    string description = reader.GetString("description");
                    decimal priceIdr = reader.GetDecimal("price_idr");
                    byte[] imageBytes = reader["image"] as byte[];

                    Image productImage = null;
                    if (imageBytes != null && imageBytes.Length > 0)
                    {
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            productImage = Image.FromStream(ms);
                        }
                    }

                    // Create ProductCom instance and set details
                    ProductCom productControl = new ProductCom();
                    productControl.SetProductDetails(id, productName, description, priceIdr, productImage);

                    // Subscribe to ProductCountChanged event
                    productControl.ProductCountChanged += ProductControl_ProductCountChanged;

                    // Add ProductCom to FlowLayoutPanel
                    flowLayoutPanel1.Controls.Add(productControl);
                }

                reader.Close();
                closeConnection();
            }
        }

        private void ProductControl_ProductCountChanged(object sender, (int productId, string productName, int quantity, decimal priceIdr) e)
        {
            // Update selected products dictionary
            if (e.quantity > 0)
            {
                selectedProducts[e.productId] = (e.productName, e.quantity, e.priceIdr);
            }
            else
            {
                selectedProducts.Remove(e.productId);
            }

            // Update the cart label and total price
            UpdateCartDisplay();
        }

        private void UpdateCartDisplay()
        {
            // Display selected products in ProductCartLabel
            ProductCartLabel.Text = string.Join("\n", selectedProducts.Values.Select(
                p => $"{p.productName} x {p.quantity} - Rp. {(p.quantity * p.price):N2}"));

            // Calculate and display total price in TotalPriceLabel
            decimal totalPrice = selectedProducts.Values.Sum(p => p.quantity * p.price);
            TotalPriceLabel.Text = "Total: Rp. " + totalPrice.ToString("N2");
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

        private void CheckOutBtn_Click(object sender, EventArgs e)
        {
            List<(string productName, int quantity, decimal totalPrice)> checkoutProducts = selectedProducts
                .Select(p => (p.Value.productName, p.Value.quantity, p.Value.quantity * p.Value.price))
                .ToList();

            Checkout checkoutForm = new Checkout(checkoutProducts, userId);

            checkoutForm.PurchaseCompleted += ResetCart;

            checkoutForm.ShowDialog();
        }

        public void ResetCart()
        {
            selectedProducts.Clear();

            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is ProductCom productCom)
                {
                    productCom.ResetProductCount();
                }
            }

            UpdateCartDisplay();
        }


    }
}


