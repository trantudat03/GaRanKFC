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
using DTO;
using BUS;
namespace GUI
{
    public partial class FThanhToan : Form
    {
        private static KhachHang_DTO khachHang = new KhachHang_DTO();
        private static KhuyenMai_DTO khuyenMai = new KhuyenMai_DTO();
        private static int thanhTien = 0;
        private static List<SanPham_DTO> listOrder = new List<SanPham_DTO>();
        private static bool checkThanhToan = false;
        public FThanhToan()
        {
            InitializeComponent();
        }

        public FThanhToan(KhachHang_DTO kh, int tongTien, KhuyenMai_DTO km, List<SanPham_DTO> orders)
        {
            khachHang = kh;
            khuyenMai = km;
            thanhTien = tongTien;
            listOrder = orders;
            InitializeComponent();
        }

        private void FThanhToan_Load(object sender, EventArgs e)
        {
            capNhatTongTin();
        }

        public string themDauChamVaoSo(int number)
        {

            string numberStr = number.ToString("N0", CultureInfo.InvariantCulture);
            numberStr = numberStr.Replace(",", ".");
            return numberStr;

        }

        private void hienDanhSachKhuyenMai(List<SanPham_DTO> listSP)
        {
            //MessageBox.Show(thanhTien.ToString() + "p" + khachHang.DIEM.ToString());
            if (listSP.Count > 0)
            {
                int x = 15;
                int y = 8;

                int space = 12;
                listSP.ForEach(s =>
                {
                    //MessageBox.Show(k.TENKHUYENMAI);

                    int width = panel_DSOrder.Width - 2 * x;
                    int height = 35;
                    Panel p = new Panel();
                    p.Size = new Size(width, height);
                    p.Location = new Point(x-10, y);
                    p.BorderStyle = BorderStyle.FixedSingle;
                    
                   
                    Label l = new Label();
                    l.Size = new Size(width - 5, height - 6);
                    l.Location = new Point(3, 7);
                    l.Font = new Font("Arial", 11, FontStyle.Regular);

                    l.Text = $"{s.TENSANPHAM}, {themDauChamVaoSo(s.GIASANPHAM)}VND, SL:{s.SLORDER}";
                    p.Controls.Add(l);
                    panel_DSOrder.Controls.Add(p);
                    y = y + space + height;
                });

            }
        }

        public bool getCheckThanhToan()
        {
            return checkThanhToan;
        }

        private void capNhatTongTin()
        {
            int checkKM = 0;
            if(khachHang.MAKHACHHANG != "")
            {
                lbl_TTTenKhachHang.Text = khachHang.TENKHACHHANG;
                lbl_TTTenKhachHang.ForeColor = Color.Green;
            }
            else
            {
                lbl_TTTenKhachHang.Text = "Chưa có thông tin khách hàng";
                lbl_TTTenKhachHang.ForeColor = Color.Red;
            }
            if(khuyenMai.MAKHUYENMAI != "")
            {
                lbl_TTTenKhuyenMai.Text = khuyenMai.TENKHUYENMAI;
                lbl_TTTenKhuyenMai.ForeColor = Color.Green;
                checkKM = 1;
            }
            else
            {
                lbl_TTTenKhuyenMai.Text = "Không áp dụng!";
                lbl_TTTenKhuyenMai.ForeColor = Color.Red;
            }
            if (thanhTien > 0)
            {
                int soTienGiam = 0;
                if(checkKM ==1)
                {
                    if(khuyenMai.PHANTRAM >0)
                    {
                        soTienGiam = thanhTien * khuyenMai.PHANTRAM / 100;
                        if(soTienGiam > khuyenMai.SOTIENGIAMTOIDA)
                        {
                            soTienGiam = khuyenMai.SOTIENGIAMTOIDA;
                        }
                    }
                    else
                    {
                        soTienGiam = khuyenMai.SOTIENGIAM;
                    }
                    thanhTien -= soTienGiam;
                }
                lbl_TTSoTien.Text = themDauChamVaoSo(thanhTien);
                lbl_TTSoTien.ForeColor = Color.Red;
            }

            if(listOrder.Count >0)
            {
                listOrder.ForEach(km =>
                {
                    hienDanhSachKhuyenMai(listOrder);
                });
            }
        }

        private void btn_TTTienMat_Click(object sender, EventArgs e)
        {
            int check = 0;
            check = QLKhachHang_BUS.capNhatDiem(khachHang, thanhTien / 1000);
            checkThanhToan = true;
            this.Close();
        }
    }
}
