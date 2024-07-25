namespace demoBanHang
{
	partial class QLSP
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
            groupBox1 = new GroupBox();
            rbtnSP_NgungBan = new RadioButton();
            rbtnSP_HD = new RadioButton();
            btnCapNhatSP = new Button();
            btnThemSP = new Button();
            txtSP_Ten = new TextBox();
            txtSP_Gia = new TextBox();
            dtgView_SP = new DataGridView();
            cmbxLoc = new ComboBox();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgView_SP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 29);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 0;
            label1.Text = "Tên SP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 58);
            label2.Name = "label2";
            label2.Size = new Size(24, 15);
            label2.TabIndex = 1;
            label2.Text = "Giá";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 89);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 2;
            label3.Text = "Trạng Thái";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtnSP_NgungBan);
            groupBox1.Controls.Add(rbtnSP_HD);
            groupBox1.Location = new Point(92, 69);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(224, 55);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // rbtnSP_NgungBan
            // 
            rbtnSP_NgungBan.AutoSize = true;
            rbtnSP_NgungBan.Location = new Point(113, 22);
            rbtnSP_NgungBan.Name = "rbtnSP_NgungBan";
            rbtnSP_NgungBan.Size = new Size(85, 19);
            rbtnSP_NgungBan.TabIndex = 1;
            rbtnSP_NgungBan.TabStop = true;
            rbtnSP_NgungBan.Text = "Ngừng Bán";
            rbtnSP_NgungBan.UseVisualStyleBackColor = true;
            // 
            // rbtnSP_HD
            // 
            rbtnSP_HD.AutoSize = true;
            rbtnSP_HD.Location = new Point(13, 22);
            rbtnSP_HD.Name = "rbtnSP_HD";
            rbtnSP_HD.Size = new Size(83, 19);
            rbtnSP_HD.TabIndex = 0;
            rbtnSP_HD.TabStop = true;
            rbtnSP_HD.Text = "Hoạt Động";
            rbtnSP_HD.UseVisualStyleBackColor = true;
            // 
            // btnCapNhatSP
            // 
            btnCapNhatSP.Location = new Point(362, 54);
            btnCapNhatSP.Name = "btnCapNhatSP";
            btnCapNhatSP.Size = new Size(75, 23);
            btnCapNhatSP.TabIndex = 2;
            btnCapNhatSP.Text = "Cập Nhật";
            btnCapNhatSP.UseVisualStyleBackColor = true;
            btnCapNhatSP.Click += btnCapNhatSP_Click;
            // 
            // btnThemSP
            // 
            btnThemSP.Location = new Point(362, 12);
            btnThemSP.Name = "btnThemSP";
            btnThemSP.Size = new Size(75, 23);
            btnThemSP.TabIndex = 4;
            btnThemSP.Text = "Thêm";
            btnThemSP.UseVisualStyleBackColor = true;
            btnThemSP.Click += btnThemSP_Click;
            // 
            // txtSP_Ten
            // 
            txtSP_Ten.Location = new Point(92, 26);
            txtSP_Ten.Name = "txtSP_Ten";
            txtSP_Ten.Size = new Size(224, 23);
            txtSP_Ten.TabIndex = 5;
            // 
            // txtSP_Gia
            // 
            txtSP_Gia.Location = new Point(92, 50);
            txtSP_Gia.Name = "txtSP_Gia";
            txtSP_Gia.Size = new Size(224, 23);
            txtSP_Gia.TabIndex = 6;
            // 
            // dtgView_SP
            // 
            dtgView_SP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgView_SP.Location = new Point(452, 50);
            dtgView_SP.Name = "dtgView_SP";
            dtgView_SP.Size = new Size(467, 150);
            dtgView_SP.TabIndex = 7;
            dtgView_SP.CellClick += dtgView_SP_CellClick;
            // 
            // cmbxLoc
            // 
            cmbxLoc.FormattingEnabled = true;
            cmbxLoc.Items.AddRange(new object[] { "Đang Hoạt Động", "Ngừng Bán", "Tất Cả" });
            cmbxLoc.Location = new Point(798, 21);
            cmbxLoc.Name = "cmbxLoc";
            cmbxLoc.Size = new Size(121, 23);
            cmbxLoc.TabIndex = 8;
            cmbxLoc.SelectedIndexChanged += cmbxLoc_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(680, 26);
            label4.Name = "label4";
            label4.Size = new Size(112, 15);
            label4.TabIndex = 9;
            label4.Text = "Lọc Theo Trạng Thái";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 396);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(894, 296);
            dataGridView1.TabIndex = 10;
            // 
            // QLSP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(931, 704);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(cmbxLoc);
            Controls.Add(dtgView_SP);
            Controls.Add(txtSP_Gia);
            Controls.Add(txtSP_Ten);
            Controls.Add(btnThemSP);
            Controls.Add(btnCapNhatSP);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "QLSP";
            Text = "QLSP";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgView_SP).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private RadioButton rbtnSP_NgungBan;
        private RadioButton rbtnSP_HD;
        private Button btnCapNhatSP;
        private Button btnThemSP;
        private TextBox txtSP_Ten;
        private TextBox txtSP_Gia;
        private DataGridView dtgView_SP;
        private ComboBox cmbxLoc;
        private Label label4;
        private DataGridView dataGridView1;
    }
}