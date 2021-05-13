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

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                // NVBH
                connection.Open();
                SqlCommand cmd = new SqlCommand("select MaNV from NhanVien where ChucVu= N'Bán hàng'", connection);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cbbNVBH.Items.Add(dr[0]);
                }
                connection.Close();

                // NVGH
                connection.Open();
                SqlCommand cmd1 = new SqlCommand("select MaNV from NhanVien where ChucVu= N'Giao hàng'", connection);
                SqlDataReader dr1 = cmd1.ExecuteReader();
                while (dr1.Read())
                {
                    cbbNVGH.Items.Add(dr1[0]);
                }
                connection.Close();

                // Thu Quy
                connection.Open();
                SqlCommand cmd2 = new SqlCommand("select MaNV from NhanVien where ChucVu= N'Thủ Quỹ'", connection);
                SqlDataReader dr2 = cmd2.ExecuteReader();
                while (dr2.Read())
                {
                    cbbThuQuy.Items.Add(dr2[0]);
                }
                connection.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            this.Hide();
            f3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.textBox1.TextLength == 0)
                MessageBox.Show("Không được để trống mã hóa đơn");
            else
            {
                string sqlInsertDDH = "insert into DONDATHANG values (@MaDDH,@HoTenKH,@DiaChi,@sdt,@NgayLap,@NVGH,@NVBH,@ThuQuy,@TinhTrang)";
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                        connection.Open();
                        SqlCommand cmd = new SqlCommand(sqlInsertDDH, connection);
                        cmd.Parameters.AddWithValue("@MaDDH", textBox1.Text);
                        cmd.Parameters.AddWithValue("@HoTenKH", textBox2.Text);
                        cmd.Parameters.AddWithValue("@DiaChi", textBox3.Text);
                        cmd.Parameters.AddWithValue("@sdt", textBox4.Text);
                        cmd.Parameters.AddWithValue("@NgayLap", DateTime.Now);
                        cmd.Parameters.AddWithValue("@NVGH", cbbNVGH.GetItemText(cbbNVGH.SelectedItem));
                        cmd.Parameters.AddWithValue("@NVBH", cbbNVBH.GetItemText(cbbNVBH.SelectedItem));
                        cmd.Parameters.AddWithValue("@ThuQuy", cbbThuQuy.GetItemText(cbbThuQuy.SelectedItem));
                        cmd.Parameters.AddWithValue("@TinhTrang", cbbTinhTrang.GetItemText(cbbTinhTrang.SelectedItem));
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Thêm thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại!");
                    }
                        connection.Close();
                }
            }
        }

    }
}
