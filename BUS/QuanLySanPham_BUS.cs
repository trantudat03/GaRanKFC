using DAO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Globalization;
using System.Data.Entity;

namespace BUS
{
    public class QuanLySanPham_BUS
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

        
        public static List<SanPham_DTO> layDuLieu()
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
                sp.MATRANGTHAI = s.MATRANGTHAI;
                sp.TRANGTHAI.TENTRANGTHAI = s.TRANGTHAI.TENTRANGTHAI;
                sp.TRANGTHAI.MATRANGTHAI = s.TRANGTHAI.MATRANGTHAI;
                list.Add(sp);
            });

            return list;
        }

        private static string XoaDau(string text)
        {
            string formD = text.Normalize(NormalizationForm.FormD);
            StringBuilder sb = new StringBuilder();
            // ham loai bo dau
            foreach (char ch in formD)
            {
                UnicodeCategory category = CharUnicodeInfo.GetUnicodeCategory(ch);
                if (category != UnicodeCategory.NonSpacingMark)
                {
                    sb.Append(ch);
                }
            }

            return sb.ToString().Normalize(NormalizationForm.FormC);
        }

        public static List<SanPham_DTO> timTheoTen(string strSearch)
        {
            string tenSearch = XoaDau(strSearch);
            //string tenSP = RemoveDiacritics(sp.TENSANPHAM);

            List<SanPham_DTO> list = new List<SanPham_DTO>();

            db.SANPHAMs.ToList().ForEach(s =>
            {
                string tenSP = XoaDau(s.TENSANPHAM);
                if(tenSP.IndexOf(tenSearch, StringComparison.OrdinalIgnoreCase) >= 0)
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
                    sp.TRANGTHAI.TENTRANGTHAI = s.TRANGTHAI.TENTRANGTHAI;
                    sp.TRANGTHAI.MATRANGTHAI = s.TRANGTHAI.MATRANGTHAI;
                    list.Add(sp);
                }
                
            });

            return list;
        }

        public static int themSanPham(SanPham_DTO sanpham)
        {
            try
            {
                SANPHAM newSP = new SANPHAM();
                newSP.MASANPHAM = taoMa(25);
                newSP.TENSANPHAM = sanpham.TENSANPHAM;
                newSP.THOIHAN = sanpham.THOIHAN;
                newSP.ANHSANPHAM = sanpham.ANHSANPHAM;
                newSP.MATRANGTHAI = sanpham.MATRANGTHAI;
                newSP.SOLUONG = 0;
                newSP.GIASANPHAM = sanpham.GIASANPHAM;
                newSP.MALOAISP = sanpham.MALOAISP;
                SANPHAM check2 = db.SANPHAMs.Find(newSP.MASANPHAM);
                if (check2 != null)
                {
                    newSP.MASANPHAM = taoMa(25);
                    db.SANPHAMs.Add(newSP);
                    db.SaveChanges();
                    return 1;
                }
                db.SANPHAMs.Add(newSP);
                db.SaveChanges();
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public static int suaSanPham(SanPham_DTO sp)
        {
            if(sp.MASANPHAM!= null)
            {
                SANPHAM update = db.SANPHAMs.Find(sp.MASANPHAM);
                if (update != null)
                {
                    update.TENSANPHAM = sp.TENSANPHAM;
                    update.MALOAISP = sp.MALOAISP;
                    update.GIASANPHAM = sp.GIASANPHAM;
                    update.THOIHAN = sp.THOIHAN;
                    update.MATRANGTHAI = sp.MATRANGTHAI;
                    update.ANHSANPHAM = sp.ANHSANPHAM;
                    db.SaveChanges();
                    return 1;
                }
            }
            

            return 0;
        }

        public static string kiemTraSanPhamCoTheXoa(SanPham_DTO sp)
        {
            try
            {
                if (sp.MASANPHAM != null)
                {
                    SANPHAM delete = db.SANPHAMs.Find(sp.MASANPHAM);
                    CHITIETDONHANG detail = new CHITIETDONHANG();
                    if (delete != null)
                    {

                        detail = delete.CHITIETDONHANGs.FirstOrDefault();
                        if (detail == null)
                        {
                            CHITIETDONHANGHUY detailHuy = delete.CHITIETDONHANGHUYs.FirstOrDefault();
                            if (detailHuy == null)
                            {
                                return delete.MASANPHAM;
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

                }
                return null;
            }catch
            {
                return null;
            }
            
        }

        public static int xoaSanPham(string maSanPham)
        {
            try
            {
                SANPHAM delete = db.SANPHAMs.Find(maSanPham);
                if (delete != null)
                {
                    db.SANPHAMs.Remove(delete);
                    db.SaveChanges();
                    return 1;
                }
                return 0;
            }catch { return 0; }
        }

        
    }
}
