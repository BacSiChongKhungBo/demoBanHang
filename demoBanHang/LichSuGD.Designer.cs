namespace demoBanHang
{
    partial class LichSuGD
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
            cmbBoLoc = new ComboBox();
            txtSearch = new TextBox();
            dtgViewHD = new DataGridView();
            dtgViewCTHD = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtgViewHD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgViewCTHD).BeginInit();
            SuspendLayout();
            // 
            // cmbBoLoc
            // 
            cmbBoLoc.FormattingEnabled = true;
            cmbBoLoc.Location = new Point(484, 12);
            cmbBoLoc.Name = "cmbBoLoc";
            cmbBoLoc.Size = new Size(180, 23);
            cmbBoLoc.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(25, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(233, 23);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // dtgViewHD
            // 
            dtgViewHD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgViewHD.Location = new Point(25, 56);
            dtgViewHD.Name = "dtgViewHD";
            dtgViewHD.Size = new Size(639, 239);
            dtgViewHD.TabIndex = 2;
            // 
            // dtgViewCTHD
            // 
            dtgViewCTHD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgViewCTHD.Location = new Point(25, 391);
            dtgViewCTHD.Name = "dtgViewCTHD";
            dtgViewCTHD.Size = new Size(639, 270);
            dtgViewCTHD.TabIndex = 3;
            // 
            // LichSuGD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1170, 735);
            Controls.Add(dtgViewCTHD);
            Controls.Add(dtgViewHD);
            Controls.Add(txtSearch);
            Controls.Add(cmbBoLoc);
            Name = "LichSuGD";
            Text = "LichSuGD";
            ((System.ComponentModel.ISupportInitialize)dtgViewHD).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgViewCTHD).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbBoLoc;
        private TextBox txtSearch;
        private DataGridView dtgViewHD;
        private DataGridView dtgViewCTHD;
    }
}