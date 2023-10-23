using DAO.Models;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class QLDieuKien_BUS
    {
        public static Model1 db = new Model1();
        public static List<DieuKien_DTO> listDieuKien = new List<DieuKien_DTO>();

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

        public static List<DieuKien_DTO> layDuLieu()
        {
            try
            {
                listDieuKien.Clear();
                db.DIEUKIENs.ToList().ForEach(d =>
                {
                    DieuKien_DTO item = new DieuKien_DTO();
                    if (d != null && d.MADIEUKIEN != "0")
                    {
                        item.MADIEUKIEN = d.MADIEUKIEN;
                        item.TENDIEUKIEN = d.TENDIEUKIEN;
                        item.DIEMTOITHIEU = (int)d.DIEMTOITHIEU;
                        item.GIATRIDONHANG = (int)d.GIATRIDONHANG;

                        listDieuKien.Add(item);
                    }
                });
            }
            catch
            {
                return listDieuKien;
            }
            

            return listDieuKien;
        }

        public static DieuKien_DTO themDieuKien(DieuKien_DTO add)
        {
            try
            {
                if (add.TENDIEUKIEN != string.Empty)
                {
                    DIEUKIEN item = new DIEUKIEN();
                    item.MADIEUKIEN = taoMa(10);
                    item.TENDIEUKIEN = add.TENDIEUKIEN;
                    item.DIEMTOITHIEU = add.DIEMTOITHIEU;
                    item.GIATRIDONHANG = add.GIATRIDONHANG;
                    db.DIEUKIENs.Add(item);
                    db.SaveChanges();
                    add.MADIEUKIEN = item.MADIEUKIEN;
                    return add;
                }
            }
            catch
            {
                return null;
            }
            
            return null;
        }

        public static DieuKien_DTO suaDieuKien(DieuKien_DTO item)
        {
            if(item != null)
            {
                try
                {
                    DIEUKIEN update = db.DIEUKIENs.Find(item.MADIEUKIEN);
                    if (update != null)
                    {
                        update.TENDIEUKIEN = item.TENDIEUKIEN;
                        update.DIEMTOITHIEU = item.DIEMTOITHIEU;
                        update.GIATRIDONHANG = item.GIATRIDONHANG;
                        db.SaveChanges();
                        return item;
                    }
                }
                catch
                {
                    return null;
                }
                
            }
            return null;
        }

        public static bool kiemTraCoTheXoa(DieuKien_DTO item)
        {
            if(item!=null)
            {
                KHUYENMAI km = db.KHUYENMAIs.ToList().Find(k => k.MADIEUKIEN == item.MADIEUKIEN);
                if(km ==  null)
                {
                    return true;
                }

            }
            return false;
        }

        public static int xoaDieuKien(DieuKien_DTO item)
        {

            if(item!=null)
            {
                if (kiemTraCoTheXoa(item))
                {
                    DIEUKIEN delete = db.DIEUKIENs.Find(item.MADIEUKIEN);
                    if(delete != null)
                    {
                        db.DIEUKIENs.Remove(delete);
                        db.SaveChanges();
                        return 1;
                    }
                }
                
            }
            return 0;
        }


        public static List<DieuKien_DTO> layThemSoLuongKhuyenMai()
        {
            listDieuKien.Clear();
            try
            {

                var query = from dieukien in db.DIEUKIENs
                            join khuyenmai in db.KHUYENMAIs on dieukien.MADIEUKIEN equals khuyenmai.MADIEUKIEN into khuyenmaiGroup
                            select new
                            {
                                DieuKien = dieukien,
                                SoLuongKhuyenMai = khuyenmaiGroup.Count()
                            };

                foreach (var result in query)
                {
                    DieuKien_DTO item = new DieuKien_DTO();
                    item.MADIEUKIEN = result.DieuKien.MADIEUKIEN;
                    item.TENDIEUKIEN = result.DieuKien.TENDIEUKIEN;
                    item.DIEMTOITHIEU = (int)result.DieuKien.DIEMTOITHIEU;
                    item.GIATRIDONHANG = (int)result.DieuKien.GIATRIDONHANG;
                    item.SOKHUYENMAI = result.SoLuongKhuyenMai;
                    listDieuKien.Add(item);  
                }
            }catch
            {
                return listDieuKien;
            }

            return listDieuKien;
        }

    }
}
