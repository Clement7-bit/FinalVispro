namespace saloon
{
    partial class Product
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            CheckOutBtn = new Button();
            label2 = new Label();
            ProductCartLabel = new Label();
            TotalPriceLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(126, 40);
            label1.TabIndex = 0;
            label1.Text = "Product";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.Transparent;
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Location = new Point(12, 67);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(749, 486);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // CheckOutBtn
            // 
            CheckOutBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CheckOutBtn.Location = new Point(767, 508);
            CheckOutBtn.Name = "CheckOutBtn";
            CheckOutBtn.Size = new Size(119, 42);
            CheckOutBtn.TabIndex = 2;
            CheckOutBtn.Text = "Check Out";
            CheckOutBtn.UseVisualStyleBackColor = true;
            CheckOutBtn.Click += CheckOutBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(767, 67);
            label2.Name = "label2";
            label2.Size = new Size(95, 21);
            label2.TabIndex = 3;
            label2.Text = "Order Detail";
            // 
            // ProductCartLabel
            // 
            ProductCartLabel.Location = new Point(767, 98);
            ProductCartLabel.Name = "ProductCartLabel";
            ProductCartLabel.Size = new Size(119, 392);
            ProductCartLabel.TabIndex = 4;
            ProductCartLabel.Text = "-";
            // 
            // TotalPriceLabel
            // 
            TotalPriceLabel.AutoSize = true;
            TotalPriceLabel.Location = new Point(767, 490);
            TotalPriceLabel.Name = "TotalPriceLabel";
            TotalPriceLabel.Size = new Size(56, 15);
            TotalPriceLabel.TabIndex = 5;
            TotalPriceLabel.Text = "Total: Rp.";
            // 
            // Product
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 565);
            Controls.Add(TotalPriceLabel);
            Controls.Add(ProductCartLabel);
            Controls.Add(label2);
            Controls.Add(CheckOutBtn);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(898, 565);
            MinimumSize = new Size(898, 565);
            Name = "Product";
            Text = "Product";
            Load += Product_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button CheckOutBtn;
        private Label label2;
        private Label ProductCartLabel;
        private Label TotalPriceLabel;
    }
}