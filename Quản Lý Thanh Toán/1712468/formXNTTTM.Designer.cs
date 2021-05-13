namespace thanh_toan
{
    partial class formXNTTTM
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
            this.cbbThuQuy2 = new System.Windows.Forms.ComboBox();
            this.lbThuQuy2 = new System.Windows.Forms.Label();
            this.btnXNTTTM2 = new System.Windows.Forms.Button();
            this.btnHuy2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbbThuQuy2
            // 
            this.cbbThuQuy2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbThuQuy2.FormattingEnabled = true;
            this.cbbThuQuy2.Location = new System.Drawing.Point(325, 144);
            this.cbbThuQuy2.Name = "cbbThuQuy2";
            this.cbbThuQuy2.Size = new System.Drawing.Size(239, 33);
            this.cbbThuQuy2.TabIndex = 0;
            // 
            // lbThuQuy2
            // 
            this.lbThuQuy2.AutoSize = true;
            this.lbThuQuy2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThuQuy2.Location = new System.Drawing.Point(203, 148);
            this.lbThuQuy2.Name = "lbThuQuy2";
            this.lbThuQuy2.Size = new System.Drawing.Size(116, 29);
            this.lbThuQuy2.TabIndex = 1;
            this.lbThuQuy2.Text = "Thủ Quỹ:";
            this.lbThuQuy2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnXNTTTM2
            // 
            this.btnXNTTTM2.Location = new System.Drawing.Point(126, 248);
            this.btnXNTTTM2.Name = "btnXNTTTM2";
            this.btnXNTTTM2.Size = new System.Drawing.Size(237, 64);
            this.btnXNTTTM2.TabIndex = 2;
            this.btnXNTTTM2.Text = "Xác Nhận Thanh Toán";
            this.btnXNTTTM2.UseVisualStyleBackColor = true;
            this.btnXNTTTM2.Click += new System.EventHandler(this.btnXNTTTM2_Click);
            // 
            // btnHuy2
            // 
            this.btnHuy2.Location = new System.Drawing.Point(417, 248);
            this.btnHuy2.Name = "btnHuy2";
            this.btnHuy2.Size = new System.Drawing.Size(237, 64);
            this.btnHuy2.TabIndex = 3;
            this.btnHuy2.Text = "Hủy";
            this.btnHuy2.UseVisualStyleBackColor = true;
            this.btnHuy2.Click += new System.EventHandler(this.btnHuy2_Click);
            // 
            // formXNTTTM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHuy2);
            this.Controls.Add(this.btnXNTTTM2);
            this.Controls.Add(this.lbThuQuy2);
            this.Controls.Add(this.cbbThuQuy2);
            this.Name = "formXNTTTM";
            this.Text = "Xác nhận thanh toán";
            this.Load += new System.EventHandler(this.formXNTTTM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbThuQuy2;
        private System.Windows.Forms.Label lbThuQuy2;
        private System.Windows.Forms.Button btnXNTTTM2;
        private System.Windows.Forms.Button btnHuy2;
    }
}