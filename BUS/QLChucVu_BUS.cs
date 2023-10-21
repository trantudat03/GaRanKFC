using DAO.Models;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class QLChucVu_BUS
    {
        public static Model1 db = new Model1();

        public static List<ChucVu_DTO> listChucVu = new List<ChucVu_DTO>();

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
    }
}
