using DAO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace BUS
{
    public class QuanLySanPham_BUS
    {

        public static Model1 db = new Model1();

        public static List<SanPham_DTO> layDULieu()
        {
            List<SanPham_DTO> list = new List<SanPham_DTO>();

            db.SANPHAMs.ToList().ForEach(s =>
            {
                SanPham_DTO sp = new SanPham_DTO();
                sp.MALOAISP = s.MALOAISP;
                sp.MASANPHAM = s.MASANPHAM;
                sp.TENSANPHAM = s.TENSANPHAM;
                sp.GIASANPHAM = int.Parse(s.GIASANPHAM.ToString());
                sp.ANHSANPHAM = s.ANHSANPHAM;
                sp.THOIHAN = int.Parse(s.THOIHAN.ToString());
                sp.SOLUONG = int.Parse(s.SOLUONG.ToString());
                sp.LoaiSanPham.TENLOAISP = s.LOAISANPHAM.TENLOAISP;
                sp.LoaiSanPham.MALOAISP = s.LOAISANPHAM.MALOAISP.ToString();
                list.Add(sp);
            });

            return list;
        }

        public static int themSanPham(SanPham_DTO sanpham)
        {
            SANPHAM check = db.SANPHAMs.Find(sanpham.MASANPHAM);

            if(check != null) 
            {
                return 0;
            }
            else
            {
                SANPHAM newSP = new SANPHAM();
                newSP.MASANPHAM = sanpham.MASANPHAM;
                // ten
                // anh
                // so, thoi

                newSP.MALOAISP = sanpham.MALOAISP;
                db.SANPHAMs.Add(newSP);
                db.SaveChanges();
            }

            return 0;
        }
    }
}
