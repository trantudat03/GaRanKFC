using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
namespace GUI
{
    public partial class FMain : Form
    {
        FOrder formOrder;
        FThongKe formThongKe = new FThongKe();
        FQuanLySanPham formSanPham = new FQuanLySanPham();
        public static NguoiDung_DTO user = new NguoiDung_DTO();
        public static bool checkThayDoi = false;
        public static int checkPage = 0;
        public static FThongTinChung fThongTinChung = new FThongTinChung();
        public static FQuanLyNguoiDung fNguoiDung = new FQuanLyNguoiDung();
        public static FKhuyenMai fKhuyenMai = new FKhuyenMai();
        public static FQuanLyKhachHang fkhachHang = new FQuanLyKhachHang();

        public FMain()
        {
            InitializeComponent();

        }

        public FMain(NguoiDung_DTO u)
        {
            InitializeComponent();
            user = u;
            lbl_UserName.Text = u.TENNGUOIDUNG;
        }

        public NguoiDung_DTO getUser()
        {
            return user;
        }

        private void setStyle()
        {
            lbl_UserName.ForeColor = Color.White;
            lbl_logout.ForeColor = Color.BlueViolet;
            panel_Header.BackColor = Color.FromArgb(167, 0, 0);
            panel_sideBar.BackColor = Color.FromArgb(167, 0, 0);
            setStyleTasbar(btn_Order);
            setStyleTasbar(btn_QuanLy);
            setStyleTasbar(btn_QLKhachHang);
            setStyleTasbar(btn_QLKhuyenMai);
            setStyleTasbar(btn_QLNguoiDung);
            setStyleTasbar(btn_QLSanPham);
            setStyleTasbar(btn_ThongKe);
            //btn_Order.FlatAppearance.MouseDownBackColor = Color.Red;
            
        }

        private void setStyleTasbar(Button p)
        {
            p.FlatStyle = FlatStyle.Flat;
            p.BackColor = Color.Transparent;
            p.ForeColor = Color.White;
            p.FlatAppearance.BorderSize = 0;
            p.FlatAppearance.MouseOverBackColor = Color.Red;
            
        }

        private void setMainPanel(UserControl p)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(p);
            p.Dock = DockStyle.Fill;
        }

        private void addUserControl(UserControl u)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(u);
            u.Dock = DockStyle.Fill;
        }

        private void FMain_Load(object sender, EventArgs e)
        {
            setStyle();
            formOrder = new FOrder();
            formOrder.setUser(user);
            panelMain.Controls.Add(formOrder);
            formOrder.Dock = DockStyle.Fill;
            setDefaut();
        }


        public void setDefaut()
        {
            panel_QuanLy.Visible = false;
        }

        private void btn_QuanLy_Click(object sender, EventArgs e)
        {
            
            if(checkPage!=1)// neu dang o order
            {
                if (user.MACHUCVU == "QL")
                {
                    if (formOrder.getListOrder().Count == 0)
                    {
                        panel_QuanLy.Visible = true;
                        setMainPanel(fThongTinChung);
                        fThongTinChung.setData();
                        checkPage = 1;
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng hoàn thành đơn hàng");
                    }
                }
                else
                {
                    MessageBox.Show("Chưa được phân quyền");
                }
                
            }
            
            
        }

        private void btn_Order_Click(object sender, EventArgs e)
        {
            //formOrder = new FOrder();
            if(checkPage!=0)// check = 0 tuc dang o page order
            {
                panel_QuanLy.Visible = false;
                panelMain.Controls.Clear();
                panelMain.Controls.Add(formOrder);
                formOrder.setData();
                //formOrder.setDefaut();
                
                formOrder.Dock = DockStyle.Fill;
                checkPage = 0;
            }
        }

        private void groupBoxUser_Enter(object sender, EventArgs e)
        {

        }

        private void panel_QuanLy_Paint(object sender, PaintEventArgs e)
        {
            
        }
        private void btn_QLSanPham_Click(object sender, EventArgs e)
        {
            if(checkPage!=2)
            {
                setMainPanel(formSanPham);
                formSanPham.setData();
                checkPage = 2;
            }
            
        }

        private void btn_QLNguoiDung_Click(object sender, EventArgs e)
        {
            if(checkPage !=3)
            {
                addUserControl(fNguoiDung);
                fNguoiDung.setUser(user);
                fNguoiDung.setData();
                checkPage = 3;
            }
        }

        private void btn_QLKhachHang_Click(object sender, EventArgs e)
        {
            if (checkPage != 4)
            {
                addUserControl(fkhachHang);
                fkhachHang.setData();
                checkPage = 4;
            }
        }

        private void btn_QLKhuyenMai_Click(object sender, EventArgs e)
        {
            if(checkPage!= 5)
            {
                addUserControl(fKhuyenMai);
                fKhuyenMai.setData();
                checkPage = 5;
            }
        }

        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            if (checkPage != 6)
            {
                setMainPanel(formThongKe);
                formThongKe.setData();
                checkPage = 6;
            }


        }

        private void FMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            FDangNhap fDangNhap = new FDangNhap();
            fDangNhap.Show();
        }
        // note
        // note
        private void lbl_logout_Click(object sender, EventArgs e)
        {
            if(formOrder.getListOrder().Count>0)
            {
                MessageBox.Show("Vui Lòng Hoàn Thành Xong Đơn Hàng");
            }
            else
            {
                DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn đăng xuất",
     "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
            }  
        }

        private void FMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (formOrder.getListOrder().Count > 0)
            {
                e.Cancel = true;
                MessageBox.Show("Vui Lòng Hoàn Thành Xong Đơn Hàng");
            }
            else
            {
                DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn thoát",
     "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    //this.Close();
                }else
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
