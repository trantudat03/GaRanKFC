using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DieuKien_DTO
    {
        public string MADIEUKIEN { get; set; }
        public string TENDIEUKIEN { get; set; }
        public int DIEMTOITHIEU { get; set; }

        public int GIATRIDONHANG { get; set; }

        public int SOKHUYENMAI { get; set; }

        public DieuKien_DTO() 
        {
            this.MADIEUKIEN = string.Empty;
            this.TENDIEUKIEN = "";
            this.DIEMTOITHIEU = 0;
            this.GIATRIDONHANG = 0;
            this.SOKHUYENMAI = 0;
        }
    }
}
