﻿namespace demoBanHang
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
			label1 = new Label();
			label2 = new Label();
			txtUsername = new TextBox();
			txtPassword = new TextBox();
			btnLogin = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(107, 119);
			label1.Name = "label1";
			label1.Size = new Size(60, 15);
			label1.TabIndex = 0;
			label1.Text = "Username";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(107, 160);
			label2.Name = "label2";
			label2.Size = new Size(57, 15);
			label2.TabIndex = 1;
			label2.Text = "Password";
			// 
			// txtUsername
			// 
			txtUsername.Location = new Point(214, 116);
			txtUsername.Name = "txtUsername";
			txtUsername.Size = new Size(277, 23);
			txtUsername.TabIndex = 2;
			// 
			// txtPassword
			// 
			txtPassword.Location = new Point(214, 157);
			txtPassword.Name = "txtPassword";
			txtPassword.Size = new Size(277, 23);
			txtPassword.TabIndex = 3;
			// 
			// btnLogin
			// 
			btnLogin.Location = new Point(416, 205);
			btnLogin.Name = "btnLogin";
			btnLogin.Size = new Size(75, 23);
			btnLogin.TabIndex = 4;
			btnLogin.Text = "LogIn";
			btnLogin.UseVisualStyleBackColor = true;
			btnLogin.Click += btnLogin_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(btnLogin);
			Controls.Add(txtPassword);
			Controls.Add(txtUsername);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private TextBox txtUsername;
		private TextBox txtPassword;
		private Button btnLogin;
	}
}
