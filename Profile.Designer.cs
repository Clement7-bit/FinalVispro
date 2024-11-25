namespace saloon
{
    partial class Profile
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
            NameLabel = new Label();
            NumberLabel = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            UsernameLabel = new Label();
            EditProfileBtn = new Button();
            label3 = new Label();
            AddressLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            NameLabel.Location = new Point(197, 62);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(93, 25);
            NameLabel.TabIndex = 0;
            NameLabel.Text = "John Doe";
            // 
            // NumberLabel
            // 
            NumberLabel.BorderStyle = BorderStyle.FixedSingle;
            NumberLabel.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            NumberLabel.Location = new Point(74, 373);
            NumberLabel.Name = "NumberLabel";
            NumberLabel.Size = new Size(264, 35);
            NumberLabel.TabIndex = 1;
            NumberLabel.Text = "123";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.profile_pic;
            pictureBox1.Location = new Point(74, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 99);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(74, 194);
            label1.Name = "label1";
            label1.Size = new Size(81, 21);
            label1.TabIndex = 3;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(74, 352);
            label2.Name = "label2";
            label2.Size = new Size(116, 21);
            label2.TabIndex = 4;
            label2.Text = "Phone Number";
            // 
            // UsernameLabel
            // 
            UsernameLabel.BorderStyle = BorderStyle.FixedSingle;
            UsernameLabel.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            UsernameLabel.Location = new Point(74, 215);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(264, 35);
            UsernameLabel.TabIndex = 5;
            UsernameLabel.Text = "lorem";
            // 
            // EditProfileBtn
            // 
            EditProfileBtn.Location = new Point(74, 438);
            EditProfileBtn.Name = "EditProfileBtn";
            EditProfileBtn.Size = new Size(144, 32);
            EditProfileBtn.TabIndex = 6;
            EditProfileBtn.Text = "Edit Profile";
            EditProfileBtn.UseVisualStyleBackColor = true;
            EditProfileBtn.Click += EditProfileBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(74, 270);
            label3.Name = "label3";
            label3.Size = new Size(66, 21);
            label3.TabIndex = 8;
            label3.Text = "Address";
            // 
            // AddressLabel
            // 
            AddressLabel.BorderStyle = BorderStyle.FixedSingle;
            AddressLabel.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            AddressLabel.Location = new Point(74, 291);
            AddressLabel.Name = "AddressLabel";
            AddressLabel.Size = new Size(264, 35);
            AddressLabel.TabIndex = 7;
            AddressLabel.Text = "123";
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 565);
            Controls.Add(label3);
            Controls.Add(AddressLabel);
            Controls.Add(EditProfileBtn);
            Controls.Add(UsernameLabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(NumberLabel);
            Controls.Add(NameLabel);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(898, 565);
            MinimumSize = new Size(898, 565);
            Name = "Profile";
            Text = "Profile";
            Load += Profile_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NameLabel;
        private Label NumberLabel;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label UsernameLabel;
        private Button EditProfileBtn;
        private Label label3;
        private Label AddressLabel;
    }
}