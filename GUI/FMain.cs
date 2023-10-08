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
        public FMain()
        {
            InitializeComponent();

        }

        public FMain(NguoiDung_DTO user)
        {
            InitializeComponent();

        }

        private void setStyle()
        {
            panel_Header.BackColor = Color.FromArgb(167, 0, 0);
            panel_sideBar.BackColor = Color.FromArgb(167, 0, 0);
            btn_Order.FlatStyle = FlatStyle.Flat;
            btn_Order.BackColor = Color.Transparent;
            btn_Order.ForeColor = Color.White;
            btn_Order.FlatAppearance.BorderSize = 0;
            btn_Order.FlatAppearance.MouseOverBackColor = Color.Red;
            //btn_Order.FlatAppearance.MouseDownBackColor = Color.Red;
            btn_QuanLy.FlatStyle = FlatStyle.Flat;
            btn_QuanLy.BackColor = Color.Transparent;
            btn_QuanLy.ForeColor = Color.White;
            btn_QuanLy.FlatAppearance.BorderSize = 0;
            btn_QuanLy.FlatAppearance.MouseOverBackColor = Color.Red;
            lbl_UserName.ForeColor = Color.White;
            lbl_logout.ForeColor = Color.Blue;
        }

        private void FMain_Load(object sender, EventArgs e)
        {
            setStyle();
            FOrder formOrder = new FOrder();
            panelMain.Controls.Add(formOrder);
            formOrder.Dock = DockStyle.Fill;
        }

        private void btn_Order_MouseHover(object sender, EventArgs e)
        {
            
            
        }

        private void groupBoxUser_Enter(object sender, EventArgs e)
        {

        }

        private void btn_Order_Click(object sender, EventArgs e)
        {

        }
    }
}
