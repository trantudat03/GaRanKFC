using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO.Models;
using DTO;
namespace BUS
{
    public class QLChiTietDonHang_BUS
    {
        public static List<ChiTietDonHang_DTO> listCT = new List<ChiTietDonHang_DTO>();
        public static Model1 db = new Model1();

        public static int themChiTietDon(List<SanPham_DTO> listOrder, string maDonHang) 
        {
            if(listOrder.Count > 0 && maDonHang!=string.Empty)
            {
                listOrder.ForEach(s =>
                {
                    CHITIETDONHANG item = new CHITIETDONHANG();
                    item.MADONHANG = maDonHang;
                    item.MASANPHAM = s.MASANPHAM;
                    item.SOLUONG = s.SLORDER;
                    item.GIASANPHAM = s.GIASANPHAM;
                    db.CHITIETDONHANGs.Add(item);
                    db.SaveChanges();
                });
                return 1;
            }
            return 0;
        }
    }
}
