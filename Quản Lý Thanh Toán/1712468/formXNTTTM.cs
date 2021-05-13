using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace thanh_toan
{
    public partial class formXNTTTM : Form
    {
        public int MaThuQuy;
        public string MaHDChuaTT;
        public formXNTTTM(string MaDDHCanThanhToan)
        {
            this.MaHDChuaTT = MaDDHCanThanhToan;
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-HC\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True");
        SqlDataAdapter da;
        private void formXNTTTM_Load(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("select* from NhanVien where ChucVu= N'Thủ quỹ'", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Dispose();
            cbbThuQuy2.DataSource = dt;
            cbbThuQuy2.DisplayMember = "TenNV";
            cbbThuQuy2.ValueMember = "MaNV";
        }
        private void btnHuy2_Click(object sender, EventArgs e)
        {
            formChonHTTT frmChonHTTT = new formChonHTTT();
            this.Hide();
            frmChonHTTT.Show();
        }

        private void btnXNTTTM2_Click(object sender, EventArgs e)
        {
            
            MaThuQuy = (int)cbbThuQuy2.SelectedValue;
            if(DonDatHang.ThanhToan(MaHDChuaTT, MaThuQuy) == true)
            {
                formMHTB frmTB = new formMHTB(MaHDChuaTT, MaThuQuy);
                this.Hide();
                frmTB.Show();
                return;
            }

        }


    }
}
