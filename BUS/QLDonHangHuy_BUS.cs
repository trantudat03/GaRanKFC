using DAO.Models;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class QLDonHangHuy_BUS
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
        public static DonHangHuy_DTO themDonHangHuy(DonHangHuy_DTO item, List<SanPham_DTO> listSP)
        {
            
            if(item.MANGUOIDUNG != string.Empty && item.LYDO != string.Empty)
            {
                DONHANGHUY add = new DONHANGHUY();
                add.MANGUOIDUNG = item.MANGUOIDUNG;
                add.MAKHACHHANG = item.MAKHACHHANG;
                add.MADONHANGHUY = taoMa(24);
                add.LYDO = item.LYDO;
                add.SOLUONGSP = item.SOLUONGSP;
                add.THOIGIAN = item.THOIGIAN;
                add.TONGGIA = item.TONGGIA;
                item.MADONHANGHUY = add.MADONHANGHUY;
                db.DONHANGHUYs.Add(add);
                db.SaveChanges();
                QLDonChiTietDonHangHuy_BUS.themCTDHHuy(item, listSP);
                return item;
            }
            return null;
        }
    }
}
