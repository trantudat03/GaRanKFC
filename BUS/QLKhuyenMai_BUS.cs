using DAO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Globalization;

namespace BUS
{
    public class QLKhuyenMai_BUS
    {
        public static Model1 db = new Model1();
        public static List<KhuyenMai_DTO> listKM = new List<KhuyenMai_DTO>();

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

        public static List<KhuyenMai_DTO> layDuLieu()
        {
            listKM.Clear();
            try
            {
                db.KHUYENMAIs.ToList().ForEach(k =>
                {
                    KhuyenMai_DTO item = new KhuyenMai_DTO();
                    item.MAKHUYENMAI = k.MAKHUYENMAI;
                    item.TENKHUYENMAI = k.TENKHUYENMAI;
                    item.PHANTRAM = (int)k.PHANTRAM;
                    item.SOTIENGIAM = (int)k.SOTIENGIAM;
                    item.SOTIENGIAMTOIDA = (int)k.SOTIENGIAMTOIDA;
                    item.MADIEUKIEN = k.MADIEUKIEN;
                    item.DIEUKIEN.TENDIEUKIEN = k.DIEUKIEN.TENDIEUKIEN;
                    item.DIEUKIEN.MADIEUKIEN = k.MADIEUKIEN;
                    item.NGAYBATDAU = k.NGAYBATDAU.Value.ToString("dd-MM-yyyy");
                    item.NGAYKETTHUC = k.NGAYKETTHUC.Value.ToString("dd-MM-yyyy");
                    if (item.MAKHUYENMAI != "")
                        listKM.Add(item);
                });
            }
            catch
            {
                return listKM;
            }
                
           
            return listKM;
        }

        public static List<KhuyenMai_DTO> layKMTheoDieuKien(KhachHang_DTO kh, int giaTriDonHang)
        {
            List<KhuyenMai_DTO> listTheoDieuKien = new List<KhuyenMai_DTO>();

            db.KHUYENMAIs.ToList().ForEach(k =>
            {
                if(kh.MAKHACHHANG==string.Empty)
                {
                    if(k.DIEUKIEN.DIEMTOITHIEU ==0 && k.DIEUKIEN.GIATRIDONHANG <= giaTriDonHang && k.MAKHUYENMAI !="0" && k.TENKHUYENMAI!= string.Empty)
                    {
                        KhuyenMai_DTO item = new KhuyenMai_DTO();
                        item.MAKHUYENMAI = k.MAKHUYENMAI;
                        item.TENKHUYENMAI = k.TENKHUYENMAI;
                        item.SOTIENGIAMTOIDA = (int)k.SOTIENGIAMTOIDA;
                        item.SOTIENGIAM = (int)k.SOTIENGIAM;
                        item.PHANTRAM = (int)k.PHANTRAM;
                        listTheoDieuKien.Add(item);
                    }  
                }
                else
                {
                    if(kh.DIEM >= k.DIEUKIEN.DIEMTOITHIEU && giaTriDonHang>= k.DIEUKIEN.GIATRIDONHANG && k.MAKHUYENMAI != "0" && k.TENKHUYENMAI != string.Empty)
                    {
                        KhuyenMai_DTO item = new KhuyenMai_DTO();
                        item.MAKHUYENMAI = k.MAKHUYENMAI;
                        item.TENKHUYENMAI = k.TENKHUYENMAI;
                        item.SOTIENGIAMTOIDA = (int)k.SOTIENGIAMTOIDA;
                        item.SOTIENGIAM = (int)k.SOTIENGIAM;
                        item.PHANTRAM = (int)k.PHANTRAM;
                        listTheoDieuKien.Add(item);
                    }
                }
            });

            return listTheoDieuKien;
        }

        public static string themKhuyenMai(KhuyenMai_DTO add)
        {
            KHUYENMAI check = db.KHUYENMAIs.Find(add.MAKHUYENMAI);
            try
            {
                if (check == null)
                {
                    KHUYENMAI item = new KHUYENMAI();
                    item.MAKHUYENMAI = "KM" + taoMa(6);
                    item.TENKHUYENMAI = add.TENKHUYENMAI;
                    item.PHANTRAM = add.PHANTRAM;
                    item.SOTIENGIAM = add.SOTIENGIAM;
                    item.SOTIENGIAMTOIDA = add.SOTIENGIAMTOIDA;
                    item.MADIEUKIEN = add.MADIEUKIEN;
                    string format = "yyyy-MM-dd";
                    DateTime dateTime = DateTime.ParseExact(add.NGAYBATDAU, format, CultureInfo.InvariantCulture);
                    item.NGAYBATDAU = dateTime;
                    item.NGAYKETTHUC = DateTime.ParseExact(add.NGAYKETTHUC, format, CultureInfo.InvariantCulture);
                    if(item.MAKHUYENMAI!= string.Empty)
                    {
                        db.KHUYENMAIs.Add(item);
                        db.SaveChanges();
                        return item.MAKHUYENMAI;
                    }
                    else
                    {
                        return null;
                    }
                    
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }
            

            
        }

        public static int suaKhuyenMai(KhuyenMai_DTO update)
        {
            if(update != null)
            {
                KHUYENMAI check = db.KHUYENMAIs.Find(update.MAKHUYENMAI);
                if(check != null)
                {
                    check.TENKHUYENMAI = update.TENKHUYENMAI;
                    check.PHANTRAM = update.PHANTRAM;
                    check.SOTIENGIAM = update.SOTIENGIAM;
                    check.SOTIENGIAMTOIDA = update.SOTIENGIAMTOIDA;
                    check.MADIEUKIEN = update.MADIEUKIEN;
                    string format = "yyyy-MM-dd";
                    DateTime dateTime = DateTime.ParseExact(update.NGAYBATDAU, format, CultureInfo.InvariantCulture);
                    check.NGAYBATDAU = dateTime;
                    check.NGAYKETTHUC = DateTime.ParseExact(update.NGAYKETTHUC, format, CultureInfo.InvariantCulture);
                    db.SaveChanges();
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            return 0;
        }

        public static string kiemTraCoTheXoa(string MaKhuyenMai)
        {
            if(MaKhuyenMai != null)
            {
                DONHANG dh = db.DONHANGs.ToList().Find(d => d.MAKHUYENMAI == MaKhuyenMai);
                if (dh == null)
                {
                    return MaKhuyenMai;
                }
            }
            return null;
        }

        public static int xoaKhuyenMai(string maKhuyenMai)
        {
            if(kiemTraCoTheXoa(maKhuyenMai) != null)
            {
                if (maKhuyenMai != string.Empty)
                {
                    KHUYENMAI delete = db.KHUYENMAIs.Find(maKhuyenMai);
                    if (delete != null)
                    {
                        db.KHUYENMAIs.Remove(delete);
                        db.SaveChanges();
                        return 1;
                    }
                }
            }
            
            return 0;
        }
    }
}
