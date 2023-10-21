using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FThongTinChung : UserControl
    {
        public FThongTinChung()
        {
            InitializeComponent();
        }

        private void FThongTinChung_Load(object sender, EventArgs e)
        {
            setDefaut();
        }

        public string themDauChamVaoSo(int number)
        {

            string numberStr = number.ToString("N0", CultureInfo.InvariantCulture);
            numberStr = numberStr.Replace(",", ".");
            return numberStr;

        }
        private void setDefaut()
        {
            DateTime date = DateTime.Now;
            int doanhThu = ThongKe_BUS.doanhThuTheoNgay(date);
            lbl_DoanhThu.Text = themDauChamVaoSo(doanhThu)+" VNĐ";
            List<DonHangThongKe_DTO> listDonHang = ThongKe_BUS.thongKeTheoNgay(date);
            lbl_DonHang.Text = listDonHang.Count.ToString();
            int soSanPham = QuanLySanPham_BUS.layDuLieu().Count();
            lbl_SanPham.Text = soSanPham.ToString();
            int soNhanVien = QLNguoiDung_BUS.LayDuLieu().Count;
            lbl_NhanVien.Text = soNhanVien.ToString();
        }
    }
}
