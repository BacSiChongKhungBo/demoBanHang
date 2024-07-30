namespace demoBanHang
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
            lblUsername = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            pHome = new Panel();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(600, 19);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(38, 15);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "label1";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F);
            button1.Location = new Point(12, 43);
            button1.Name = "button1";
            button1.Size = new Size(190, 66);
            button1.TabIndex = 1;
            button1.Text = "Quản Lý Sản Phẩm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 15F);
            button2.Location = new Point(12, 115);
            button2.Name = "button2";
            button2.Size = new Size(190, 66);
            button2.TabIndex = 2;
            button2.Text = "Quản Lý Tài Khoản";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 15F);
            button3.Location = new Point(12, 187);
            button3.Name = "button3";
            button3.Size = new Size(190, 66);
            button3.TabIndex = 3;
            button3.Text = "Bán Hàng";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 15F);
            button4.Location = new Point(12, 259);
            button4.Name = "button4";
            button4.Size = new Size(190, 66);
            button4.TabIndex = 4;
            button4.Text = "Lịch Sử Giao Dịch";
            button4.UseVisualStyleBackColor = true;
            // 
            // pHome
            // 
            pHome.Location = new Point(208, 45);
            pHome.Name = "pHome";
            pHome.Size = new Size(1016, 834);
            pHome.TabIndex = 5;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1236, 891);
            Controls.Add(pHome);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblUsername);
            Name = "Home";
            Text = "Home";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsername;
		private Button button1;
		private Button button2;
		private Button button3;
		private Button button4;
		private Panel pHome;
	}
}