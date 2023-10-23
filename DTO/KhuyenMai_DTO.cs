using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhuyenMai_DTO
    {
        public string MAKHUYENMAI { get; set; }
        public string TENKHUYENMAI { get; set; }
        public int PHANTRAM { get; set; }
        public int SOTIENGIAM { get; set; }

        public int SOTIENGIAMTOIDA { get; set; }

        public string MADIEUKIEN { get; set; }

        public DieuKien_DTO DIEUKIEN { get; set; }

        public string NGAYBATDAU { get; set; }

        public string NGAYKETTHUC { get; set; }

        public KhuyenMai_DTO()
        {
            this.MAKHUYENMAI = string.Empty;
            this.TENKHUYENMAI = "";
            this.PHANTRAM = 0;
            this.SOTIENGIAM = 0;
            this.SOTIENGIAMTOIDA = 0;
            this.MADIEUKIEN = "";
            this.NGAYBATDAU = "";
            this.NGAYKETTHUC = "";
            this.DIEUKIEN  = new DieuKien_DTO();
        }
    }
}
