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
using System.Timers;
using System.Runtime.Remoting.Contexts;

namespace GUI
{
    public partial class FThanhToan : Form
    {
        public static FChuyenKhoan fchuyenKhoan;
        private static NguoiDung_DTO user = new NguoiDung_DTO();
        private static KhachHang_DTO khachHang = new KhachHang_DTO();
        private static KhuyenMai_DTO khuyenMai = new KhuyenMai_DTO();
        public static int tienTruocKhuyenMai = 0;
        public static int thanhTien = 0;
        private static List<SanPham_DTO> listOrder = new List<SanPham_DTO>();
        private static bool checkThanhToan = false;
        private static int soTienDaTra = 0; // so tien mat
        private static int soTienChuyenKhoan = 0;
        private static int soTienConLai = thanhTien;
        private static int soTienThoi = 0;
        public static int soTienGiam = 0; // giam do khuyen mai
        private PhuongThucThanhToan_DTO phuongThuc = new PhuongThucThanhToan_DTO();
        public FThanhToan()
        {
            
            InitializeComponent();
        }

        public FThanhToan(KhachHang_DTO kh, int tongTien, KhuyenMai_DTO km, List<SanPham_DTO> orders, NguoiDung_DTO u)
        {
            checkThanhToan = false;
            khachHang = kh;
            khuyenMai = km;
            thanhTien = tongTien;
            tienTruocKhuyenMai = tongTien;
            soTienConLai = thanhTien;
            listOrder = orders;
            user = u;
            phuongThuc.MAPHUONGTHUC = "1";
            InitializeComponent();
        }

        private void FThanhToan_Load(object sender, EventArgs e)
        {
            capNhatTongTin();

            setvaluePanelNumber(number0, 0);
            setvaluePanelNumber(number5, 5);
            setvaluePanelNumber(number6, 6);
            setvaluePanelNumber(number1, 1);
            setvaluePanelNumber(number2, 2);
            setvaluePanelNumber(number3, 3);
            setvaluePanelNumber(number4, 4);
            setvaluePanelNumber(number7, 7);
            setvaluePanelNumber(number8, 8);
            setvaluePanelNumber(number9, 9);
            setValuePanelEnter(btn_enter);
            setValuePanelXoa(btn_Xoa);
            /*if(!kiemTraDonHang())
            {
                MessageBox.Show("Đơn hàng có thể ");
            }*/
            setDefaut();
            setValuePanelThoiTra();

        }
        private void hienThiSoTienNhap(int number)
        {
            if(txb_soTienMat.Text == "0")
            {
                txb_soTienMat.Text = "";
            }
            txb_soTienMat.Text += number.ToString();
        }

        private void xoa1SoTienMat()
        {
            if(txb_soTienMat.Text.Length == 1 && txb_soTienMat.Text != "0")
            {
                txb_soTienMat.Text = "0";
            }
            if(txb_soTienMat.Text != "0")
            {
                txb_soTienMat.Text = txb_soTienMat.Text.Substring(0, txb_soTienMat.Text.Length - 1);
            }
        }

        private void setDefaut()
        {
            txb_soTienMat.Text = "0";
            lbl_soTienThoi.Text = "0";
        }
        public void setvaluePanelNumber(Panel p, int number)
        {
            Label l = new Label();

            l.Text = number.ToString();
            l.Font = new Font("Arial", 28, FontStyle.Bold);
            l.TextAlign = ContentAlignment.MiddleCenter;
            //l.AutoSize = true;
            l.Size = new Size(37, 37);
            l.Location = new Point((p.Width - l.Width) / 2, (p.Height - l.Height) / 2);
            l.Cursor = Cursors.Hand;
            p.Cursor = Cursors.Hand;
            l.Click += (sender, e) =>
            {
                hienThiSoTienNhap(number);
            };

            p.Click += (sender, e) =>
            {
                hienThiSoTienNhap(number);
                //p.BackColor = Color.FromArgb(43, 139, 255,1);

            };
            if (number==0)
            {
                l.ForeColor = Color.Black;
               //p.BackColor = Color.White;
            }
            else
            {
                
                l.ForeColor = Color.White;
                p.BackColor = Color.DodgerBlue;
                l.TabIndex = 99;

            }
            p.Controls.Add(l);
            p.BorderStyle = BorderStyle.FixedSingle;

            //l.BorderStyle = BorderStyle.FixedSingle
        }

        public void doiMauKhiClick(Color m1, Color m2, Panel c)
        {
            System.Timers.Timer timer;
            timer = new System.Timers.Timer();
            timer.Interval = 500;
            c.BackColor = m1;
            // Đăng ký sự kiện Elapsed của timer
            timer.Elapsed += (sender, e) =>
            {
                c.BackColor = m2;
            };

            // Bắt đầu đếm thời gian
            timer.Start();

            // Đợi 0.5 giây
            System.Threading.Thread.Sleep(500);

            // Dừng timer sau khi đã chờ xong
            timer.Stop();

        }

        public void setValuePanelThoiTra()
        {
            lbl_soTienThoi.Location = new Point((panel_SoTienThoi.Width - lbl_soTienThoi.Width) / 2, (panel_SoTienThoi.Height - lbl_soTienThoi.Height) / 2);
            lbl_TTSoTien.Location = new Point((panel_SoTienTra.Width - lbl_TTSoTien.Width) / 2, (panel_SoTienTra.Height - lbl_TTSoTien.Height) / 2);
        }

        public void tinhTienThoi()
        {
            if(soTienDaTra>=0)
            {
                soTienThoi = soTienDaTra - thanhTien;
                if(soTienThoi < 0)
                {
                    lbl_thoiThieu.Text = "Số Tiền Thiếu";

                }
                else
                {
                    lbl_thoiThieu.Text = "Số Tiền Thối";
                }
                lbl_soTienThoi.Text = themDauChamVaoSo(soTienThoi);
                setValuePanelThoiTra();
            }
        }
        public void setValuePanelEnter(Panel p)
        {
            Label l = new Label();
            l.Text = "Enter";
            l.Font = new Font("Arial", 20, FontStyle.Bold);
            l.TextAlign= ContentAlignment.MiddleCenter;
            l.Size = new Size(p.Width-5, 40);
            l.ForeColor = Color.White;
            l.Location = new Point((p.Width - l.Width) / 2, (p.Height - l.Height) / 2);
            l.Click += (sender, e) =>
            {
                soTienDaTra = int.Parse(txb_soTienMat.Text);
                soTienConLai = thanhTien - soTienDaTra;
                if(soTienConLai<0)
                {
                    soTienConLai = 0;
                }
                tinhTienThoi();
            };

            p.Click += (sender, e) =>
            {
                soTienDaTra = int.Parse(txb_soTienMat.Text);
                soTienConLai = thanhTien - soTienDaTra;
                if (soTienConLai < 0)
                {
                    soTienConLai = 0;
                }
                tinhTienThoi();
            };
            p.Controls.Add(l);
            l.Cursor = Cursors.Hand;
            p.Cursor = Cursors.Hand;
        }

        public void setValuePanelXoa(Panel p)
        {
            Label l = new Label();
            l.Text = "Xóa";
            l.Font = new Font("Arial", 20, FontStyle.Bold);
            l.TextAlign = ContentAlignment.MiddleCenter;
            l.Size = new Size(p.Width - 5, 40);
            l.ForeColor = Color.White;
            l.Location = new Point((p.Width - l.Width) / 2, (p.Height - l.Height) / 2);
            l.Click += (sender, e) =>
            {
                xoa1SoTienMat();
            };

            p.Click += (sender, e) =>
            {
                xoa1SoTienMat();
            };
            p.Controls.Add(l);
            l.Cursor = Cursors.Hand;
            p.Cursor = Cursors.Hand;
        }
        

        public string themDauChamVaoSo(int number)
        {

            string numberStr = number.ToString("N0", CultureInfo.InvariantCulture);
            numberStr = numberStr.Replace(",", ".");
            return numberStr;

        }

        private void hienDanhSachSanPham(List<SanPham_DTO> listSP)
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
            if(khuyenMai.MAKHUYENMAI != string.Empty)
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
                    soTienConLai = thanhTien;
                    if(thanhTien <0)
                    {
                        thanhTien = 0;
                        soTienConLai = thanhTien;
                    }
                    
                }
                lbl_TTSoTien.Text = themDauChamVaoSo(thanhTien);
                lbl_TTSoTien.ForeColor = Color.Red;
            }

            if(listOrder.Count >0)
            {
                listOrder.ForEach(km =>
                {
                    hienDanhSachSanPham(listOrder);
                });
            }
        }


        private bool kiemTraDonHang()
        {
            if(thanhTien< 0)
            {
                thanhTien = 0;
                return true;
            }
            return false;
        }


        

        private void thanhToanDienTu()
        {
            if(soTienConLai>0 && checkThanhToan)
            {
                soTienChuyenKhoan = soTienConLai;
                if(soTienDaTra==0 )
                {
                    DonHang_DTO donHang = new DonHang_DTO();
                    donHang.MADONHANG = "1";
                    if (khachHang.MAKHACHHANG != string.Empty)
                    {
                        donHang.MAKHACHHANG = khachHang.MAKHACHHANG;
                    }
                    else
                    {
                        donHang.MAKHACHHANG = "0";
                    }
                    if (khuyenMai.MAKHUYENMAI != string.Empty)
                    {
                        donHang.MAKHUYENMAI = khuyenMai.MAKHUYENMAI;
                    }
                    else
                    {
                        donHang.MAKHUYENMAI = "0";
                    }
                    donHang.TONGGIA = tienTruocKhuyenMai;

                    donHang.MANGUOIDUNG = user.MANGUOIDUNG;// test user
                    donHang.SOLUONGSP = listOrder.Count; // test so luong don 
                    DateTime currentTime = DateTime.Now;
                    donHang.THOIGIAN = currentTime.ToString("yyyy-MM-dd HH:mm:ss");
                    donHang.SOTIENGIAM = soTienGiam;
                    string maDonHang = QLDonHang_BUS.themDonHang(donHang);
                    if (maDonHang != string.Empty)
                    {
                        int check = QLChiTietDonHang_BUS.themChiTietDon(listOrder, maDonHang);
                        if (check == 1)
                        {

                            MessageBox.Show("Thanh Toán Thành Công");

                            if (khachHang.MAKHACHHANG != "")// check co khach hang ko 
                            {
                                int checkCongDiem = 0;
                                checkCongDiem = QLKhachHang_BUS.capNhatDiem(khachHang, thanhTien / 1000);
                                if (checkCongDiem == 1)
                                {

                                    int checkPTTT = 0;// check phuong thuc thanh toan 
                                    phuongThuc.MAPHUONGTHUC = "2";
                                    checkPTTT = QLChiTietThanhToan_BUS.themChiTietThanhToan(maDonHang, phuongThuc.MAPHUONGTHUC, soTienChuyenKhoan);
                                    if (checkPTTT == 1)
                                    {
                                        checkThanhToan = true;
                                        inHoaDon();
                                        this.Close();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Luu pttt that bai");
                                    }

                                }
                            }
                            else
                            {
                                int checkPTTT = 0;// check phuong thuc thanh toan 
                                phuongThuc.MAPHUONGTHUC = "2";
                                checkPTTT = QLChiTietThanhToan_BUS.themChiTietThanhToan(maDonHang, phuongThuc.MAPHUONGTHUC, soTienChuyenKhoan);
                                if (checkPTTT == 1)
                                {
                                    
                                    checkThanhToan = true;
                                    inHoaDon();
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Luu pttt that bai");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Thanh Toán Thất Bại");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Thanh Toan That Bai");
                    }
                }
                else
                {
                    if(soTienDaTra>0)
                    {
                        DonHang_DTO donHang = new DonHang_DTO();
                        donHang.MADONHANG = "1";
                        if (khachHang.MAKHACHHANG != "")
                        {
                            donHang.MAKHACHHANG = khachHang.MAKHACHHANG;
                        }
                        else
                        {
                            donHang.MAKHACHHANG = "0";
                        }
                        if (khuyenMai.MAKHUYENMAI != "")
                        {
                            donHang.MAKHUYENMAI = khuyenMai.MAKHUYENMAI;
                        }
                        else
                        {
                            donHang.MAKHUYENMAI = "0";
                        }
                        donHang.TONGGIA = tienTruocKhuyenMai;

                        donHang.MANGUOIDUNG = user.MANGUOIDUNG;// test user
                        donHang.SOLUONGSP = listOrder.Count; // test so luong don 
                        DateTime currentTime = DateTime.Now;
                        donHang.THOIGIAN = currentTime.ToString("yyyy-MM-dd HH:mm:ss");
                        donHang.SOTIENGIAM = soTienGiam;
                        string maDonHang = QLDonHang_BUS.themDonHang(donHang);
                        if (maDonHang != string.Empty)
                        {
                            int check = QLChiTietDonHang_BUS.themChiTietDon(listOrder, maDonHang);
                            if (check == 1)
                            {

                                MessageBox.Show("Thanh Toán Thành Công");

                                if (khachHang.MAKHACHHANG != "")// check co khach hang ko 
                                {
                                    int checkCongDiem = 0;
                                    checkCongDiem = QLKhachHang_BUS.capNhatDiem(khachHang, thanhTien / 1000);
                                    if (checkCongDiem == 1)
                                    {

                                        int checkPTTT1 = 0;// check phuong thuc thanh toan 
                                        phuongThuc.MAPHUONGTHUC = "2";
                                        checkPTTT1 = QLChiTietThanhToan_BUS.themChiTietThanhToan(maDonHang, phuongThuc.MAPHUONGTHUC, soTienChuyenKhoan);
                                        phuongThuc.MAPHUONGTHUC = "1";
                                        int checkPTTT2 = 0;
                                        checkPTTT2 = QLChiTietThanhToan_BUS.themChiTietThanhToan(maDonHang, phuongThuc.MAPHUONGTHUC, soTienDaTra);
                                        if (checkPTTT1 == 1 && checkPTTT2 == 1)
                                        {
                                            checkThanhToan = true;
                                            inHoaDon();
                                            this.Close();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Luu pttt that bai");
                                        }

                                    }
                                }
                                else
                                {
                                    int checkPTTT1 = 0;// check phuong thuc thanh toan 
                                    phuongThuc.MAPHUONGTHUC = "2";
                                    checkPTTT1 = QLChiTietThanhToan_BUS.themChiTietThanhToan(maDonHang, phuongThuc.MAPHUONGTHUC, soTienChuyenKhoan);
                                    phuongThuc.MAPHUONGTHUC = "1";
                                    int checkPTTT2 = 0;
                                    checkPTTT2 = QLChiTietThanhToan_BUS.themChiTietThanhToan(maDonHang, phuongThuc.MAPHUONGTHUC, soTienDaTra);
                                    if (checkPTTT1 == 1 && checkPTTT2 ==1)
                                    {
                                        checkThanhToan = true;
                                        inHoaDon();
                                        this.Close();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Luu pttt that bai");
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Thanh Toán Thất Bại");
                            }
                        }
                    }
                }

            }
        }

        private void tienHanhThanhToan()
        {
            if (soTienDaTra>= thanhTien)
            {
                DialogResult result = MessageBox.Show($"Xác nhận thanh toán",
     "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {

                    DonHang_DTO donHang = new DonHang_DTO();
                    donHang.MADONHANG = "1";
                    if (khachHang.MAKHACHHANG != "")
                    {
                        donHang.MAKHACHHANG = khachHang.MAKHACHHANG;
                    }
                    else
                    {
                        donHang.MAKHACHHANG = "0";
                    }
                    if (khuyenMai.MAKHUYENMAI != "")
                    {
                        donHang.MAKHUYENMAI = khuyenMai.MAKHUYENMAI;
                    }
                    else
                    {
                        donHang.MAKHUYENMAI = "0";
                    }
                    donHang.TONGGIA = tienTruocKhuyenMai;

                    donHang.MANGUOIDUNG = user.MANGUOIDUNG;// test user
                    donHang.SOLUONGSP = listOrder.Count; // test so luong don 
                    donHang.SOTIENGIAM = soTienGiam;
                    DateTime currentTime = DateTime.Now;
                    donHang.THOIGIAN = currentTime.ToString("yyyy-MM-dd HH:mm:ss");
                    string maDonHang = QLDonHang_BUS.themDonHang(donHang);
                    if (maDonHang != string.Empty)
                    {
                        int check = QLChiTietDonHang_BUS.themChiTietDon(listOrder, maDonHang);
                        if (check == 1)
                        {
                            
                            MessageBox.Show("Thanh Toán Thành Công");

                            if (khachHang.MAKHACHHANG != "")// check co khach hang ko 
                            {
                                int checkCongDiem = 0;
                                checkCongDiem = QLKhachHang_BUS.capNhatDiem(khachHang, thanhTien / 1000);
                                if (checkCongDiem == 1)
                                {
                                    
                                    int checkPTTT = 0;// check phuong thuc thanh toan 
                                    checkPTTT = QLChiTietThanhToan_BUS.themChiTietThanhToan(maDonHang, phuongThuc.MAPHUONGTHUC, soTienDaTra);
                                    if (checkPTTT == 1)
                                    {
                                        checkThanhToan = true;
                                        inHoaDon();
                                        this.Close();
                                    }else
                                    {
                                        MessageBox.Show("Luu pttt that bai");
                                    }
                                    
                                }
                            }
                            else
                            {
                                int checkPTTT = 0;// check phuong thuc thanh toan 
                                checkPTTT = QLChiTietThanhToan_BUS.themChiTietThanhToan(maDonHang, phuongThuc.MAPHUONGTHUC, soTienDaTra);
                                if (checkPTTT == 1)
                                {
                                    checkThanhToan = true;
                                    inHoaDon();
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Luu pttt that bai");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Thanh Toán Thất Bại");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Khách hàng vẫn đang thiếu tiền!");
            }
        }

        private void btn_TTTienMat_Click(object sender, EventArgs e)
        {   
            if(soTienDaTra>=thanhTien)
            {
                tienHanhThanhToan();
            }
            else
            {
                MessageBox.Show("Khách hàng chưa trả đủ tiền");
            }
            
        }


        private void btn_TTThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btn_TTChuyenKhoan_Click(object sender, EventArgs e)
        {
            
            if(soTienConLai>0)
            {
                fchuyenKhoan = new FChuyenKhoan(soTienConLai.ToString());
                fchuyenKhoan.FormClosed += fCKClose;
                fchuyenKhoan.ShowDialog();
                thanhToanDienTu();
            }
            else
            {
                MessageBox.Show("Đơn hàng đã trả đủ tiền");
            }
            //inHoaDon();
        }

        private void fCKClose(object sender, FormClosedEventArgs e)
        {
            checkThanhToan = fchuyenKhoan.getCheckChuyenKhoan();
        }

        private void inHoaDon()
        {
            printPreviewDialogHD.Document = printDocumentHD;
            printPreviewDialogHD.ShowDialog();
        }

        private void printDocumentHD_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Vẽ giao diện in cho gà rán KFC
            Font titleFont = new Font("Arial", 24, FontStyle.Bold);
            Font contentFont = new Font("Arial", 12);

            string title = "GÀ RÁN KFC";
            string address = "Địa chỉ: 123 Đường ABC, Quận XYZ, Thành phố HCM";
            string phone = "SĐT: (012) 345-6789";
            string orderNumber = $"Tên nhân viên {user.TENNGUOIDUNG}";
            string date = "Ngày: " + DateTime.Now.ToShortDateString();
            string time = "Giờ: " + DateTime.Now.ToShortTimeString();
            string separator = new string('-', 50);

            int xOffset = 50;
            int yOffset = 100;
            int logoWidth = 100; // Kích thước mới của logo (độ rộng)
            int logoHeight = 100;
            // Vẽ tiêu đề và logo
            Image logo = Image.FromFile(@"..\\..\\Resources\\logo.jpg"); // Đường dẫn đến file logo KFC

            Image resizedLogo = logo.GetThumbnailImage(logoWidth, logoHeight, null, IntPtr.Zero);

            e.Graphics.DrawImage(resizedLogo, new PointF(xOffset, yOffset));
            e.Graphics.DrawString(title, titleFont, Brushes.Black, new PointF(xOffset + resizedLogo.Width + 10, yOffset));
            yOffset += resizedLogo.Height + 10;

            // Vẽ địa chỉ và số điện thoại
            e.Graphics.DrawString(address, contentFont, Brushes.Black, new PointF(50, yOffset));
            yOffset += 20;
            e.Graphics.DrawString(phone, contentFont, Brushes.Black, new PointF(50, yOffset));
            yOffset += 40;

            // Vẽ thông tin đơn hàng
            e.Graphics.DrawString(orderNumber, contentFont, Brushes.Black, new PointF(520, 100));
            
            e.Graphics.DrawString(date, contentFont, Brushes.Black, new PointF(520, 120));
           
            e.Graphics.DrawString(time, contentFont, Brushes.Black, new PointF(520, 140));
            

            // Vẽ danh sách món ăn
            e.Graphics.DrawString("Danh sách món ăn:", contentFont, Brushes.Black, new PointF(50, yOffset));
            yOffset += 20;
            e.Graphics.DrawString("Tên món                              " + "Giá                "+ "Số lượng         "+ "Thành Tiền", contentFont, Brushes.Black, new PointF(50, yOffset));
            
            yOffset += 20;
            e.Graphics.DrawLine(Pens.Black, new PointF(50, yOffset), new PointF(600, yOffset));

            // Ví dụ danh sách món ăn
            //string[] items = { "1. Gà Rán 1 miếng", "2. Khoai Tây Chiên", "3. Pepsi 500ml" };

            int widthTen = 200;
            int widthGia = 100;
            int widthSL = 120;
            

            foreach (SanPham_DTO item in listOrder)
            {
                
                e.Graphics.DrawString(item.TENSANPHAM, contentFont, Brushes.Black, new PointF(xOffset, yOffset));
                xOffset += widthTen;
                e.Graphics.DrawString(item.GIASANPHAM.ToString(), contentFont, Brushes.Black, new PointF(xOffset, yOffset));
                xOffset += widthGia;
                e.Graphics.DrawString(item.SLORDER.ToString(), contentFont, Brushes.Black, new PointF(xOffset, yOffset));
                xOffset += widthSL;
                e.Graphics.DrawString((item.GIASANPHAM*item.SLORDER).ToString(), contentFont, Brushes.Black, new PointF(xOffset, yOffset));
                xOffset = 50;
                yOffset += 30;
            }

            // Vẽ đường kẻ ngăn cách
            yOffset += 20;
            e.Graphics.DrawLine(Pens.Black, new PointF(50, yOffset), new PointF(600, yOffset));

            // Vẽ tổng tiền
            string total = "Tổng tiền:"; // Tổng tiền đơn hàng
            yOffset += 20;
            e.Graphics.DrawString(total, contentFont, Brushes.Black, new PointF(50, yOffset));
            e.Graphics.DrawString(tienTruocKhuyenMai.ToString(), contentFont, Brushes.Black, new PointF(520, yOffset));
            yOffset += 20;
            e.Graphics.DrawString("Khuyễn Mãi ", contentFont, Brushes.Black, new PointF(50, yOffset));
            e.Graphics.DrawString(soTienGiam.ToString(), contentFont, Brushes.Black, new PointF(520, yOffset));
            yOffset += 20;
            e.Graphics.DrawString("Thành Tiền", contentFont, Brushes.Black, new PointF(50, yOffset));
            e.Graphics.DrawString(thanhTien.ToString(), contentFont, Brushes.Black, new PointF(520, yOffset));
        }

      
    
    }

    
}
