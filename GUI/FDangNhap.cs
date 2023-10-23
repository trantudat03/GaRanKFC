using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using System.Timers;
using System.Runtime.Remoting.Contexts;

namespace GUI
{
    public partial class FDangNhap : Form
    {
        public FDangNhap()
        {
            InitializeComponent();
            lbl_ThongBao.Text = "";
            lbl_ThongBaoTDN.Text = "";
        }

        public static List<NguoiDung_DTO> users = QLNguoiDung_BUS.LayDuLieu();

        private void FDangNhap_Load(object sender, EventArgs e)
        {
            txb_TenDangNhap.Text = "admin";
            txb_MatKhau.Text = "12345";
        }

        private void hienThongBao(Control control, string text, Color color)
        {
            control.Text = text;
            control.ForeColor = color;

            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 3000;
             
            timer.Elapsed += (sender, e) =>
            {
                // Gọi hàm khác sau 3 giây
                anThongBao(control);

                // Hủy timer sau khi hoàn thành công việc
                timer.Dispose();
            };

            // Bắt đầu đếm thời gian
            timer.Start();
        }

        private void anThongBao(Control control)
        {
            //control.Text = "";
            control.ForeColor = Color.White;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public bool kiemTraNull()
        {
            if(string.IsNullOrEmpty(txb_TenDangNhap.Text) || string.IsNullOrEmpty(txb_MatKhau.Text))
            {
                return false;
            }

                return true;
        }

        //private void hienThiFMain(NguoiDung_DTO user)
        //{
        //    System.Timers.Timer timer = new System.Timers.Timer();
        //    timer.Interval = 1000;

        //    FMain formMain = new FMain(user);

        //    timer.Elapsed += (sender, e) =>
        //    {
        //        formMain.Show();
                

        //        timer.Dispose();
        //    };
            

        //    timer.Start();// Bắt đầu đếm thời gian
        //}

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            if(kiemTraNull())
            {
                NguoiDung_DTO user = new NguoiDung_DTO();
                
                user = users.Where(s=> s.TENDANGNHAP ==txb_TenDangNhap.Text && s.MATKHAU == txb_MatKhau.Text && s.MATRANGTHAI == "2").FirstOrDefault();
                if(user != null)
                {
                    hienThongBao(lbl_ThongBao, "Đăng nhập thành công!", Color.Green);
                    FMain formMain = new FMain(user);
                    MessageBox.Show("Đăng nhập thành công!");
                    formMain.Show();
                    this.Hide();

                }
                else
                {
                    hienThongBao(lbl_ThongBao, "Sai tên đăng nhập hoặc mật khẩu", Color.Red);
                }
            }
            else
            {
                hienThongBao(lbl_ThongBao, "Vui lòng nhập đầy đủ thông tin!", Color.Red);
                
            }
        }

        private void btn_eyePass_Click(object sender, EventArgs e)
        {
            if(btn_eyePass.BackColor == Color.White)
            {
                txb_MatKhau.UseSystemPasswordChar = false;
                btn_eyePass.BackColor = Color.Transparent;
            }
            else
            {
                if (btn_eyePass.BackColor == Color.Transparent)
                {
                    txb_MatKhau.UseSystemPasswordChar = true;
                    btn_eyePass.BackColor = Color.White;
                }
            }
                    
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn thoát?",
     "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void lbl_QuenMK_Click(object sender, EventArgs e)
        {

        }

        private void FDangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
