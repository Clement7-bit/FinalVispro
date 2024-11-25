namespace saloon
{
    partial class ServicesCom
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ServiceNameLbl = new Label();
            DescLbl = new Label();
            PriceLbl = new Label();
            BookingBox = new CheckBox();
            SuspendLayout();
            // 
            // ServiceNameLbl
            // 
            ServiceNameLbl.AutoSize = true;
            ServiceNameLbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ServiceNameLbl.Location = new Point(0, 6);
            ServiceNameLbl.Name = "ServiceNameLbl";
            ServiceNameLbl.Size = new Size(106, 21);
            ServiceNameLbl.TabIndex = 0;
            ServiceNameLbl.Text = "Lorem Ipsum";
            // 
            // DescLbl
            // 
            DescLbl.AutoSize = true;
            DescLbl.Location = new Point(3, 31);
            DescLbl.Name = "DescLbl";
            DescLbl.Size = new Size(77, 15);
            DescLbl.TabIndex = 1;
            DescLbl.Text = "Lorem Ipsum";
            // 
            // PriceLbl
            // 
            PriceLbl.AutoSize = true;
            PriceLbl.Location = new Point(484, 6);
            PriceLbl.Name = "PriceLbl";
            PriceLbl.Size = new Size(66, 15);
            PriceLbl.TabIndex = 2;
            PriceLbl.Text = "Rp. 123.456";
            // 
            // BookingBox
            // 
            BookingBox.AutoSize = true;
            BookingBox.Location = new Point(487, 27);
            BookingBox.Name = "BookingBox";
            BookingBox.Size = new Size(70, 19);
            BookingBox.TabIndex = 3;
            BookingBox.Text = "booking";
            BookingBox.UseVisualStyleBackColor = true;
            BookingBox.CheckedChanged += BookingBox_CheckedChanged;
            // 
            // ServicesCom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(BookingBox);
            Controls.Add(PriceLbl);
            Controls.Add(DescLbl);
            Controls.Add(ServiceNameLbl);
            Name = "ServicesCom";
            Size = new Size(565, 65);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ServiceNameLbl;
        private Label DescLbl;
        private Label PriceLbl;
        private CheckBox BookingBox;
    }
}
