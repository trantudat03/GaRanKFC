using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DonHang_DTO
    {
        public string MADONHANG { get; set; }
        public string MANGUOIDUNG { get; set; }
        public string MAKHACHHANG { get; set; }

        public string MAKHUYENMAI { get; set; }
        public int TONGGIA { get; set; }

        public int SOLUONGSP { get; set; }

        public string THOIGIAN { get; set; }

        public string[] MAPHUONGTHUC { get; set; }

        public DonHang_DTO() 
        {
            MADONHANG = string.Empty;
            MANGUOIDUNG = string.Empty;
            MAKHACHHANG = string.Empty;
            THOIGIAN = string.Empty;
            this.MAKHUYENMAI = string.Empty;
            TONGGIA = 0;
            this.MAPHUONGTHUC = new string[3];
            this.SOLUONGSP = 0;
        }
    }
}
