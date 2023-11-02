using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO.Models;
using DTO;
using Microsoft.SqlServer.Server;

namespace BUS
{
    public class QLDonHang_BUS
    {
        public static Model1 db = new Model1();
        public static List<DonHang_DTO> listDonHang = new List<DonHang_DTO>();

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

        public static int tinhSoDonTheoNgay(string date)
        {
            int length = 0;

            db.DONHANGs.ToList().ForEach(d =>{
                //DateTime dateTime = new DateTime();
                //DateTime.TryParseExact(date, "yyyy-MM-dd HH:mm:ss", null, System.Globalization.DateTimeStyles.None, out dateTime);
                if (d.THOIGIAN.Value.ToString("yyyy-MM-dd").Equals(date))
                {
                    length++;
                }
            });

            return length;

        }
        public static string themDonHang(DonHang_DTO don)
        {
            if(don.MADONHANG != string.Empty)
            {
                
                    DONHANG i =new DONHANG();
                    i.MADONHANG = taoMa(20);
                    i.MANGUOIDUNG = don.MANGUOIDUNG;
                    i.MAKHUYENMAI = don.MAKHUYENMAI;
                    i.MAKHACHHANG = don.MAKHACHHANG;
                    i.TONGGIA = don.TONGGIA;
                    i.SOLUONGSP = don.SOLUONGSP;
                    i.GIATRIKHUYENMAI = don.SOTIENGIAM;
                    DateTime date;
                    DateTime.TryParseExact(don.THOIGIAN, "yyyy-MM-dd HH:mm:ss", null, System.Globalization.DateTimeStyles.None, out date);
                    i.THOIGIAN = date;
                    DateTime startDate;
                    DateTime.TryParseExact(don.THOIGIANBATDAU, "yyyy-MM-dd HH:mm:ss", null, System.Globalization.DateTimeStyles.None, out startDate);
                    i.THOIGIANBATDAU = startDate;
                    db.DONHANGs.Add(i);
                    db.SaveChanges();
                return i.MADONHANG;
            }
            return string.Empty;
        }

    }
}
