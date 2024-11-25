namespace saloon
{
    partial class EditProfile
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            InputName = new TextBox();
            InputPassword = new TextBox();
            InputAddress = new TextBox();
            InputNumber = new TextBox();
            SaveBtn = new Button();
            CancelBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.White;
            label1.Location = new Point(70, 46);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 0;
            label1.Text = "Change Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.White;
            label2.Location = new Point(70, 184);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 1;
            label2.Text = "Change Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.White;
            label3.Location = new Point(70, 111);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 2;
            label3.Text = "Change Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = Color.White;
            label4.Location = new Point(70, 257);
            label4.Name = "label4";
            label4.Size = new Size(132, 15);
            label4.TabIndex = 3;
            label4.Text = "Change Phone Number";
            // 
            // InputName
            // 
            InputName.Location = new Point(71, 64);
            InputName.Name = "InputName";
            InputName.Size = new Size(428, 23);
            InputName.TabIndex = 4;
            // 
            // InputPassword
            // 
            InputPassword.Location = new Point(71, 129);
            InputPassword.Name = "InputPassword";
            InputPassword.Size = new Size(428, 23);
            InputPassword.TabIndex = 5;
            // 
            // InputAddress
            // 
            InputAddress.Location = new Point(71, 202);
            InputAddress.Name = "InputAddress";
            InputAddress.Size = new Size(428, 23);
            InputAddress.TabIndex = 6;
            // 
            // InputNumber
            // 
            InputNumber.Location = new Point(71, 275);
            InputNumber.Name = "InputNumber";
            InputNumber.Size = new Size(428, 23);
            InputNumber.TabIndex = 7;
            // 
            // SaveBtn
            // 
            SaveBtn.Location = new Point(70, 333);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(125, 31);
            SaveBtn.TabIndex = 8;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.BackColor = Color.FromArgb(192, 0, 0);
            CancelBtn.FlatAppearance.BorderSize = 0;
            CancelBtn.FlatStyle = FlatStyle.Flat;
            CancelBtn.ForeColor = SystemColors.Control;
            CancelBtn.Location = new Point(201, 333);
            CancelBtn.Margin = new Padding(0);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(125, 31);
            CancelBtn.TabIndex = 9;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = false;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // EditProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.login_bg;
            ClientSize = new Size(565, 376);
            Controls.Add(CancelBtn);
            Controls.Add(SaveBtn);
            Controls.Add(InputNumber);
            Controls.Add(InputAddress);
            Controls.Add(InputPassword);
            Controls.Add(InputName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MaximumSize = new Size(581, 415);
            MinimumSize = new Size(581, 415);
            Name = "EditProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditProfile";
            Load += EditProfile_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox InputName;
        private TextBox InputPassword;
        private TextBox InputAddress;
        private TextBox InputNumber;
        private Button SaveBtn;
        private Button CancelBtn;
    }
}