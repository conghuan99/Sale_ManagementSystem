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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                // Ma don dat hang
                connection.Open();
                SqlCommand cmd = new SqlCommand("select MaDDH from DONDATHANG", connection);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cbbMHD.Items.Add(dr[0]);
                }
                connection.Close();

                // Ma mat hang
                connection.Open();
                SqlCommand cmd1 = new SqlCommand("select MaMH from MATHANG", connection);
                SqlDataReader dr1 = cmd1.ExecuteReader();
                while (dr1.Read())
                {
                    cbbMMH.Items.Add(dr1[0]);
                }
                connection.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                string sqlInsertDDH = "insert into CHITIETDDH values (@MaDDH,@MaMH,@SoLuong,@DonGia)";
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(sqlInsertDDH, connection);
                    cmd.Parameters.AddWithValue("@MaDDH", cbbMHD.GetItemText(cbbMHD.SelectedItem));
                    cmd.Parameters.AddWithValue("@MaMH", cbbMMH.GetItemText(cbbMMH.SelectedItem));
                    cmd.Parameters.AddWithValue("@SoLuong", textBox3.Text);
                    cmd.Parameters.AddWithValue("@DonGia", textBox4.Text);
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
