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
    public partial class formMHTB : Form
    {
        public string MaDDHDaTT;
        public int MaTQ;
        public formMHTB(string MaDDH, int MaTQ)
        {
            this.MaDDHDaTT = MaDDH;
            this.MaTQ = MaTQ;
            InitializeComponent();
        }

        private void btnDong3_Click(object sender, EventArgs e)
        {
            this.Hide();
            return;
        }

        private void formMHTB_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-HC\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True");
            SqlDataAdapter da1;

            da1 = new SqlDataAdapter("select MaDDH, HoTenKH, TinhTrang from DonDatHang where MaDDH= '" + this.MaDDHDaTT + "'", cn);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            da1.Dispose();
            txtMaDDH.Text = dt1.Rows[0]["MaDDH"].ToString();
            txtKH.Text = dt1.Rows[0]["HoTenKH"].ToString();
            txtTT.Text = dt1.Rows[0]["TinhTrang"].ToString();
            dt1.Clear();

            da1 = new SqlDataAdapter("select TenNV from NHANVIEN where MaNV= " + this.MaTQ.ToString(), cn);
            da1.Fill(dt1);
            da1.Dispose();
            txtTQ.Text = dt1.Rows[0]["TenNV"].ToString();
            dt1.Clone();
        }
    }
}
