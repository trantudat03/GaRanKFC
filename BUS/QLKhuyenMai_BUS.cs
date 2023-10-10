using DAO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace BUS
{
    public class QLKhuyenMai_BUS
    {
        public static Model1 db = new Model1();
        public static List<KhuyenMai_DTO> listKM = new List<KhuyenMai_DTO>();

        public static List<KhuyenMai_DTO> layDuLieu()
        {
            if(listKM.Count > 0) 
            {
                return listKM;
            }
            else
            {
                db.KHUYENMAIs.ToList().ForEach(k =>
                {
                    KhuyenMai_DTO item  = new KhuyenMai_DTO();  
                    item.MAKHUYENMAI = k.MAKHUYENMAI;
                    item.TENKHUYENMAI = k.TENKHUYENMAI;
                    item.PHANTRAM = (int)k.PHANTRAM;
                    item.SOTIENGIAM = (int)k.SOTIENGIAM;
                    item.SOTIENGIAMTOIDA = (int)k.SOTIENGIAMTOIDA;
                    item.MADIEUKIEN = k.MADIEUKIEN;
                    item.DIEUKIEN.TENDIEUKIEN = k.DIEUKIEN.TENDIEUKIEN;
                    item.DIEUKIEN.MADIEUKIEN = k.MADIEUKIEN;
                    if(item.MAKHUYENMAI != "")
                    listKM.Add(item);
                });
            }
            return listKM;
        }

        public static List<KhuyenMai_DTO> layKMTheoDieuKien(KhachHang_DTO kh, int giaTriDonHang)
        {
            List<KhuyenMai_DTO> listTheoDieuKien = new List<KhuyenMai_DTO>();
            if (kh.DIEM >=0 && giaTriDonHang >=0)
            {
                
                if (listKM.Count > 0)
                {
                    //KhuyenMai_DTO item = new KhuyenMai_DTO();
                    listKM.ForEach(k =>
                    {
                        if(kh.DIEM >= k.DIEUKIEN.DIEMTOITHIEU && giaTriDonHang >= k.DIEUKIEN.GIATRIDONHANG)
                        {
                            listTheoDieuKien.Add(k);
                        }
                    });
                }
                else
                {
                    db.KHUYENMAIs.ToList().ForEach(k =>
                    {
                        if(kh.DIEM >= k.DIEUKIEN.DIEMTOITHIEU && giaTriDonHang >= k.DIEUKIEN.GIATRIDONHANG)
                        {
                            KhuyenMai_DTO item = new KhuyenMai_DTO();
                            item.MAKHUYENMAI = k.MAKHUYENMAI;
                            item.TENKHUYENMAI = k.TENKHUYENMAI;
                            item.PHANTRAM = (int)k.PHANTRAM;
                            item.SOTIENGIAM = (int)k.SOTIENGIAM;
                            item.SOTIENGIAMTOIDA = (int)k.SOTIENGIAMTOIDA;
                            item.MADIEUKIEN = k.MADIEUKIEN;
                            item.DIEUKIEN.TENDIEUKIEN = k.DIEUKIEN.TENDIEUKIEN;
                            item.DIEUKIEN.MADIEUKIEN = k.MADIEUKIEN;
                            if (item.MAKHUYENMAI != "")
                                listTheoDieuKien.Add(item);
                        }
                    });
                }
            }
            else
            {
                if(kh.MAKHACHHANG == "")
                {
                    if (listKM.Count > 0)
                    {
                        //KhuyenMai_DTO item = new KhuyenMai_DTO();
                        listKM.ForEach(k =>
                        {
                            if (k.DIEUKIEN.DIEMTOITHIEU == 0 && giaTriDonHang >= k.DIEUKIEN.GIATRIDONHANG)
                            {
                                listTheoDieuKien.Add(k);
                            }
                        });
                    }
                    else
                    {
                        db.KHUYENMAIs.ToList().ForEach(k =>
                        {
                            if (k.DIEUKIEN.DIEMTOITHIEU == 0 && giaTriDonHang >= k.DIEUKIEN.GIATRIDONHANG)
                            {
                                KhuyenMai_DTO item = new KhuyenMai_DTO();
                                item.MAKHUYENMAI = k.MAKHUYENMAI;
                                item.TENKHUYENMAI = k.TENKHUYENMAI;
                                item.PHANTRAM = (int)k.PHANTRAM;
                                item.SOTIENGIAM = (int)k.SOTIENGIAM;
                                item.SOTIENGIAMTOIDA = (int)k.SOTIENGIAMTOIDA;
                                item.MADIEUKIEN = k.MADIEUKIEN;
                                item.DIEUKIEN.TENDIEUKIEN = k.DIEUKIEN.TENDIEUKIEN;
                                item.DIEUKIEN.MADIEUKIEN = k.MADIEUKIEN;
                                if (item.MAKHUYENMAI != "")
                                    listTheoDieuKien.Add(item);
                            }
                        });
                    }
                }
                    
                
            }
            return listTheoDieuKien;
        }
    }
}
