namespace demoBanHang
{
    partial class BanHang
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
            groupBox1 = new GroupBox();
            dtgView_SP = new DataGridView();
            btn_AddSPToHD = new Button();
            groupBox2 = new GroupBox();
            dtgView_HD = new DataGridView();
            btnCapNhatHD = new Button();
            btnTaoHD = new Button();
            groupBox3 = new GroupBox();
            btnXuatHD = new Button();
            btnThanhToan = new Button();
            txt_tienThua = new TextBox();
            label9 = new Label();
            txt_TienNhan = new TextBox();
            label8 = new Label();
            txtThanhTien = new TextBox();
            label7 = new Label();
            txtMaHD = new TextBox();
            label6 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txt_user = new TextBox();
            label3 = new Label();
            groupBox4 = new GroupBox();
            dtgView_HDCT = new DataGridView();
            button1 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgView_SP).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgView_HD).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgView_HDCT).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtgView_SP);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(930, 333);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "San Pham";
            // 
            // dtgView_SP
            // 
            dtgView_SP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgView_SP.Location = new Point(6, 22);
            dtgView_SP.Name = "dtgView_SP";
            dtgView_SP.Size = new Size(924, 289);
            dtgView_SP.TabIndex = 0;
            dtgView_SP.CellClick += dtgView_SP_CellClick;
            // 
            // btn_AddSPToHD
            // 
            btn_AddSPToHD.Location = new Point(1052, 34);
            btn_AddSPToHD.Name = "btn_AddSPToHD";
            btn_AddSPToHD.Size = new Size(244, 61);
            btn_AddSPToHD.TabIndex = 1;
            btn_AddSPToHD.Text = "Thêm Vào Hóa Đơn";
            btn_AddSPToHD.UseVisualStyleBackColor = true;
            btn_AddSPToHD.Click += btn_AddSPToHD_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtgView_HD);
            groupBox2.Location = new Point(18, 351);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(930, 287);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hóa Đơn";
            // 
            // dtgView_HD
            // 
            dtgView_HD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgView_HD.Location = new Point(12, 22);
            dtgView_HD.Name = "dtgView_HD";
            dtgView_HD.Size = new Size(918, 242);
            dtgView_HD.TabIndex = 4;
            dtgView_HD.CellClick += dtgView_HD_CellClick;
            // 
            // btnCapNhatHD
            // 
            btnCapNhatHD.Location = new Point(1052, 412);
            btnCapNhatHD.Name = "btnCapNhatHD";
            btnCapNhatHD.Size = new Size(244, 61);
            btnCapNhatHD.TabIndex = 5;
            btnCapNhatHD.Text = "Xóa Hóa Đơn";
            btnCapNhatHD.UseVisualStyleBackColor = true;
            btnCapNhatHD.Click += btnCapNhatHD_Click;
            // 
            // btnTaoHD
            // 
            btnTaoHD.Location = new Point(1052, 345);
            btnTaoHD.Name = "btnTaoHD";
            btnTaoHD.Size = new Size(244, 61);
            btnTaoHD.TabIndex = 4;
            btnTaoHD.Text = "Tạo Hóa Đơn";
            btnTaoHD.UseVisualStyleBackColor = true;
            btnTaoHD.Click += btnTaoHD_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnXuatHD);
            groupBox3.Controls.Add(btnThanhToan);
            groupBox3.Controls.Add(txt_tienThua);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(txt_TienNhan);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(txtThanhTien);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(txtMaHD);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(textBox3);
            groupBox3.Controls.Add(textBox2);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(txt_user);
            groupBox3.Controls.Add(label3);
            groupBox3.Location = new Point(1319, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(414, 752);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thanh Toán";
            // 
            // btnXuatHD
            // 
            btnXuatHD.Location = new Point(15, 685);
            btnXuatHD.Name = "btnXuatHD";
            btnXuatHD.Size = new Size(393, 61);
            btnXuatHD.TabIndex = 14;
            btnXuatHD.Text = "Xuất Hóa Đơn";
            btnXuatHD.UseVisualStyleBackColor = true;
            btnXuatHD.Click += btnXuatHD_Click;
            // 
            // btnThanhToan
            // 
            btnThanhToan.Location = new Point(15, 618);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(393, 61);
            btnThanhToan.TabIndex = 4;
            btnThanhToan.Text = "Thanh Toán";
            btnThanhToan.UseVisualStyleBackColor = true;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // txt_tienThua
            // 
            txt_tienThua.Enabled = false;
            txt_tienThua.Location = new Point(96, 293);
            txt_tienThua.Name = "txt_tienThua";
            txt_tienThua.Size = new Size(246, 23);
            txt_tienThua.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(15, 296);
            label9.Name = "label9";
            label9.Size = new Size(58, 15);
            label9.TabIndex = 12;
            label9.Text = "Tiền Thừa";
            // 
            // txt_TienNhan
            // 
            txt_TienNhan.Location = new Point(110, 253);
            txt_TienNhan.Name = "txt_TienNhan";
            txt_TienNhan.Size = new Size(246, 23);
            txt_TienNhan.TabIndex = 11;
            txt_TienNhan.TextChanged += txt_TienNhan_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 256);
            label8.Name = "label8";
            label8.Size = new Size(89, 15);
            label8.TabIndex = 10;
            label8.Text = "Tiền Khách Đưa";
            // 
            // txtThanhTien
            // 
            txtThanhTien.Location = new Point(96, 206);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.Size = new Size(246, 23);
            txtThanhTien.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 214);
            label7.Name = "label7";
            label7.Size = new Size(65, 15);
            label7.TabIndex = 8;
            label7.Text = "Thành Tiền";
            // 
            // txtMaHD
            // 
            txtMaHD.Location = new Point(96, 155);
            txtMaHD.Name = "txtMaHD";
            txtMaHD.Size = new Size(246, 23);
            txtMaHD.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 163);
            label6.Name = "label6";
            label6.Size = new Size(74, 15);
            label6.TabIndex = 6;
            label6.Text = "Mã Hóa Đơn";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(96, 95);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(246, 23);
            textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(96, 52);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(246, 23);
            textBox2.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 103);
            label5.Name = "label5";
            label5.Size = new Size(79, 15);
            label5.TabIndex = 3;
            label5.Text = "Số Điện Thoại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 55);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 2;
            label4.Text = "Khách Hàng";
            // 
            // txt_user
            // 
            txt_user.Location = new Point(96, 19);
            txt_user.Name = "txt_user";
            txt_user.Size = new Size(246, 23);
            txt_user.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 22);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 0;
            label3.Text = "Nhân Viên";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dtgView_HDCT);
            groupBox4.Location = new Point(18, 644);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(930, 302);
            groupBox4.TabIndex = 6;
            groupBox4.TabStop = false;
            groupBox4.Text = "Hoa Don Chi Tiet";
            // 
            // dtgView_HDCT
            // 
            dtgView_HDCT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgView_HDCT.Location = new Point(12, 22);
            dtgView_HDCT.Name = "dtgView_HDCT";
            dtgView_HDCT.Size = new Size(912, 274);
            dtgView_HDCT.TabIndex = 0;
            dtgView_HDCT.CellClick += dtgView_HDCT_CellClick;
            // 
            // button1
            // 
            button1.Location = new Point(1052, 668);
            button1.Name = "button1";
            button1.Size = new Size(234, 69);
            button1.TabIndex = 7;
            button1.Text = "Xoa";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // BanHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1745, 958);
            Controls.Add(button1);
            Controls.Add(groupBox4);
            Controls.Add(btnTaoHD);
            Controls.Add(btnCapNhatHD);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(btn_AddSPToHD);
            Controls.Add(groupBox1);
            Name = "BanHang";
            Text = "BanHang";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgView_SP).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgView_HD).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgView_HDCT).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btn_AddSPToHD;
        private DataGridView dtgView_SP;
        private Button btnCapNhatHD;
        private Button btnTaoHD;
        private DataGridView dtgView_HD;
        private GroupBox groupBox3;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label5;
        private Label label4;
        private TextBox txt_user;
        private Label label3;
        private Button btnXuatHD;
        private Button btnThanhToan;
        private TextBox txt_tienThua;
        private Label label9;
        private TextBox txt_TienNhan;
        private Label label8;
        private TextBox txtThanhTien;
        private Label label7;
        private TextBox txtMaHD;
        private Label label6;
        private GroupBox groupBox4;
        private DataGridView dtgView_HDCT;
        private Button button1;
    }
}