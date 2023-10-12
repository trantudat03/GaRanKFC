using DAO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace BUS
{
    public class QLChiTietThanhToan_BUS
    {
        public static Model1 db = new Model1();
        public static List<ChiTietThanhToan_DTO> listCTTT = new List<ChiTietThanhToan_DTO>();

        public static int themChiTietThanhToan(string maDonHang, string maPhuongThuc, int soTien)
        {
            if(maDonHang != string.Empty && maPhuongThuc != string.Empty && soTien > 0) 
            {
                CHITIETTHANHTOAN c = new CHITIETTHANHTOAN();
                c.SOTIENTRA = soTien;
                c.MADONHANG = maDonHang;
                c.MAPHUONGTHUC = maPhuongThuc;
                db.CHITIETTHANHTOANs.Add(c);
                db.SaveChanges();
                return 1;
            }
            return 0;
        }
    }
}
