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
        public static Model1 dbContext = new Model1();

        public static List<NguoiDung_DTO> LayDuLieu()
        {

            List<NguoiDung_DTO> list = new List<NguoiDung_DTO>();
            

            try
            {
                dbContext.NGUOIDUNGs.ToList().ForEach(n =>
                {
                    if(n!=null)
                    {
                        NguoiDung_DTO newP = new NguoiDung_DTO();
                        newP.MANGUOIDUNG = n.MANGUOIDUNG;
                        newP.TENNGUOIDUNG = n.TENNGUOIDUNG;
                        newP.TENDANGNHAP = n.TENDANGNHAP;
                        newP.MATKHAU = n.MATKHAU;
                        newP.MACHUCVU = n.MACHUCVU;
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
    }
}
