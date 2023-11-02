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

        public static List<DonHangHuy_DTO> layDuLieu()
        {
            List<DonHangHuy_DTO> list = new List<DonHangHuy_DTO> ();

            if(db.DONHANGHUYs.Count()>0 )
            {
                db.DONHANGHUYs.ToList().ForEach(d =>
                {
                    DonHangHuy_DTO item = new DonHangHuy_DTO();
                    if(d!= null)
                    {
                        item.MADONHANGHUY = d.MADONHANGHUY;
                        item.MANGUOIDUNG = d.MANGUOIDUNG;
                        item.MAKHACHHANG = d.MAKHACHHANG;
                        item.TONGGIA = (int)d.TONGGIA;
                        item.LYDO = d.LYDO;
                        item.THOIGIANBATDAU = (DateTime)d.THOIGIANBATDAU;
                        item.THOIGIAN = (DateTime)d.THOIGIAN;
                        item.SOLUONGSP = (int)d.SOLUONGSP;
                        item.TENNGUOIDUNG = d.NGUOIDUNG.TENNGUOIDUNG;
                        item.TENKHACHHANG = d.KHACHHANG.TENKHACHHANG;
                        
                        list.Add(item);
                    }
                });
            }
            return list;
        }

        public static List<DonHangHuy_DTO> layDuLieuTheoNgay(DateTime date)
        {
            List<DonHangHuy_DTO> list = new List<DonHangHuy_DTO>();
            if (db.DONHANGHUYs.Count() > 0)
            {
                db.DONHANGHUYs.ToList().ForEach(d =>
                {
                    DonHangHuy_DTO item = new DonHangHuy_DTO();
                    if (d != null && d.THOIGIAN.Value.Date == date.Date)
                    {
                        item.MADONHANGHUY = d.MADONHANGHUY;
                        item.MANGUOIDUNG = d.MANGUOIDUNG;
                        item.MAKHACHHANG = d.MAKHACHHANG;
                        item.TONGGIA = (int)d.TONGGIA;
                        item.LYDO = d.LYDO;
                        item.THOIGIANBATDAU = (DateTime)d.THOIGIANBATDAU;
                        item.THOIGIAN = (DateTime)d.THOIGIAN;
                        item.SOLUONGSP = (int)d.SOLUONGSP;
                        item.TENNGUOIDUNG = d.NGUOIDUNG.TENNGUOIDUNG;
                        item.TENKHACHHANG = d.KHACHHANG.TENKHACHHANG;

                        list.Add(item);
                    }
                });
            }

            return list;
        }

        public static List<DonHangHuy_DTO> layDuLieuTheoThang(DateTime date)
        {
            List<DonHangHuy_DTO> list = new List<DonHangHuy_DTO>();
            if (db.DONHANGHUYs.Count() > 0)
            {
                db.DONHANGHUYs.ToList().ForEach(d =>
                {
                    DonHangHuy_DTO item = new DonHangHuy_DTO();
                    if (d != null && d.THOIGIAN.Value.Month == date.Month && d.THOIGIAN.Value.Year == date.Year)
                    {
                        item.MADONHANGHUY = d.MADONHANGHUY;
                        item.MANGUOIDUNG = d.MANGUOIDUNG;
                        item.MAKHACHHANG = d.MAKHACHHANG;
                        item.TONGGIA = (int)d.TONGGIA;
                        item.LYDO = d.LYDO;
                        item.THOIGIANBATDAU = (DateTime)d.THOIGIANBATDAU;
                        item.THOIGIAN = (DateTime)d.THOIGIAN;
                        item.SOLUONGSP = (int)d.SOLUONGSP;
                        item.TENNGUOIDUNG = d.NGUOIDUNG.TENNGUOIDUNG;
                        item.TENKHACHHANG = d.KHACHHANG.TENKHACHHANG;

                        list.Add(item);
                    }
                });
            }

            return list;
        }

        public static List<DonHangHuy_DTO> layDuLieuTheoNam(DateTime date)
        {
            List<DonHangHuy_DTO> list = new List<DonHangHuy_DTO>();
            if (db.DONHANGHUYs.Count() > 0)
            {
                db.DONHANGHUYs.ToList().ForEach(d =>
                {
                    DonHangHuy_DTO item = new DonHangHuy_DTO();
                    if (d != null && d.THOIGIAN.Value.Year == date.Year)
                    {
                        item.MADONHANGHUY = d.MADONHANGHUY;
                        item.MANGUOIDUNG = d.MANGUOIDUNG;
                        item.MAKHACHHANG = d.MAKHACHHANG;
                        item.TONGGIA = (int)d.TONGGIA;
                        item.LYDO = d.LYDO;
                        item.THOIGIANBATDAU = (DateTime)d.THOIGIANBATDAU;
                        item.THOIGIAN = (DateTime)d.THOIGIAN;
                        item.SOLUONGSP = (int)d.SOLUONGSP;
                        item.TENNGUOIDUNG = d.NGUOIDUNG.TENNGUOIDUNG;
                        item.TENKHACHHANG = d.KHACHHANG.TENKHACHHANG;

                        list.Add(item);
                    }
                });
            }

            return list;
        }

        public static List<DonHangHuy_DTO> layDuLieuTheoKhoang(DateTime dateFrom, DateTime dateTo)
        {
            List<DonHangHuy_DTO> list = new List<DonHangHuy_DTO>();
            if (db.DONHANGHUYs.Count() > 0)
            {
                db.DONHANGHUYs.ToList().ForEach(d =>
                {
                    DonHangHuy_DTO item = new DonHangHuy_DTO();
                    if (d != null && d.THOIGIAN.Value.Date >= dateFrom.Date && d.THOIGIAN.Value.Date <= dateTo.Date)
                    {
                        item.MADONHANGHUY = d.MADONHANGHUY;
                        item.MANGUOIDUNG = d.MANGUOIDUNG;
                        item.MAKHACHHANG = d.MAKHACHHANG;
                        item.TONGGIA = (int)d.TONGGIA;
                        item.LYDO = d.LYDO;
                        item.THOIGIANBATDAU = (DateTime)d.THOIGIANBATDAU;
                        item.THOIGIAN = (DateTime)d.THOIGIAN;
                        item.SOLUONGSP = (int)d.SOLUONGSP;
                        item.TENNGUOIDUNG = d.NGUOIDUNG.TENNGUOIDUNG;
                        item.TENKHACHHANG = d.KHACHHANG.TENKHACHHANG;

                        list.Add(item);
                    }
                });
            }

            return list;
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
                add.THOIGIANBATDAU = item.THOIGIANBATDAU;
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
