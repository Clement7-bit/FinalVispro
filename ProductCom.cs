using System;
using System.Drawing;
using System.Windows.Forms;

namespace saloon
{
    public partial class ProductCom : UserControl
    {
        public int ProductId { get; private set; }
        public string ProductName { get; private set; }
        public decimal PriceIdr { get; private set; }

        public event EventHandler<(int productId, string productName, int quantity, decimal priceIdr)> ProductCountChanged;

        public ProductCom()
        {
            InitializeComponent();
            ProductCountLbl.Text = "0";
            ProductMinBtn.Enabled = false;
            ProductImage.Image = Properties.Resources.no_image_available;

        }

        private void ProductMaxBtn_Click(object sender, EventArgs e)
        {
            int currentCount = int.Parse(ProductCountLbl.Text);
            currentCount += 1;
            ProductCountLbl.Text = currentCount.ToString();

            ProductMinBtn.Enabled = true;

            ProductCountChanged?.Invoke(this, (ProductId, ProductName, currentCount, PriceIdr));
        }

        private void ProductMinBtn_Click(object sender, EventArgs e)
        {
            int currentCount = int.Parse(ProductCountLbl.Text);
            if (currentCount > 0)
            {
                currentCount -= 1;
                ProductCountLbl.Text = currentCount.ToString();

                ProductMinBtn.Enabled = currentCount > 0;

                ProductCountChanged?.Invoke(this, (ProductId, ProductName, currentCount, PriceIdr));
            }
        }

        public void SetProductDetails(int id, string productName, string description, decimal priceIdr, Image productImage)
        {
            ProductId = id;
            ProductName = productName;
            PriceIdr = priceIdr;

            ProductNameLbl.Text = productName;
            DescProductLbl.Text = description;
            PriceLbl.Text = "Rp. " + priceIdr.ToString("N2");

            if (productImage != null)
            {
                ProductImage.Image = productImage;
                ProductImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                ProductImage.Image = Properties.Resources.no_image_available;
                ProductImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        public void ResetProductCount()
        {
            ProductCountLbl.Text = "0";
            ProductMinBtn.Enabled = false;

            ProductCountChanged?.Invoke(this, (ProductId, ProductName, 0, PriceIdr));
        }
    }
}
