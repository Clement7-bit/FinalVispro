namespace saloon
{
    partial class OrderHistory
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dataGridView2 = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 65);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(874, 225);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(118, 40);
            label1.TabIndex = 1;
            label1.Text = "History";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 49);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 2;
            label2.Text = "Booking History";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 308);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 3;
            label3.Text = "Buy History";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(12, 326);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(874, 191);
            dataGridView2.TabIndex = 4;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(811, 523);
            button1.Name = "button1";
            button1.Size = new Size(75, 30);
            button1.TabIndex = 5;
            button1.Text = "PRINT";
            button1.UseVisualStyleBackColor = true;
            // 
            // OrderHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 565);
            Controls.Add(button1);
            Controls.Add(dataGridView2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(898, 565);
            MinimumSize = new Size(898, 565);
            Name = "OrderHistory";
            Text = "OrderHistory";
            Load += OrderHistory_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dataGridView2;
        private Button button1;
    }
}