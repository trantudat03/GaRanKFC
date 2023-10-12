using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietDonHang_DTO
    {

        public string MASANPHAM { get; set; }
        public string MADONHANG { get; set; }

        public int SOLUONG { get; set; }
        public int GIASANPHAM { get; set; }

        public  DonHang_DTO DONHANG { get; set; }

        public  SanPham_DTO SANPHAM { get; set; }

        public ChiTietDonHang_DTO()
        {
            this.MADONHANG = string.Empty;
            this.MASANPHAM = string.Empty;
            this.SOLUONG = 0;
            this.GIASANPHAM = 0;
            this.DONHANG = new DonHang_DTO();
            this.SANPHAM = new SanPham_DTO();
        }


    }
}
