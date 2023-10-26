using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO.Models;
using DTO;
using static System.Data.Entity.Infrastructure.Design.Executor;

namespace BUS
{
    public class QLKhachHang_BUS
    {
        public static Model1 db = new Model1();


        public static List<KhachHang_DTO> listKH = new List<KhachHang_DTO>();


        public static List<KhachHang_DTO> layDuLieu()
        {
            listKH.Clear();
            if(db.KHACHHANGs != null)
            {
                db.KHACHHANGs.ToList().ForEach(k =>
                {
                    if(k!=null && k.MAKHACHHANG != "0" && k.TENKHACHHANG != string.Empty)
                    {
                        KhachHang_DTO khAdd = new KhachHang_DTO();
                        khAdd.MAKHACHHANG = k.MAKHACHHANG;
                        khAdd.SODIENTHOAI = k.SODIENTHOAI;
                        khAdd.TENKHACHHANG = k.TENKHACHHANG;
                        khAdd.DIEM = (int)k.DIEM;
                        listKH.Add(khAdd);
                    }
                });
            }

            return listKH;
        }

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

        public static int themKhachHang(KhachHang_DTO khAdd)
        {

            if (khAdd.SODIENTHOAI != "")
            {

                KHACHHANG find = db.KHACHHANGs.Where(k => k.SODIENTHOAI == khAdd.SODIENTHOAI).FirstOrDefault();
                if (find == null)
                {
                    khAdd.MAKHACHHANG = taoMa(10);
                    khAdd.DIEM = 0;
                    listKH.Add(khAdd);
                    KHACHHANG kdb = new KHACHHANG();
                    kdb.MAKHACHHANG = khAdd.MAKHACHHANG; kdb.DIEM = 0;
                    kdb.TENKHACHHANG = khAdd.TENKHACHHANG;
                    kdb.SODIENTHOAI = khAdd.SODIENTHOAI;
                    db.KHACHHANGs.Add(kdb);
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
        public static KhachHang_DTO timKhachHang(string sdt)
        {
            KhachHang_DTO kh = new KhachHang_DTO();
           
            
                db.KHACHHANGs.ToList().ForEach(k =>
                {
                    if(k.SODIENTHOAI.Replace(" ", "").Equals(sdt.Replace(" ", "")))
                    {
                        kh.TENKHACHHANG=k.TENKHACHHANG;
                        kh.MAKHACHHANG = k.MAKHACHHANG;
                        kh.DIEM = (int)k.DIEM;
                        kh.SODIENTHOAI = k.SODIENTHOAI;
                        
                    }
                });
            return kh;
        }

        public static int capNhatDiem(KhachHang_DTO kh, int diemCong)
        {
            if(kh.MAKHACHHANG != "")
            {
                if(listKH.Count >0)
                {
                    KhachHang_DTO khUpDate = new KhachHang_DTO();
                    khUpDate = listKH.Find(k => k.MAKHACHHANG.Equals(kh.MAKHACHHANG));
                    if(khUpDate.MAKHACHHANG != "")
                    {
                        khUpDate.DIEM += diemCong;
                        KHACHHANG KhDb = db.KHACHHANGs.Where(k => k.MAKHACHHANG == khUpDate.MAKHACHHANG).FirstOrDefault();
                        if(KhDb != null)
                        {
                            KhDb.DIEM += diemCong;
                            db.SaveChanges();
                            return 1;
                        }
                    }
                }
                else
                {
                    KHACHHANG KhDb = db.KHACHHANGs.Where(k => k.MAKHACHHANG == kh.MAKHACHHANG).FirstOrDefault();
                    if (KhDb != null)
                    {
                        KhDb.DIEM += diemCong;
                        db.SaveChanges();
                        return 1;
                    }
                }
            }

            return 0;
        }

        public static KhachHang_DTO suaKhachHang(KhachHang_DTO item)
        {
            KHACHHANG update = db.KHACHHANGs.Find(item.MAKHACHHANG);
            try
            {
                if (update != null)
                {
                    KHACHHANG check = db.KHACHHANGs.Where(k => k.SODIENTHOAI == item.SODIENTHOAI && k.MAKHACHHANG != update.MAKHACHHANG).FirstOrDefault();
                    if (check == null)
                    {
                        update.TENKHACHHANG = item.TENKHACHHANG;
                        update.DIEM = item.DIEM;
                        update.SODIENTHOAI = item.SODIENTHOAI;
                        db.SaveChanges();
                        return item;
                    }
                }
            }
            catch
            {
                return null;
            }
            
            return null;
        }

        public static bool kiemTraCoTheXoa(KhachHang_DTO item)
        {
            DONHANG check1 = db.DONHANGs.Where(d => d.MAKHACHHANG == item.MAKHACHHANG).FirstOrDefault();
            if(check1 == null)
            {
                DONHANGHUY check2 = db.DONHANGHUYs.Where(d => d.MAKHACHHANG == item.MAKHACHHANG).FirstOrDefault();
                if (check2 == null)
                    return true;
            }
            return false;
        }

        public static KhachHang_DTO xoaKhachHang(KhachHang_DTO item)
        {
            if(kiemTraCoTheXoa(item))
            {
                KHACHHANG delete = db.KHACHHANGs.Find(item.MAKHACHHANG);
                if(delete != null)
                {
                    db.KHACHHANGs.Remove(delete);
                    db.SaveChanges();
                    return null;
                }
            }

            return item;
        }
    }
}
