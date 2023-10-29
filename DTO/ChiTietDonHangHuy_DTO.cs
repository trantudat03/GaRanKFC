using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietDonHangHuy_DTO
    {
        public string MASANPHAM { get; set; }

        public string MADONHANGHUY { get; set; }

        public int SOLUONG { get; set; }

        public int GIASANPHAM { get; set; }

    }
}
