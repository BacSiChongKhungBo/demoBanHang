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
            label2 = new Label();
            label1 = new Label();
            btn_AddSPToHD = new Button();
            dtgView_SP = new DataGridView();
            groupBox2 = new GroupBox();
            btnCapNhatHD = new Button();
            btnTaoHD = new Button();
            dtgView_CTHD = new DataGridView();
            groupBox3 = new GroupBox();
            button5 = new Button();
            button4 = new Button();
            textBox7 = new TextBox();
            label9 = new Label();
            textBox6 = new TextBox();
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
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgView_SP).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgView_CTHD).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btn_AddSPToHD);
            groupBox1.Controls.Add(dtgView_SP);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(930, 384);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "San Pham";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(281, 340);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 3;
            label2.Text = "Giá Tiền";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 340);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 2;
            label1.Text = "Tên Sản Phẩm";
            // 
            // btn_AddSPToHD
            // 
            btn_AddSPToHD.Location = new Point(680, 317);
            btn_AddSPToHD.Name = "btn_AddSPToHD";
            btn_AddSPToHD.Size = new Size(244, 61);
            btn_AddSPToHD.TabIndex = 1;
            btn_AddSPToHD.Text = "Thêm Vào Hóa Đơn";
            btn_AddSPToHD.UseVisualStyleBackColor = true;
            btn_AddSPToHD.Click += btn_AddSPToHD_Click;
            // 
            // dtgView_SP
            // 
            dtgView_SP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgView_SP.Location = new Point(6, 22);
            dtgView_SP.Name = "dtgView_SP";
            dtgView_SP.Size = new Size(918, 289);
            dtgView_SP.TabIndex = 0;
            dtgView_SP.CellClick += dtgView_SP_CellClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnCapNhatHD);
            groupBox2.Controls.Add(btnTaoHD);
            groupBox2.Controls.Add(dtgView_CTHD);
            groupBox2.Location = new Point(12, 402);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(930, 362);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hóa Đơn";
            // 
            // btnCapNhatHD
            // 
            btnCapNhatHD.Location = new Point(269, 34);
            btnCapNhatHD.Name = "btnCapNhatHD";
            btnCapNhatHD.Size = new Size(244, 61);
            btnCapNhatHD.TabIndex = 5;
            btnCapNhatHD.Text = "Xóa Hóa Đơn";
            btnCapNhatHD.UseVisualStyleBackColor = true;
            // 
            // btnTaoHD
            // 
            btnTaoHD.Location = new Point(6, 34);
            btnTaoHD.Name = "btnTaoHD";
            btnTaoHD.Size = new Size(244, 61);
            btnTaoHD.TabIndex = 4;
            btnTaoHD.Text = "Tạo Hóa Đơn";
            btnTaoHD.UseVisualStyleBackColor = true;
            btnTaoHD.Click += btnTaoHD_Click;
            // 
            // dtgView_CTHD
            // 
            dtgView_CTHD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgView_CTHD.Location = new Point(6, 114);
            dtgView_CTHD.Name = "dtgView_CTHD";
            dtgView_CTHD.Size = new Size(918, 242);
            dtgView_CTHD.TabIndex = 4;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button5);
            groupBox3.Controls.Add(button4);
            groupBox3.Controls.Add(textBox7);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(textBox6);
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
            groupBox3.Location = new Point(948, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(414, 752);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thanh Toán";
            // 
            // button5
            // 
            button5.Location = new Point(15, 685);
            button5.Name = "button5";
            button5.Size = new Size(393, 61);
            button5.TabIndex = 14;
            button5.Text = "Xuất Hóa Đơn";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(15, 618);
            button4.Name = "button4";
            button4.Size = new Size(393, 61);
            button4.TabIndex = 4;
            button4.Text = "Thanh Toán";
            button4.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(96, 293);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(246, 23);
            textBox7.TabIndex = 13;
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
            // textBox6
            // 
            textBox6.Location = new Point(110, 253);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(246, 23);
            textBox6.TabIndex = 11;
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
            // BanHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1374, 776);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "BanHang";
            Text = "BanHang";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgView_SP).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgView_CTHD).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label2;
        private Label label1;
        private Button btn_AddSPToHD;
        private DataGridView dtgView_SP;
        private Button btnCapNhatHD;
        private Button btnTaoHD;
        private DataGridView dtgView_CTHD;
        private GroupBox groupBox3;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label5;
        private Label label4;
        private TextBox txt_user;
        private Label label3;
        private Button button5;
        private Button button4;
        private TextBox textBox7;
        private Label label9;
        private TextBox textBox6;
        private Label label8;
        private TextBox txtThanhTien;
        private Label label7;
        private TextBox txtMaHD;
        private Label label6;
    }
}