using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace thanh_toan
{
    class DonDatHang_DB
    {
        public static bool CapNhat( string MaDDH, int MaThuQuy)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-HC\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True");
            String sql = "Update DonDatHang set TinhTrang = N'Đã Thanh Toán', ThuQuy= " + MaThuQuy.ToString() + " where MaDDH = '" + MaDDH + "'";
            cn.Open();
            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.ExecuteNonQuery();
            cn.Close();
            return true;
        }
    }
}
