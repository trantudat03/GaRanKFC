using DAO.Models;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class QuanLyLoaiSP_BUS
    {
        public static Model1 db = new Model1();

        public static List<LoaiSanPham_DTO> LayDuLieu()
        {
            List<LoaiSanPham_DTO> list = new List<LoaiSanPham_DTO>();

            db.LOAISANPHAMs.ToList().ForEach(l =>
            {
                LoaiSanPham_DTO item = new LoaiSanPham_DTO();
                item.MALOAISP = l.MALOAISP;
                item.TENLOAISP = l.TENLOAISP;
                list.Add(item);
            });

            return list;
        }

    }
}
