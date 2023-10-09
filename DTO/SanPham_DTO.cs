using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SanPham_DTO
    {
        public string MASANPHAM { get; set; }

        public string MALOAISP { get; set; }

        public string TENSANPHAM { get; set; }
        public string ANHSANPHAM { get; set; }

        public int GIASANPHAM { get; set; }
        public int THOIHAN { get; set; }

        public int SOLUONG { get; set; }

        public int SLORDER { get; set; }

        public string NOTE { get; set; }

        public LoaiSanPham_DTO LoaiSanPham { get; set; }

        

        public SanPham_DTO()
        {
            this.MASANPHAM = null;
            this.TENSANPHAM = null;
            this.MALOAISP = null;
            this.GIASANPHAM = 0;
            this.THOIHAN = 0;
            this.SOLUONG = 0;
            this.SLORDER = 0;
            this.ANHSANPHAM = null;
            this.NOTE = null;
            this.LoaiSanPham = new LoaiSanPham_DTO() { MALOAISP = "", TENLOAISP = ""};
        }
    }
}
