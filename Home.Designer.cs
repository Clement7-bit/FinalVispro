namespace saloon
{
    partial class Home
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
            panel1 = new Panel();
            BookingServiceBtn = new Button();
            Logout = new Button();
            OrderHistoryBtn = new Button();
            ProductBtn = new Button();
            ProfileBtn = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Desktop;
            panel1.Controls.Add(BookingServiceBtn);
            panel1.Controls.Add(Logout);
            panel1.Controls.Add(OrderHistoryBtn);
            panel1.Controls.Add(ProductBtn);
            panel1.Controls.Add(ProfileBtn);
            panel1.Location = new Point(0, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(179, 565);
            panel1.TabIndex = 0;
            // 
            // BookingServiceBtn
            // 
            BookingServiceBtn.BackColor = SystemColors.Desktop;
            BookingServiceBtn.FlatStyle = FlatStyle.Flat;
            BookingServiceBtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BookingServiceBtn.ForeColor = SystemColors.ControlDark;
            BookingServiceBtn.Location = new Point(0, 156);
            BookingServiceBtn.Name = "BookingServiceBtn";
            BookingServiceBtn.Size = new Size(179, 56);
            BookingServiceBtn.TabIndex = 5;
            BookingServiceBtn.Text = "Booking Services";
            BookingServiceBtn.UseVisualStyleBackColor = false;
            BookingServiceBtn.Click += BookingServiceBtn_Click;
            // 
            // Logout
            // 
            Logout.BackColor = SystemColors.Desktop;
            Logout.FlatStyle = FlatStyle.Flat;
            Logout.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Logout.ForeColor = SystemColors.ControlDark;
            Logout.Location = new Point(0, 496);
            Logout.Name = "Logout";
            Logout.Size = new Size(179, 56);
            Logout.TabIndex = 4;
            Logout.Text = "Logout";
            Logout.UseVisualStyleBackColor = false;
            Logout.Click += Logout_Click;
            // 
            // OrderHistoryBtn
            // 
            OrderHistoryBtn.BackColor = SystemColors.Desktop;
            OrderHistoryBtn.FlatStyle = FlatStyle.Flat;
            OrderHistoryBtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OrderHistoryBtn.ForeColor = SystemColors.ControlDark;
            OrderHistoryBtn.Location = new Point(0, 218);
            OrderHistoryBtn.Name = "OrderHistoryBtn";
            OrderHistoryBtn.Size = new Size(179, 56);
            OrderHistoryBtn.TabIndex = 3;
            OrderHistoryBtn.Text = "Order History";
            OrderHistoryBtn.UseVisualStyleBackColor = false;
            OrderHistoryBtn.Click += OrderHistoryBtn_Click;
            // 
            // ProductBtn
            // 
            ProductBtn.BackColor = SystemColors.Desktop;
            ProductBtn.FlatStyle = FlatStyle.Flat;
            ProductBtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProductBtn.ForeColor = SystemColors.ControlDark;
            ProductBtn.Location = new Point(0, 94);
            ProductBtn.Name = "ProductBtn";
            ProductBtn.Size = new Size(179, 56);
            ProductBtn.TabIndex = 1;
            ProductBtn.Text = "Product";
            ProductBtn.UseVisualStyleBackColor = false;
            ProductBtn.Click += ProductBtn_Click;
            // 
            // ProfileBtn
            // 
            ProfileBtn.BackColor = SystemColors.Desktop;
            ProfileBtn.FlatStyle = FlatStyle.Flat;
            ProfileBtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProfileBtn.ForeColor = SystemColors.ControlDark;
            ProfileBtn.Location = new Point(0, 32);
            ProfileBtn.Name = "ProfileBtn";
            ProfileBtn.Size = new Size(179, 56);
            ProfileBtn.TabIndex = 0;
            ProfileBtn.Text = "Profile";
            ProfileBtn.UseVisualStyleBackColor = false;
            ProfileBtn.Click += ProfileBtn_Click;
            // 
            // panel2
            // 
            panel2.Location = new Point(185, -3);
            panel2.MaximumSize = new Size(898, 565);
            panel2.Name = "panel2";
            panel2.Size = new Size(898, 565);
            panel2.TabIndex = 1;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 561);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximizeBox = false;
            MaximumSize = new Size(1100, 600);
            MinimumSize = new Size(1100, 600);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            Load += Home_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button ProfileBtn;
        private Button OrderHistoryBtn;
        private Button ProductBtn;
        private Panel panel2;
        private Button Logout;
        private Button BookingServiceBtn;
    }
}