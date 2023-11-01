using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiSanPham_DTO
    {
        public string MALOAISP { get; set; }
        public string TENLOAISP { get; set; }
        public int TONGSOLUONG { get; set; }// nham muc dic luu tong so luong sp cua loai do

        public LoaiSanPham_DTO()
        {
            this.MALOAISP = string.Empty;
            this.TENLOAISP = string.Empty;
            this.TONGSOLUONG = 0;
        }
    }
}
