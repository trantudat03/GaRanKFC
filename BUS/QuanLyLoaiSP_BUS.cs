using DAO.Models;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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


            var query = from loaiSanPham in db.LOAISANPHAMs
                         join sanPham in db.SANPHAMs on loaiSanPham.MALOAISP equals sanPham.MALOAISP into sanPhamGroup
                         select new
                         {
                             MALOAISP = loaiSanPham.MALOAISP,
                             TENLOAISP = loaiSanPham.TENLOAISP,
                             TONGXUATHIEN = sanPhamGroup.Count()
                         };

            

            foreach (var result in query)
            {
                LoaiSanPham_DTO item = new LoaiSanPham_DTO();
                item.MALOAISP = result.MALOAISP;
                item.TENLOAISP = result.TENLOAISP;
                item.TONGSOLUON = result.TONGXUATHIEN;
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


        public static string suaLoaiSp(LoaiSanPham_DTO loai)
        {
            if(loai.MALOAISP != null)
            {
                LOAISANPHAM update = db.LOAISANPHAMs.Find(loai.MALOAISP);

                if (update != null)
                {
                    update.TENLOAISP = loai.TENLOAISP;
                    db.SaveChanges();
                    return loai.MALOAISP;
                }
                
            }
            return null;
            
        }

        public static string kiemTraCoTheXoa(LoaiSanPham_DTO loai)
        {
            SANPHAM item = db.SANPHAMs.ToList().Find(i => i.MALOAISP == loai.MALOAISP);
            if (item!=null)
            {
                return null;
            }
            else
            {
                return loai.MALOAISP;
            }
            
        }

        public static int xoaLoaiSanPham(string maLoai)
        {
            if(!string.IsNullOrEmpty(maLoai))
            {
                LOAISANPHAM delete = db.LOAISANPHAMs.Find(maLoai);
                db.LOAISANPHAMs.Remove(delete);
                db.SaveChanges();
                return 1;
            }
            return 0;
        }

    }
}
