namespace thanh_toan
{
    partial class formChonHTTT
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
            this.btnTienMat1 = new System.Windows.Forms.Button();
            this.btnTheNganHang1 = new System.Windows.Forms.Button();
            this.btnThoat1 = new System.Windows.Forms.Button();
            this.cbbMaHD1 = new System.Windows.Forms.ComboBox();
            this.dgvDDH1 = new System.Windows.Forms.DataGridView();
            this.lbMaHD = new System.Windows.Forms.Label();
            this.txtTQ = new System.Windows.Forms.TextBox();
            this.txtTT = new System.Windows.Forms.TextBox();
            this.txtKH = new System.Windows.Forms.TextBox();
            this.txtMaDDH = new System.Windows.Forms.TextBox();
            this.lbHoTenThuQuy = new System.Windows.Forms.Label();
            this.lbTinhtrang4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbMaDDH4 = new System.Windows.Forms.Label();
            this.txtSoTien = new System.Windows.Forms.TextBox();
            this.lbSoTien = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDDH1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTienMat1
            // 
            this.btnTienMat1.Location = new System.Drawing.Point(118, 84);
            this.btnTienMat1.Name = "btnTienMat1";
            this.btnTienMat1.Size = new System.Drawing.Size(157, 41);
            this.btnTienMat1.TabIndex = 0;
            this.btnTienMat1.Text = "Tiền Mặt";
            this.btnTienMat1.UseVisualStyleBackColor = true;
            this.btnTienMat1.Click += new System.EventHandler(this.btnTienMat1_Click);
            // 
            // btnTheNganHang1
            // 
            this.btnTheNganHang1.Location = new System.Drawing.Point(308, 84);
            this.btnTheNganHang1.Name = "btnTheNganHang1";
            this.btnTheNganHang1.Size = new System.Drawing.Size(157, 41);
            this.btnTheNganHang1.TabIndex = 1;
            this.btnTheNganHang1.Text = "Thẻ Ngân Hàng";
            this.btnTheNganHang1.UseVisualStyleBackColor = true;
            // 
            // btnThoat1
            // 
            this.btnThoat1.Location = new System.Drawing.Point(513, 84);
            this.btnThoat1.Name = "btnThoat1";
            this.btnThoat1.Size = new System.Drawing.Size(157, 41);
            this.btnThoat1.TabIndex = 2;
            this.btnThoat1.Text = "Thoát";
            this.btnThoat1.UseVisualStyleBackColor = true;
            this.btnThoat1.Click += new System.EventHandler(this.btnThoat1_Click);
            // 
            // cbbMaHD1
            // 
            this.cbbMaHD1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaHD1.FormattingEnabled = true;
            this.cbbMaHD1.Location = new System.Drawing.Point(265, 33);
            this.cbbMaHD1.Name = "cbbMaHD1";
            this.cbbMaHD1.Size = new System.Drawing.Size(200, 28);
            this.cbbMaHD1.TabIndex = 3;
            this.cbbMaHD1.SelectionChangeCommitted += new System.EventHandler(this.cbbMaHD1_SelectionChangeCommitted);
            // 
            // dgvDDH1
            // 
            this.dgvDDH1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDDH1.Location = new System.Drawing.Point(90, 145);
            this.dgvDDH1.Name = "dgvDDH1";
            this.dgvDDH1.RowHeadersWidth = 51;
            this.dgvDDH1.RowTemplate.Height = 24;
            this.dgvDDH1.Size = new System.Drawing.Size(612, 266);
            this.dgvDDH1.TabIndex = 4;
            // 
            // lbMaHD
            // 
            this.lbMaHD.AutoSize = true;
            this.lbMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaHD.Location = new System.Drawing.Point(119, 36);
            this.lbMaHD.Name = "lbMaHD";
            this.lbMaHD.Size = new System.Drawing.Size(108, 20);
            this.lbMaHD.TabIndex = 5;
            this.lbMaHD.Text = "Mã Hóa Đơn:";
            // 
            // txtTQ
            // 
            this.txtTQ.Location = new System.Drawing.Point(291, 300);
            this.txtTQ.Name = "txtTQ";
            this.txtTQ.ReadOnly = true;
            this.txtTQ.Size = new System.Drawing.Size(207, 22);
            this.txtTQ.TabIndex = 17;
            // 
            // txtTT
            // 
            this.txtTT.Location = new System.Drawing.Point(291, 261);
            this.txtTT.Name = "txtTT";
            this.txtTT.ReadOnly = true;
            this.txtTT.Size = new System.Drawing.Size(207, 22);
            this.txtTT.TabIndex = 16;
            // 
            // txtKH
            // 
            this.txtKH.Location = new System.Drawing.Point(291, 223);
            this.txtKH.Name = "txtKH";
            this.txtKH.ReadOnly = true;
            this.txtKH.Size = new System.Drawing.Size(207, 22);
            this.txtKH.TabIndex = 15;
            // 
            // txtMaDDH
            // 
            this.txtMaDDH.Location = new System.Drawing.Point(291, 182);
            this.txtMaDDH.Multiline = true;
            this.txtMaDDH.Name = "txtMaDDH";
            this.txtMaDDH.ReadOnly = true;
            this.txtMaDDH.Size = new System.Drawing.Size(207, 22);
            this.txtMaDDH.TabIndex = 14;
            // 
            // lbHoTenThuQuy
            // 
            this.lbHoTenThuQuy.AutoSize = true;
            this.lbHoTenThuQuy.Location = new System.Drawing.Point(165, 305);
            this.lbHoTenThuQuy.Name = "lbHoTenThuQuy";
            this.lbHoTenThuQuy.Size = new System.Drawing.Size(63, 17);
            this.lbHoTenThuQuy.TabIndex = 13;
            this.lbHoTenThuQuy.Text = "Thủ Quỹ";
            // 
            // lbTinhtrang4
            // 
            this.lbTinhtrang4.AutoSize = true;
            this.lbTinhtrang4.Location = new System.Drawing.Point(165, 264);
            this.lbTinhtrang4.Name = "lbTinhtrang4";
            this.lbTinhtrang4.Size = new System.Drawing.Size(78, 17);
            this.lbTinhtrang4.TabIndex = 12;
            this.lbTinhtrang4.Text = "Tình Trạng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Khách Hàng";
            // 
            // lbMaDDH4
            // 
            this.lbMaDDH4.AutoSize = true;
            this.lbMaDDH4.Location = new System.Drawing.Point(165, 187);
            this.lbMaDDH4.Name = "lbMaDDH4";
            this.lbMaDDH4.Size = new System.Drawing.Size(61, 17);
            this.lbMaDDH4.TabIndex = 10;
            this.lbMaDDH4.Text = "Mã DDH";
            // 
            // txtSoTien
            // 
            this.txtSoTien.Location = new System.Drawing.Point(291, 343);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.ReadOnly = true;
            this.txtSoTien.Size = new System.Drawing.Size(207, 22);
            this.txtSoTien.TabIndex = 19;
            // 
            // lbSoTien
            // 
            this.lbSoTien.AutoSize = true;
            this.lbSoTien.Location = new System.Drawing.Point(165, 348);
            this.lbSoTien.Name = "lbSoTien";
            this.lbSoTien.Size = new System.Drawing.Size(57, 17);
            this.lbSoTien.TabIndex = 18;
            this.lbSoTien.Text = "Số Tiền";
            // 
            // formChonHTTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSoTien);
            this.Controls.Add(this.lbSoTien);
            this.Controls.Add(this.txtTQ);
            this.Controls.Add(this.txtTT);
            this.Controls.Add(this.txtKH);
            this.Controls.Add(this.txtMaDDH);
            this.Controls.Add(this.lbHoTenThuQuy);
            this.Controls.Add(this.lbTinhtrang4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbMaDDH4);
            this.Controls.Add(this.lbMaHD);
            this.Controls.Add(this.dgvDDH1);
            this.Controls.Add(this.cbbMaHD1);
            this.Controls.Add(this.btnThoat1);
            this.Controls.Add(this.btnTheNganHang1);
            this.Controls.Add(this.btnTienMat1);
            this.Name = "formChonHTTT";
            this.Text = "Chọn hình thức thanh toán";
            this.Load += new System.EventHandler(this.MHChonHTTT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDDH1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTienMat1;
        private System.Windows.Forms.Button btnTheNganHang1;
        private System.Windows.Forms.Button btnThoat1;
        private System.Windows.Forms.ComboBox cbbMaHD1;
        private System.Windows.Forms.DataGridView dgvDDH1;
        private System.Windows.Forms.Label lbMaHD;
        private System.Windows.Forms.TextBox txtTQ;
        private System.Windows.Forms.TextBox txtTT;
        private System.Windows.Forms.TextBox txtKH;
        private System.Windows.Forms.TextBox txtMaDDH;
        private System.Windows.Forms.Label lbHoTenThuQuy;
        private System.Windows.Forms.Label lbTinhtrang4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbMaDDH4;
        private System.Windows.Forms.TextBox txtSoTien;
        private System.Windows.Forms.Label lbSoTien;
    }
}

