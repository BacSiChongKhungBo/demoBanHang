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
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            clbx_TheTich = new Label();
            btn_CTSP_Them = new Button();
            btn_CTSP_CapNhat = new Button();
            groupBox2 = new GroupBox();
            rbtn_CTSP_NB = new RadioButton();
            rbtn_CTSP_HD = new RadioButton();
            txtTenSP2 = new TextBox();
            chlbx_Hang = new CheckedListBox();
            chlbx_TheTich = new CheckedListBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgView_SP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 221);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 11;
            label5.Text = "Tên SP";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 259);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 12;
            label6.Text = "Trang Thai";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(392, 221);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 13;
            label7.Text = "Hang";
            // 
            // clbx_TheTich
            // 
            clbx_TheTich.AutoSize = true;
            clbx_TheTich.Location = new Point(643, 221);
            clbx_TheTich.Name = "clbx_TheTich";
            clbx_TheTich.Size = new Size(51, 15);
            clbx_TheTich.TabIndex = 14;
            clbx_TheTich.Text = "The Tich";
            // 
            // btn_CTSP_Them
            // 
            btn_CTSP_Them.Location = new Point(25, 311);
            btn_CTSP_Them.Name = "btn_CTSP_Them";
            btn_CTSP_Them.Size = new Size(124, 55);
            btn_CTSP_Them.TabIndex = 15;
            btn_CTSP_Them.Text = "Thêm";
            btn_CTSP_Them.UseVisualStyleBackColor = true;
            btn_CTSP_Them.Click += btn_CTSP_Them_Click;
            // 
            // btn_CTSP_CapNhat
            // 
            btn_CTSP_CapNhat.Location = new Point(166, 311);
            btn_CTSP_CapNhat.Name = "btn_CTSP_CapNhat";
            btn_CTSP_CapNhat.Size = new Size(124, 55);
            btn_CTSP_CapNhat.TabIndex = 16;
            btn_CTSP_CapNhat.Text = "Cập Nhật";
            btn_CTSP_CapNhat.UseVisualStyleBackColor = true;
            btn_CTSP_CapNhat.Click += btn_CTSP_CapNhat_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbtn_CTSP_NB);
            groupBox2.Controls.Add(rbtn_CTSP_HD);
            groupBox2.Location = new Point(105, 245);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 41);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            // 
            // rbtn_CTSP_NB
            // 
            rbtn_CTSP_NB.AutoSize = true;
            rbtn_CTSP_NB.Location = new Point(95, 13);
            rbtn_CTSP_NB.Name = "rbtn_CTSP_NB";
            rbtn_CTSP_NB.Size = new Size(85, 19);
            rbtn_CTSP_NB.TabIndex = 1;
            rbtn_CTSP_NB.TabStop = true;
            rbtn_CTSP_NB.Text = "Ngừng Bán";
            rbtn_CTSP_NB.UseVisualStyleBackColor = true;
            // 
            // rbtn_CTSP_HD
            // 
            rbtn_CTSP_HD.AutoSize = true;
            rbtn_CTSP_HD.Location = new Point(7, 13);
            rbtn_CTSP_HD.Name = "rbtn_CTSP_HD";
            rbtn_CTSP_HD.Size = new Size(82, 19);
            rbtn_CTSP_HD.TabIndex = 0;
            rbtn_CTSP_HD.TabStop = true;
            rbtn_CTSP_HD.Text = "Hoạt động";
            rbtn_CTSP_HD.UseVisualStyleBackColor = true;
            // 
            // txtTenSP2
            // 
            txtTenSP2.Location = new Point(105, 218);
            txtTenSP2.Name = "txtTenSP2";
            txtTenSP2.Size = new Size(224, 23);
            txtTenSP2.TabIndex = 18;
            // 
            // chlbx_Hang
            // 
            chlbx_Hang.FormattingEnabled = true;
            chlbx_Hang.Location = new Point(445, 219);
            chlbx_Hang.Name = "chlbx_Hang";
            chlbx_Hang.Size = new Size(120, 148);
            chlbx_Hang.TabIndex = 19;
            // 
            // chlbx_TheTich
            // 
            chlbx_TheTich.FormattingEnabled = true;
            chlbx_TheTich.Location = new Point(700, 218);
            chlbx_TheTich.Name = "chlbx_TheTich";
            chlbx_TheTich.Size = new Size(120, 148);
            chlbx_TheTich.TabIndex = 20;
            // 
            // QLSP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(931, 704);
            Controls.Add(chlbx_TheTich);
            Controls.Add(chlbx_Hang);
            Controls.Add(txtTenSP2);
            Controls.Add(groupBox2);
            Controls.Add(btn_CTSP_CapNhat);
            Controls.Add(btn_CTSP_Them);
            Controls.Add(clbx_TheTich);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
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
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
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
        private Label label5;
        private Label label6;
        private Label label7;
        private Label clbx_TheTich;
        private Button btn_CTSP_Them;
        private Button btn_CTSP_CapNhat;
        private GroupBox groupBox2;
        private RadioButton rbtn_CTSP_NB;
        private RadioButton rbtn_CTSP_HD;
        private TextBox txtTenSP2;
        private CheckedListBox chlbx_Hang;
        private CheckedListBox chlbx_TheTich;
    }
}