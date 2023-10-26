using DAO.Models;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class QLChucVu_BUS
    {
        public static Model1 db = new Model1();

        public static List<ChucVu_DTO> listChucVu = new List<ChucVu_DTO>();

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

        public static List<ChucVu_DTO> layDuLieu()
        {
            listChucVu.Clear();

            db.CHUCVUs.ToList().ForEach(c =>
            {
                ChucVu_DTO item = new ChucVu_DTO();
                item.MACHUCVU = c.MACHUCVU;
                item.TENCHUCVU = c.TENCHUCVU;
                listChucVu.Add(item);
            });
            return listChucVu;
        }

        public static List<ChucVu_DTO> layDuLieuKemSoNhanVien()
        {
            listChucVu.Clear();
            var query = from cv in db.CHUCVUs
                        join nd in db.NGUOIDUNGs on cv.MACHUCVU equals nd.MACHUCVU into gj
                        select new
                        {
                            cv.MACHUCVU,
                            cv.TENCHUCVU,
                            SOLUONGNGUOIDUNG = gj.Count()
                        };

            foreach (var result in query)
            {
                ChucVu_DTO item = new ChucVu_DTO();
                item.MACHUCVU = result.MACHUCVU;
                item.TENCHUCVU = result.TENCHUCVU;
                item.SONHANVIEN = result.SOLUONGNGUOIDUNG;
                listChucVu.Add(item);
            }
            return listChucVu;
        }

        public static ChucVu_DTO themChucVu(ChucVu_DTO add)
        {
            if(add.TENCHUCVU != string.Empty)
            {
                CHUCVU item = new CHUCVU();
                item.MACHUCVU = taoMa(20);
                item.TENCHUCVU = add.TENCHUCVU;
                db.CHUCVUs.Add(item);
                db.SaveChanges();
                add.MACHUCVU = item.MACHUCVU;
                return add;
            }

            return null;
        }

        public static ChucVu_DTO suaChucVu(ChucVu_DTO item)
        {
            if(item.MACHUCVU != string.Empty)
            {
                CHUCVU update = db.CHUCVUs.Find(item.MACHUCVU);
                if(update!=null)
                {
                    update.TENCHUCVU = item.TENCHUCVU;
                    db.SaveChanges();
                    return item;
                }
            }

            return null;
        }


        public static bool kiemTraCoTheXoa(ChucVu_DTO item)
        {
            NGUOIDUNG user = db.NGUOIDUNGs.ToList().Find(n => n.MACHUCVU == item.MACHUCVU);
            if(user!=null)
            {
                return false;
            }
            return true;
        }

        public static ChucVu_DTO xoaChucVu(ChucVu_DTO item)
        {
            if(kiemTraCoTheXoa(item))
            {
                CHUCVU delete = db.CHUCVUs.Find(item.MACHUCVU);
                if(delete!=null)
                {
                    db.CHUCVUs.Remove(delete);
                    db.SaveChanges() ;
                    return item;
                }
            }
            return null;
        }
    }
}
