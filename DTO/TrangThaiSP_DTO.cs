using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TrangThaiSP_DTO
    {
        public string MATRANGTHAI { get; set; }
        public string TENTRANGTHAI { get; set; }

        public TrangThaiSP_DTO()
        {
            MATRANGTHAI = "0";
            TENTRANGTHAI = null;
        }
    }
}
