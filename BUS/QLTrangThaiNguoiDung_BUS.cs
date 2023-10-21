using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO.Models;
using DTO;

namespace BUS
{
    public class QLTrangThaiNguoiDung_BUS
    {
        public static Model1 db = new Model1();

        public static List<TrangThaiNguoiDung_DTO> listTrangThai = new List<TrangThaiNguoiDung_DTO>();
        public static List<TrangThaiNguoiDung_DTO> layDuLieu()
        {
            listTrangThai.Clear();
            db.TRANGTHAINGUOIDUNGs.ToList().ForEach(t =>
            {
                TrangThaiNguoiDung_DTO item = new TrangThaiNguoiDung_DTO();
                item.MATRANGTHAI = t.MATRANGTHAI;
                item.TENTRANGTHAI = t.TENTRANGTHAI;
                listTrangThai.Add(item);
            });
            return listTrangThai;
        }
    }
}
