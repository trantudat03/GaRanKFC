using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DTO
{
    public class DonHangHuy_DTO
    {
        public string MADONHANGHUY { get; set; }

        public string MANGUOIDUNG { get; set; }

        public string TENNGUOIDUNG { get; set; }
        public string MAKHACHHANG { get; set; }

        public string TENKHACHHANG { get; set; }

        public int TONGGIA { get; set; }

        public int SOLUONGSP { get; set; }

        public DateTime THOIGIAN { get; set; }

        public DateTime THOIGIANBATDAU { get; set; }
        public string LYDO { get; set; }
    }
}
