namespace demoBanHang
{
	partial class Home2
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
			SuspendLayout();
			// 
			// lblUsername
			// 
			lblUsername.AutoSize = true;
			lblUsername.Location = new Point(691, 20);
			lblUsername.Name = "lblUsername";
			lblUsername.Size = new Size(38, 15);
			lblUsername.TabIndex = 0;
			lblUsername.Text = "label1";
			// 
			// Home2
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(lblUsername);
			Name = "Home2";
			Text = "Home2";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblUsername;
	}
}