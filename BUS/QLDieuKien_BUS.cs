using DAO.Models;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class QLDieuKien_BUS
    {
        public static Model1 db = new Model1();
        public static List<DieuKien_DTO> listDieuKien = new List<DieuKien_DTO>();

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

    }
}
