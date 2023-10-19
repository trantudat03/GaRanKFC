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


        public static string taoMa(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            StringBuilder sb = new StringBuilder();
            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                int index = random.Next(chars.Length);
                sb.Append(chars[index]);
            }

            return sb.ToString();
        }
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

        public static List<LoaiSanPham_DTO> soLuongSanPhamTheoLoai()
        {
            List<LoaiSanPham_DTO> list = new List<LoaiSanPham_DTO>();


            var query = from l in db.LOAISANPHAMs
                        join s in db.SANPHAMs on l.MALOAISP equals s.MALOAISP
                        group s by new { l.MALOAISP, l.TENLOAISP } into g
                        select new
                        {
                            MALOAISP = g.Key.MALOAISP,
                            TENLOAISP = g.Key.TENLOAISP,
                            TONGSOLUONG = g.Count()
                        };

            foreach (var result in query)
            {
                LoaiSanPham_DTO item = new LoaiSanPham_DTO();
                item.MALOAISP = result.MALOAISP;
                item.TENLOAISP = result.TENLOAISP;
                item.TONGSOLUON = result.TONGSOLUONG;
                list.Add(item);
            }
            return list;
        }

        public static string themLoaiSP(LoaiSanPham_DTO loai)
        {
            if(loai.TENLOAISP != null)
            {

                    LOAISANPHAM newItem = new LOAISANPHAM();
                    newItem.MALOAISP = taoMa(20);
                    newItem.TENLOAISP = loai.TENLOAISP;
                    db.LOAISANPHAMs.Add(newItem);
                    db.SaveChanges();
                    return newItem.MALOAISP;
                
            }
            return null;
        }


    }
}
