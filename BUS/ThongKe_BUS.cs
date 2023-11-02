using DAO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

using System.Data.Entity;
using System.Runtime.Remoting.Contexts;
using DTO.ThongKe_DTO;

namespace BUS
{
    public class ThongKe_BUS
    {
        public static Model1 db = new Model1();
        public static List<DonHangThongKe_DTO> listThongKe = new List<DonHangThongKe_DTO>();
        public static List<SanPhamThongKe_DTO> listSp = new List<SanPhamThongKe_DTO>();

        public static List<DonHangThongKe_DTO> thongKeTheoNgay(DateTime date)
        {
            listThongKe.Clear();

            var query = from donhang in db.DONHANGs
                        join nguoidung in db.NGUOIDUNGs on donhang.MANGUOIDUNG equals nguoidung.MANGUOIDUNG
                        join khachhang in db.KHACHHANGs on donhang.MAKHACHHANG equals khachhang.MAKHACHHANG
                        join khuyenmai in db.KHUYENMAIs on donhang.MAKHUYENMAI equals khuyenmai.MAKHUYENMAI into kj
                        from khuyenmai in kj.DefaultIfEmpty()
                        where donhang.THOIGIAN.Value.Day == date.Day && donhang.THOIGIAN.Value.Month == date.Month && donhang.THOIGIAN.Value.Year == date.Year
                        select new
                        {
                            donhang.MADONHANG,
                            nguoidung.TENNGUOIDUNG,
                            khachhang.TENKHACHHANG,
                            khuyenmai.TENKHUYENMAI,
                            donhang.TONGGIA,
                            donhang.THOIGIAN,
                            donhang.GIATRIKHUYENMAI
                            };
                foreach (var result in query)
                {
                    DonHangThongKe_DTO item = new DonHangThongKe_DTO();
                    item.TENNGUOIDUNG = result.TENNGUOIDUNG;
                    item.MADONHANG = result.MADONHANG;
                    item.TONGGIA = (int)result.TONGGIA;
                    if (result.TENKHACHHANG == "")
                    {
                        item.TENKHACHHANG = "Không có tên KH";
                    }
                    else
                    {
                        item.TENKHACHHANG = result.TENKHACHHANG;
                    }
                    if (result.TENKHUYENMAI == "")
                    {
                        item.TENKHUYENMAI = "Không áp dụng KM";
                    }
                    else
                    {
                        item.TENKHUYENMAI = result.TENKHUYENMAI;
                    }
                    item.SOTIENGIAM = (int)result.GIATRIKHUYENMAI;
                    item.THOIGIAN = result.THOIGIAN.Value.ToString("hh:mm-dd/MM/yyyy");
                    listThongKe.Add(item);
                }
            
                return listThongKe;
        }

        public static List<DonHangThongKe_DTO> thongKeTheoThang(DateTime date)
        {
            listThongKe.Clear();
            
                var query = from donhang in db.DONHANGs
                            join nguoidung in db.NGUOIDUNGs on donhang.MANGUOIDUNG equals nguoidung.MANGUOIDUNG
                            join khachhang in db.KHACHHANGs on donhang.MAKHACHHANG equals khachhang.MAKHACHHANG
                            join khuyenmai in db.KHUYENMAIs on donhang.MAKHUYENMAI equals khuyenmai.MAKHUYENMAI into kj
                            from khuyenmai in kj.DefaultIfEmpty()
                            where donhang.THOIGIAN.Value.Month == date.Month && donhang.THOIGIAN.Value.Year == date.Year
                            select new
                            {
                                donhang.MADONHANG,
                                nguoidung.TENNGUOIDUNG,
                                khachhang.TENKHACHHANG,
                                khuyenmai.TENKHUYENMAI,
                                donhang.TONGGIA,
                                donhang.THOIGIAN,
                                donhang.GIATRIKHUYENMAI
                            };
                foreach (var result in query)
                {
                    DonHangThongKe_DTO item = new DonHangThongKe_DTO();
                    item.TENNGUOIDUNG = result.TENNGUOIDUNG;
                    item.MADONHANG = result.MADONHANG;
                    item.TONGGIA = (int)result.TONGGIA;
                    if (result.TENKHACHHANG == "")
                    {
                        item.TENKHACHHANG = "Không có tên KH";
                    }else
                    {
                        item.TENKHACHHANG = result.TENKHACHHANG;
                    }
                    if (result.TENKHUYENMAI == "")
                    {
                        item.TENKHUYENMAI = "Không áp dụng KM";
                    }else
                    {
                        item.TENKHUYENMAI = result.TENKHUYENMAI;
                    }
                    item.THOIGIAN = result.THOIGIAN.Value.ToString("hh:mm-dd/MM/yyyy");
                    item.SOTIENGIAM = (int)result.GIATRIKHUYENMAI;
                listThongKe.Add(item);
                }
            
            return listThongKe;
        }

        public static List<DonHangThongKe_DTO> thongKeTheoNam(DateTime date)
        {
            listThongKe.Clear();

            var query = from donhang in db.DONHANGs
                        join nguoidung in db.NGUOIDUNGs on donhang.MANGUOIDUNG equals nguoidung.MANGUOIDUNG
                        join khachhang in db.KHACHHANGs on donhang.MAKHACHHANG equals khachhang.MAKHACHHANG
                        join khuyenmai in db.KHUYENMAIs on donhang.MAKHUYENMAI equals khuyenmai.MAKHUYENMAI into kj
                        from khuyenmai in kj.DefaultIfEmpty()
                        where donhang.THOIGIAN.Value.Year == date.Year
                        select new
                        {
                            donhang.MADONHANG,
                            nguoidung.TENNGUOIDUNG,
                            khachhang.TENKHACHHANG,
                            khuyenmai.TENKHUYENMAI,
                            donhang.TONGGIA,
                            donhang.THOIGIAN,
                            donhang.GIATRIKHUYENMAI
                        };
            foreach (var result in query)
            {
                DonHangThongKe_DTO item = new DonHangThongKe_DTO();
                item.TENNGUOIDUNG = result.TENNGUOIDUNG;
                item.MADONHANG = result.MADONHANG;
                item.TONGGIA = (int)result.TONGGIA;
                if (result.TENKHACHHANG == "")
                {
                    item.TENKHACHHANG = "Không có tên KH";
                }
                else
                {
                    item.TENKHACHHANG = result.TENKHACHHANG;
                }
                if (result.TENKHUYENMAI == "")
                {
                    item.TENKHUYENMAI = "Không áp dụng KM";
                }
                else
                {
                    item.TENKHUYENMAI = result.TENKHUYENMAI;
                }
                item.THOIGIAN = result.THOIGIAN.Value.ToString("hh:mm-dd/MM/yyyy");
                item.SOTIENGIAM = (int)result.GIATRIKHUYENMAI;
                listThongKe.Add(item);
            }

            return listThongKe;
        }

        public static List<DonHangThongKe_DTO> thongKeTheoKhoangThoiGian(DateTime dateFrom, DateTime dateTo)
        {
            listThongKe.Clear();

            var query = from donhang in db.DONHANGs
                        join nguoidung in db.NGUOIDUNGs on donhang.MANGUOIDUNG equals nguoidung.MANGUOIDUNG
                        join khachhang in db.KHACHHANGs on donhang.MAKHACHHANG equals khachhang.MAKHACHHANG
                        join khuyenmai in db.KHUYENMAIs on donhang.MAKHUYENMAI equals khuyenmai.MAKHUYENMAI into kj
                        from khuyenmai in kj.DefaultIfEmpty()
                        where donhang.THOIGIAN.Value >= dateFrom && donhang.THOIGIAN.Value <= dateTo
                        select new
                        {
                            donhang.MADONHANG,
                            nguoidung.TENNGUOIDUNG,
                            khachhang.TENKHACHHANG,
                            khuyenmai.TENKHUYENMAI,
                            donhang.TONGGIA,
                            donhang.THOIGIAN,
                            donhang.GIATRIKHUYENMAI
                        };
            foreach (var result in query)
            {
                DonHangThongKe_DTO item = new DonHangThongKe_DTO();
                item.TENNGUOIDUNG = result.TENNGUOIDUNG;
                item.MADONHANG = result.MADONHANG;
                item.TONGGIA = (int)result.TONGGIA;
                if (result.TENKHACHHANG == "")
                {
                    item.TENKHACHHANG = "Không có tên KH";
                }
                else
                {
                    item.TENKHACHHANG = result.TENKHACHHANG;
                }
                if (result.TENKHUYENMAI == "")
                {
                    item.TENKHUYENMAI = "Không áp dụng KM";
                }
                else
                {
                    item.TENKHUYENMAI = result.TENKHUYENMAI;
                }
                item.THOIGIAN = result.THOIGIAN.Value.ToString("hh:mm-dd/MM/yyyy");
                item.SOTIENGIAM = (int)result.GIATRIKHUYENMAI;
                listThongKe.Add(item);
            }

            return listThongKe;
        }

        public static List<SanPhamThongKe_DTO> sanPhamTheoNgay(DateTime date)
        {
            listSp.Clear();
            var query = (
                            from ct in db.CHITIETDONHANGs
                            join sp in db.SANPHAMs on ct.MASANPHAM equals sp.MASANPHAM
                            join dh in db.DONHANGs on ct.MADONHANG equals dh.MADONHANG
                            where dh.THOIGIAN.Value.Day == date.Day && dh.THOIGIAN.Value.Month == date.Month && dh.THOIGIAN.Value.Year == date.Year
                            group ct by sp.TENSANPHAM into g
                            select new
                            {
                                TENSANPHAM = g.Key,
                                TONG_SOLUONG = g.Sum(ct => ct.SOLUONG)
                            }
                        ).ToList();

            foreach (var result in query)
            {
                SanPhamThongKe_DTO item = new SanPhamThongKe_DTO();
                item.TENSANPHAM = result.TENSANPHAM;
                item.SOLUONG = (int)result.TONG_SOLUONG;
                listSp.Add(item);
            }
            return listSp;
        }

        public static List<SanPhamThongKe_DTO> sanPhamTheoThang(DateTime date)
        {
            listSp.Clear();
            var query = (
                            from ct in db.CHITIETDONHANGs
                            join sp in db.SANPHAMs on ct.MASANPHAM equals sp.MASANPHAM
                            join dh in db.DONHANGs on ct.MADONHANG equals dh.MADONHANG
                            where dh.THOIGIAN.Value.Month == date.Month && dh.THOIGIAN.Value.Year == date.Year
                            group ct by sp.TENSANPHAM into g
                            select new
                            {
                                TENSANPHAM = g.Key,
                                TONG_SOLUONG = g.Sum(ct => ct.SOLUONG)
                            }
                        ).ToList();

            foreach (var result in query)
            {
               SanPhamThongKe_DTO item = new SanPhamThongKe_DTO();
                item.TENSANPHAM = result.TENSANPHAM;
                item.SOLUONG = (int)result.TONG_SOLUONG;
                listSp.Add(item);
            }
            return listSp;
        }

        public static List<SanPhamThongKe_DTO> sanPhamTheoNam(DateTime date)
        {
            listSp.Clear();
            var query = (
                            from ct in db.CHITIETDONHANGs
                            join sp in db.SANPHAMs on ct.MASANPHAM equals sp.MASANPHAM
                            join dh in db.DONHANGs on ct.MADONHANG equals dh.MADONHANG
                            where dh.THOIGIAN.Value.Year == date.Year
                            group ct by sp.TENSANPHAM into g
                            select new
                            {
                                TENSANPHAM = g.Key,
                                TONG_SOLUONG = g.Sum(ct => ct.SOLUONG)
                            }
                        ).ToList();

            foreach (var result in query)
            {
                SanPhamThongKe_DTO item = new SanPhamThongKe_DTO();
                item.TENSANPHAM = result.TENSANPHAM;
                item.SOLUONG = (int)result.TONG_SOLUONG;
                listSp.Add(item);
            }
            return listSp;
        }

        public static List<SanPhamThongKe_DTO> sanPhamTheoKhoangThoiGian(DateTime dateFrom, DateTime dateTo)
        {
            listSp.Clear();
            var query = (
                            from ct in db.CHITIETDONHANGs
                            join sp in db.SANPHAMs on ct.MASANPHAM equals sp.MASANPHAM
                            join dh in db.DONHANGs on ct.MADONHANG equals dh.MADONHANG
                            where dh.THOIGIAN.Value >= dateFrom && dh.THOIGIAN.Value <= dateTo
                            group ct by sp.TENSANPHAM into g
                            select new
                            {
                                TENSANPHAM = g.Key,
                                TONG_SOLUONG = g.Sum(ct => ct.SOLUONG)
                            }
                        ).ToList();

            foreach (var result in query)
            {
                SanPhamThongKe_DTO item = new SanPhamThongKe_DTO();
                item.TENSANPHAM = result.TENSANPHAM;
                item.SOLUONG = (int)result.TONG_SOLUONG;
                listSp.Add(item);
            }
            return listSp;
        }

        public static int doanhThuTheoNgay(DateTime date)
        {
            int doanhThu = 0;

            var query = (
                            from dh in db.DONHANGs
                            where dh.THOIGIAN.Value.Day == date.Day && dh.THOIGIAN.Value.Month == date.Month && dh.THOIGIAN.Value.Year == date.Year
                            select new
                            {

                                TONG_GIA = dh.TONGGIA
                            }
                        );

            var result = query.ToList();

             doanhThu = (int)result.Sum(dh => dh.TONG_GIA);

            return doanhThu;
        }

        
    }
}
