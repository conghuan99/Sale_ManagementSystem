namespace thanh_toan
{
    partial class formMHTB
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnDong3 = new System.Windows.Forms.Button();
            this.lbMaDDH4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTinhtrang4 = new System.Windows.Forms.Label();
            this.lbHoTenThuQuy = new System.Windows.Forms.Label();
            this.txtMaDDH = new System.Windows.Forms.TextBox();
            this.txtKH = new System.Windows.Forms.TextBox();
            this.txtTT = new System.Windows.Forms.TextBox();
            this.txtTQ = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thanh Toán Thành Công!";
            // 
            // btnDong3
            // 
            this.btnDong3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong3.Location = new System.Drawing.Point(322, 291);
            this.btnDong3.Name = "btnDong3";
            this.btnDong3.Size = new System.Drawing.Size(158, 54);
            this.btnDong3.TabIndex = 1;
            this.btnDong3.Text = "Đóng";
            this.btnDong3.UseVisualStyleBackColor = true;
            this.btnDong3.Click += new System.EventHandler(this.btnDong3_Click);
            // 
            // lbMaDDH4
            // 
            this.lbMaDDH4.AutoSize = true;
            this.lbMaDDH4.Location = new System.Drawing.Point(244, 121);
            this.lbMaDDH4.Name = "lbMaDDH4";
            this.lbMaDDH4.Size = new System.Drawing.Size(61, 17);
            this.lbMaDDH4.TabIndex = 2;
            this.lbMaDDH4.Text = "Mã DDH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Khách Hàng";
            // 
            // lbTinhtrang4
            // 
            this.lbTinhtrang4.AutoSize = true;
            this.lbTinhtrang4.Location = new System.Drawing.Point(244, 198);
            this.lbTinhtrang4.Name = "lbTinhtrang4";
            this.lbTinhtrang4.Size = new System.Drawing.Size(78, 17);
            this.lbTinhtrang4.TabIndex = 4;
            this.lbTinhtrang4.Text = "Tình Trạng";
            // 
            // lbHoTenThuQuy
            // 
            this.lbHoTenThuQuy.AutoSize = true;
            this.lbHoTenThuQuy.Location = new System.Drawing.Point(244, 239);
            this.lbHoTenThuQuy.Name = "lbHoTenThuQuy";
            this.lbHoTenThuQuy.Size = new System.Drawing.Size(63, 17);
            this.lbHoTenThuQuy.TabIndex = 5;
            this.lbHoTenThuQuy.Text = "Thủ Quỹ";
            // 
            // txtMaDDH
            // 
            this.txtMaDDH.Location = new System.Drawing.Point(370, 116);
            this.txtMaDDH.Multiline = true;
            this.txtMaDDH.Name = "txtMaDDH";
            this.txtMaDDH.ReadOnly = true;
            this.txtMaDDH.Size = new System.Drawing.Size(207, 22);
            this.txtMaDDH.TabIndex = 6;
            // 
            // txtKH
            // 
            this.txtKH.Location = new System.Drawing.Point(370, 157);
            this.txtKH.Name = "txtKH";
            this.txtKH.ReadOnly = true;
            this.txtKH.Size = new System.Drawing.Size(207, 22);
            this.txtKH.TabIndex = 7;
            // 
            // txtTT
            // 
            this.txtTT.Location = new System.Drawing.Point(370, 195);
            this.txtTT.Name = "txtTT";
            this.txtTT.ReadOnly = true;
            this.txtTT.Size = new System.Drawing.Size(207, 22);
            this.txtTT.TabIndex = 8;
            // 
            // txtTQ
            // 
            this.txtTQ.Location = new System.Drawing.Point(370, 234);
            this.txtTQ.Name = "txtTQ";
            this.txtTQ.ReadOnly = true;
            this.txtTQ.Size = new System.Drawing.Size(207, 22);
            this.txtTQ.TabIndex = 9;
            // 
            // formMHTB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTQ);
            this.Controls.Add(this.txtTT);
            this.Controls.Add(this.txtKH);
            this.Controls.Add(this.txtMaDDH);
            this.Controls.Add(this.lbHoTenThuQuy);
            this.Controls.Add(this.lbTinhtrang4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbMaDDH4);
            this.Controls.Add(this.btnDong3);
            this.Controls.Add(this.label1);
            this.Name = "formMHTB";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.formMHTB_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDong3;
        private System.Windows.Forms.Label lbMaDDH4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTinhtrang4;
        private System.Windows.Forms.Label lbHoTenThuQuy;
        private System.Windows.Forms.TextBox txtMaDDH;
        private System.Windows.Forms.TextBox txtKH;
        private System.Windows.Forms.TextBox txtTT;
        private System.Windows.Forms.TextBox txtTQ;
    }
}