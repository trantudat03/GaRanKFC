using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHang_DTO
    {
        public string MAKHACHHANG { get; set; }

        public string TENKHACHHANG { get; set; }

        public string SODIENTHOAI { get; set; }

        public int DIEM { get; set; }

        public KhachHang_DTO() 
        {
            this.MAKHACHHANG = "";
            this.SODIENTHOAI = "";
            this.TENKHACHHANG = "";
            this.DIEM = -1;
        }
    }
}
