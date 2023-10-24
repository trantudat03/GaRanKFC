using DAO.Models;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class QLTrangThai_BUS
    {
        public static Model1 db = new Model1();

        public static List<TrangThaiSP_DTO> layDuLieu()
        {
            List<TrangThaiSP_DTO> list = new List<TrangThaiSP_DTO> ();

            db.TRANGTHAIs.ToList().ForEach(t =>
            {
                TrangThaiSP_DTO item = new TrangThaiSP_DTO();
                item.MATRANGTHAI = t.MATRANGTHAI;
                item.TENTRANGTHAI = t.TENTRANGTHAI;
                list.Add(item);
            });

            return list;
        }
    }
}
