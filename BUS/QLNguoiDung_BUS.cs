using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DAO.Models;
using DTO;
namespace BUS
{
    public class QLNguoiDung_BUS
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

        public static List<NguoiDung_DTO> LayDuLieu()
        {

            List<NguoiDung_DTO> list = new List<NguoiDung_DTO>();
            

            try
            {
                db.NGUOIDUNGs.ToList().ForEach(n =>
                {
                    if(n!=null)
                    {
                        NguoiDung_DTO newP = new NguoiDung_DTO();
                        newP.MANGUOIDUNG = n.MANGUOIDUNG;
                        newP.TENNGUOIDUNG = n.TENNGUOIDUNG;
                        newP.TENDANGNHAP = n.TENDANGNHAP;
                        newP.MATKHAU = n.MATKHAU;
                        newP.MACHUCVU = n.MACHUCVU;
                        newP.TENCHUCVU = n.CHUCVU.TENCHUCVU;
                        newP.MATRANGTHAI = n.MATRANGTHAI;
                        newP.TENTRANGTHAI = n.TRANGTHAINGUOIDUNG.TENTRANGTHAI;
                        newP.SODIENTHOAI = n.SODIENTHOAI;
                        newP.EMAIL = n.EMAIL;
                        
                        list.Add(newP);
                    }
                });
            }
            catch
            {
                return null;
            }

            return list;

        }

        public static string themNguoiDung(NguoiDung_DTO item)
        {
            if(item.TENNGUOIDUNG != string.Empty)
            {
                
                NGUOIDUNG add = new NGUOIDUNG();
                add = db.NGUOIDUNGs.ToList().Find(x => x.EMAIL == item.EMAIL);
                if(add == null)
                {
                    add = db.NGUOIDUNGs.ToList().Find(x=> x.SODIENTHOAI == item.SODIENTHOAI);
                    if(add == null)
                    {
                        if(add==null)
                        {
                            add = db.NGUOIDUNGs.ToList().Find(x => x.TENDANGNHAP == item.TENDANGNHAP);
                            if(add==null)
                            {
                                add = new NGUOIDUNG();
                                add.MANGUOIDUNG = taoMa(20);
                                add.TENNGUOIDUNG = item.TENNGUOIDUNG;
                                add.SODIENTHOAI = item.SODIENTHOAI;
                                add.EMAIL = item.EMAIL;
                                add.MACHUCVU = item.MACHUCVU;
                                add.MATRANGTHAI = item.MATRANGTHAI;
                                add.TENDANGNHAP = item.TENDANGNHAP;
                                add.MATKHAU = item.MATKHAU;
                                db.NGUOIDUNGs.Add(add);
                                db.SaveChanges();
                                return add.MANGUOIDUNG;
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
            return null;
        }

        public static int suaNguoiDung(NguoiDung_DTO item)
        {
            NGUOIDUNG update = db.NGUOIDUNGs.Find(item.MANGUOIDUNG);
            if (update != null)
            {
                NGUOIDUNG check = new NGUOIDUNG();
                check = db.NGUOIDUNGs.ToList().Find(x => x.EMAIL == item.EMAIL && x.MANGUOIDUNG != item.MANGUOIDUNG);
                if (check==null)
                {
                    check = db.NGUOIDUNGs.ToList().Find(x => x.TENDANGNHAP == item.TENDANGNHAP && x.MANGUOIDUNG != item.MANGUOIDUNG);
                    if (check == null)
                    {
                        check = db.NGUOIDUNGs.ToList().Find(x => x.SODIENTHOAI == item.SODIENTHOAI && x.MANGUOIDUNG != item.MANGUOIDUNG);
                        if(check == null)
                        {
                            update.TENNGUOIDUNG = item.TENNGUOIDUNG;
                            update.MACHUCVU = item.MACHUCVU;
                            update.SODIENTHOAI = item.SODIENTHOAI;
                            update.EMAIL = item.EMAIL;
                            update.TENDANGNHAP = item.TENDANGNHAP;
                            update.MATRANGTHAI = item.MATRANGTHAI;
                            update.MATKHAU = item.MATKHAU;
                            db.SaveChanges();
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }else
                    {
                        return 0;
                    }
                }
                else
                {
                    return 0;
                }
            }
            return 0;
        }

        public static int kiemTraCoTheXoa(NguoiDung_DTO item)
        {
            if(item!= null)
            {
                DONHANG dh = db.DONHANGs.ToList().Find(c=>c.MANGUOIDUNG == item.MANGUOIDUNG);
                if(dh == null)
                {
                    DONHANGHUY dhHuy = db.DONHANGHUYs.ToList().Find(c => c.MANGUOIDUNG == item.MANGUOIDUNG);
                    if(dhHuy == null)
                    {
                        return 1;
                    }
                }
            }

            return 0;
        }

        public static int xoaNguoiDung(NguoiDung_DTO item)
        {
            if(kiemTraCoTheXoa(item) ==1) {
                if (item != null)
                {
                    NGUOIDUNG delete = db.NGUOIDUNGs.Find(item.MANGUOIDUNG);
                    if (delete != null)
                    {
                        db.NGUOIDUNGs.Remove(delete);
                        db.SaveChanges();
                        return 1;
                    }
                }
            }
            
            return 0;
        }
    }
}
