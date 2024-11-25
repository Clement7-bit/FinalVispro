namespace saloon
{
    partial class BookingServices
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
            label2 = new Label();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            HairBtn = new Button();
            NaiBtn = new Button();
            SpaBtn = new Button();
            BookBtn = new Button();
            AllBtn = new Button();
            monthCalendar1 = new MonthCalendar();
            label3 = new Label();
            SelectedItemLbl = new Label();
            panel1 = new Panel();
            label6 = new Label();
            TotalPriceLbl = new Label();
            label5 = new Label();
            label4 = new Label();
            VoucherInput = new TextBox();
            UserVoucher = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 9);
            label2.Name = "label2";
            label2.Size = new Size(200, 40);
            label2.TabIndex = 1;
            label2.Text = "Appointment";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 47);
            label1.Name = "label1";
            label1.Size = new Size(192, 17);
            label1.TabIndex = 2;
            label1.Text = "select what service do you want";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.Transparent;
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Location = new Point(12, 113);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(592, 446);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // HairBtn
            // 
            HairBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HairBtn.Location = new Point(116, 67);
            HairBtn.Name = "HairBtn";
            HairBtn.Size = new Size(98, 40);
            HairBtn.TabIndex = 4;
            HairBtn.Text = "HAIR";
            HairBtn.UseVisualStyleBackColor = true;
            HairBtn.Click += HairBtn_Click;
            // 
            // NaiBtn
            // 
            NaiBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NaiBtn.Location = new Point(220, 67);
            NaiBtn.Name = "NaiBtn";
            NaiBtn.Size = new Size(98, 40);
            NaiBtn.TabIndex = 5;
            NaiBtn.Text = "NAIL";
            NaiBtn.UseVisualStyleBackColor = true;
            NaiBtn.Click += NaiBtn_Click;
            // 
            // SpaBtn
            // 
            SpaBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SpaBtn.Location = new Point(324, 67);
            SpaBtn.Name = "SpaBtn";
            SpaBtn.Size = new Size(98, 40);
            SpaBtn.TabIndex = 6;
            SpaBtn.Text = "SPA";
            SpaBtn.UseVisualStyleBackColor = true;
            SpaBtn.Click += SpaBtn_Click;
            // 
            // BookBtn
            // 
            BookBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BookBtn.Location = new Point(98, 502);
            BookBtn.Name = "BookBtn";
            BookBtn.Size = new Size(178, 42);
            BookBtn.TabIndex = 3;
            BookBtn.Text = "Make Appointment";
            BookBtn.UseVisualStyleBackColor = true;
            BookBtn.Click += BookBtn_Click;
            // 
            // AllBtn
            // 
            AllBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AllBtn.Location = new Point(12, 67);
            AllBtn.Name = "AllBtn";
            AllBtn.Size = new Size(98, 40);
            AllBtn.TabIndex = 7;
            AllBtn.Text = "ALL";
            AllBtn.UseVisualStyleBackColor = true;
            AllBtn.Click += AllBtn_Click;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(9, 248);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 3);
            label3.Name = "label3";
            label3.Size = new Size(154, 21);
            label3.TabIndex = 9;
            label3.Text = "Appointment Detail";
            // 
            // SelectedItemLbl
            // 
            SelectedItemLbl.Location = new Point(9, 46);
            SelectedItemLbl.Name = "SelectedItemLbl";
            SelectedItemLbl.Size = new Size(267, 193);
            SelectedItemLbl.TabIndex = 10;
            SelectedItemLbl.Text = "-";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(UserVoucher);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(TotalPriceLbl);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(VoucherInput);
            panel1.Controls.Add(BookBtn);
            panel1.Controls.Add(SelectedItemLbl);
            panel1.Controls.Add(monthCalendar1);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(610, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(281, 550);
            panel1.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 31);
            label6.Name = "label6";
            label6.Size = new Size(99, 15);
            label6.TabIndex = 15;
            label6.Text = "Selected Services:";
            // 
            // TotalPriceLbl
            // 
            TotalPriceLbl.Location = new Point(197, 474);
            TotalPriceLbl.Name = "TotalPriceLbl";
            TotalPriceLbl.Size = new Size(79, 15);
            TotalPriceLbl.TabIndex = 14;
            TotalPriceLbl.Text = "Rp. 0-";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 474);
            label5.Name = "label5";
            label5.Size = new Size(62, 15);
            label5.TabIndex = 13;
            label5.Text = "Total Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 419);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 12;
            label4.Text = "Input Voucher";
            // 
            // VoucherInput
            // 
            VoucherInput.Location = new Point(9, 437);
            VoucherInput.Name = "VoucherInput";
            VoucherInput.Size = new Size(210, 23);
            VoucherInput.TabIndex = 11;
            // 
            // UserVoucher
            // 
            UserVoucher.Location = new Point(225, 437);
            UserVoucher.Name = "UserVoucher";
            UserVoucher.Size = new Size(51, 23);
            UserVoucher.TabIndex = 16;
            UserVoucher.Text = "Use";
            UserVoucher.UseVisualStyleBackColor = true;
            UserVoucher.Click += UserVoucher_Click;
            // 
            // BookingServices
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 565);
            Controls.Add(panel1);
            Controls.Add(AllBtn);
            Controls.Add(SpaBtn);
            Controls.Add(NaiBtn);
            Controls.Add(HairBtn);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(898, 565);
            MinimumSize = new Size(898, 565);
            Name = "BookingServices";
            Text = "BookingServices";
            Load += BookingServices_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button HairBtn;
        private Button NaiBtn;
        private Button SpaBtn;
        private Button BookBtn;
        private Button AllBtn;
        private MonthCalendar monthCalendar1;
        private Label label3;
        private Label SelectedItemLbl;
        private Panel panel1;
        private Label TotalPriceLbl;
        private Label label5;
        private Label label4;
        private TextBox VoucherInput;
        private Label label6;
        private Button UserVoucher;
    }
}