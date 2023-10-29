using DAO.Models;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class QLDonChiTietDonHangHuy_BUS
    {
        public static Model1 db = new Model1();

        public static int themCTDHHuy(DonHangHuy_DTO dh, List<SanPham_DTO> listSp)
        {
            if(dh.MADONHANGHUY != string.Empty && listSp.Count> 0 && listSp.Count == dh.SOLUONGSP)
            {
                listSp.ForEach(s =>
                {
                    CHITIETDONHANGHUY add = new CHITIETDONHANGHUY();
                    add.MASANPHAM = s.MASANPHAM;
                    add.MADONHANGHUY = dh.MADONHANGHUY;
                    add.SOLUONG = s.SLORDER;
                    add.GIASANPHAM = s.GIASANPHAM;
                    db.CHITIETDONHANGHUYs.Add(add);
                    db.SaveChanges();
                });
                return 1;
            }

            return 0;
        }
    }
}
