namespace saloon
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            UsernameTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            LoginBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.saloon_logo;
            pictureBox1.Location = new Point(167, 143);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(157, 242);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.Location = new Point(468, 176);
            UsernameTextBox.MaxLength = 20;
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(320, 23);
            UsernameTextBox.TabIndex = 1;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(468, 245);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.Size = new Size(320, 23);
            PasswordTextBox.TabIndex = 2;
            // 
            // LoginBtn
            // 
            LoginBtn.Font = new Font("Segoe UI", 12F);
            LoginBtn.Location = new Point(575, 327);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(107, 44);
            LoginBtn.TabIndex = 3;
            LoginBtn.Text = "LOGIN";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(468, 148);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 4;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 14F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(468, 217);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.DarkOrange;
            label3.Location = new Point(468, 281);
            label3.Name = "label3";
            label3.Size = new Size(320, 21);
            label3.TabIndex = 6;
            label3.Text = "Log in to experience our best beauty services";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.login_bg;
            ClientSize = new Size(1084, 561);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LoginBtn);
            Controls.Add(PasswordTextBox);
            Controls.Add(UsernameTextBox);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            MaximumSize = new Size(1100, 600);
            MinimumSize = new Size(1100, 600);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox UsernameTextBox;
        private TextBox PasswordTextBox;
        private Button LoginBtn;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
