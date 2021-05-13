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
    public partial class formChonHTTT : Form
    {
        public string MaDDHCanThanhToan;
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-HC\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True");
        SqlDataAdapter da;

        public formChonHTTT()
        {
            InitializeComponent();
        }

        private void MHChonHTTT_Load(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("select* from DonDatHang where TinhTrang= N'Đang giao - Chưa Thanh Toán' or TinhTrang= N'Chưa Thanh Toán'", cn);
            DataTable dt1 = new DataTable();
            da.Fill(dt1);
            da.Dispose();
            cbbMaHD1.DataSource = dt1;
            cbbMaHD1.DisplayMember = "MaDDH";
            cbbMaHD1.ValueMember = "MaDDH";

            if (cbbMaHD1.SelectedValue != null)
            {
                DataTable dt2 = new DataTable();
                da = new SqlDataAdapter("Select * from DonDatHang where MaDDH= '" + cbbMaHD1.SelectedValue + "'", cn);
                da.Fill(dt2);
                da.Dispose();
                txtMaDDH.Text = dt2.Rows[0]["MaDDH"].ToString();
                txtKH.Text = dt2.Rows[0]["HoTenKH"].ToString();
                txtTT.Text = dt2.Rows[0]["TinhTrang"].ToString();
                txtTQ.Text = "";
                //dgvDDH1.DataSource = dt;
                dt2.Clear();
                da = new SqlDataAdapter("Select sum(CTDDH.SoLuong * CTDDH.DonGia) as SoTien from CHITIETDDH CTDDH where MaDDH= '" + cbbMaHD1.SelectedValue + "'", cn);
                // Console.WriteLine("Select sum(CTDDH.SoLuong * CTDDH.DonGia) as SoTien from CHITIETDDH CTDDH where MaDDH= '" + cbbMaHD1.SelectedValue + "'");
                da.Fill(dt2);
                da.Dispose();
                txtSoTien.Text = dt2.Rows[0]["SoTien"].ToString();
                dt2.Clear();
            }
            
            else
            {
                btnTienMat1.Enabled = false;
                btnTheNganHang1.Enabled = false;
            }
        }
        private void cbbMaHD1_SelectionChangeCommitted(object sender, EventArgs e)
        {

            da = new SqlDataAdapter("Select * from DonDatHang where MaDDH= '" + cbbMaHD1.SelectedValue + "'", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Dispose();
            txtMaDDH.Text = dt.Rows[0]["MaDDH"].ToString();
            txtKH.Text = dt.Rows[0]["HoTenKH"].ToString();
            txtTT.Text = dt.Rows[0]["TinhTrang"].ToString();
            txtTQ.Text = "";
            //dgvDDH1.DataSource = dt;
            dt.Clear();

            da= new SqlDataAdapter("Select sum(CTDDH.SoLuong * CTDDH.DonGia) as SoTien from CHITIETDDH CTDDH where MaDDH= '" + cbbMaHD1.SelectedValue + "'", cn);
            Console.WriteLine("Select sum(CTDDH.SoLuong * CTDDH.DonGia) as SoTien from CHITIETDDH CTDDH where MaDDH= '" + cbbMaHD1.SelectedValue + "'");
            da.Fill(dt);
            da.Dispose();
            txtSoTien.Text = dt.Rows[0]["SoTien"].ToString();
            dt.Clear();
        }

        private void btnThoat1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnTienMat1_Click(object sender, EventArgs e)
        {
            MaDDHCanThanhToan = cbbMaHD1.SelectedValue.ToString();
            formXNTTTM frmXNHTTTM = new formXNTTTM(MaDDHCanThanhToan);
            this.Hide();
            frmXNHTTTM.Show();
        }
    }
}
