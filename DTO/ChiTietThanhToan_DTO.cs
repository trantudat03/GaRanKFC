using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietThanhToan_DTO
    {
        public string MAPHUONGTHUC { get; set; }
        public string MADONHANG { get; set; }

        public int SOTIENTRA { get; set; }

        public DonHang_DTO  DONHANG { get; set; }

        public  PhuongThucThanhToan_DTO PHUONGTHUCTHANHTOAN { get; set; }
    }
}
