namespace saloon
{
    partial class Checkout
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
            TotalPriceLabel = new Label();
            ProductsListBox = new ListBox();
            label1 = new Label();
            BuyBtn = new Button();
            CancelBtn = new Button();
            InputVoucher = new TextBox();
            TotalPriceAfterDiscountLbl = new Label();
            UseVoucherBtn = new Button();
            DiscountLabel = new Label();
            SuspendLayout();
            // 
            // TotalPriceLabel
            // 
            TotalPriceLabel.AutoSize = true;
            TotalPriceLabel.Location = new Point(12, 404);
            TotalPriceLabel.Name = "TotalPriceLabel";
            TotalPriceLabel.Size = new Size(38, 15);
            TotalPriceLabel.TabIndex = 0;
            TotalPriceLabel.Text = "label1";
            // 
            // ProductsListBox
            // 
            ProductsListBox.FormattingEnabled = true;
            ProductsListBox.ItemHeight = 15;
            ProductsListBox.Location = new Point(12, 52);
            ProductsListBox.Name = "ProductsListBox";
            ProductsListBox.Size = new Size(452, 349);
            ProductsListBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(157, 40);
            label1.TabIndex = 2;
            label1.Text = "Check Out";
            // 
            // BuyBtn
            // 
            BuyBtn.BackColor = Color.Lime;
            BuyBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BuyBtn.ForeColor = SystemColors.ActiveCaptionText;
            BuyBtn.Location = new Point(338, 488);
            BuyBtn.Name = "BuyBtn";
            BuyBtn.Size = new Size(126, 42);
            BuyBtn.TabIndex = 3;
            BuyBtn.Text = "Buy Product";
            BuyBtn.UseVisualStyleBackColor = false;
            BuyBtn.Click += BuyBtn_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.BackColor = Color.Red;
            CancelBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CancelBtn.ForeColor = SystemColors.ButtonHighlight;
            CancelBtn.Location = new Point(206, 488);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(126, 42);
            CancelBtn.TabIndex = 4;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = false;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // InputVoucher
            // 
            InputVoucher.Location = new Point(12, 459);
            InputVoucher.Name = "InputVoucher";
            InputVoucher.Size = new Size(388, 23);
            InputVoucher.TabIndex = 5;
            // 
            // TotalPriceAfterDiscountLbl
            // 
            TotalPriceAfterDiscountLbl.AutoSize = true;
            TotalPriceAfterDiscountLbl.Location = new Point(12, 441);
            TotalPriceAfterDiscountLbl.Name = "TotalPriceAfterDiscountLbl";
            TotalPriceAfterDiscountLbl.Size = new Size(135, 15);
            TotalPriceAfterDiscountLbl.TabIndex = 6;
            TotalPriceAfterDiscountLbl.Text = "Total After Discount: Rp.";
            // 
            // UseVoucherBtn
            // 
            UseVoucherBtn.Location = new Point(406, 459);
            UseVoucherBtn.Name = "UseVoucherBtn";
            UseVoucherBtn.Size = new Size(58, 23);
            UseVoucherBtn.TabIndex = 7;
            UseVoucherBtn.Text = "Use";
            UseVoucherBtn.UseVisualStyleBackColor = true;
            UseVoucherBtn.Click += UseVoucherBtn_Click;
            // 
            // DiscountLabel
            // 
            DiscountLabel.AutoSize = true;
            DiscountLabel.Location = new Point(12, 426);
            DiscountLabel.Name = "DiscountLabel";
            DiscountLabel.Size = new Size(86, 15);
            DiscountLabel.TabIndex = 8;
            DiscountLabel.Text = "Discount: Rp. 0";
            // 
            // Checkout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 542);
            Controls.Add(DiscountLabel);
            Controls.Add(UseVoucherBtn);
            Controls.Add(TotalPriceAfterDiscountLbl);
            Controls.Add(InputVoucher);
            Controls.Add(CancelBtn);
            Controls.Add(BuyBtn);
            Controls.Add(label1);
            Controls.Add(ProductsListBox);
            Controls.Add(TotalPriceLabel);
            MaximizeBox = false;
            MaximumSize = new Size(492, 581);
            MinimumSize = new Size(492, 581);
            Name = "Checkout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Checkout";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TotalPriceLabel;
        private ListBox ProductsListBox;
        private Label label1;
        private Button BuyBtn;
        private Button CancelBtn;
        private TextBox InputVoucher;
        private Label TotalPriceAfterDiscountLbl;
        private Button UseVoucherBtn;
        private Label DiscountLabel;
    }
}