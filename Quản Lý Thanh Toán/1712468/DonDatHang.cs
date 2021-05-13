using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thanh_toan
{
    class DonDatHang
    {
        public static bool ThanhToan(string MaDDH, int MaThuQuy) {
            return DonDatHang_DB.CapNhat(MaDDH, MaThuQuy);
        }

    }
}
