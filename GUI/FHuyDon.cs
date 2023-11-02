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


namespace GUI
{
    public partial class FHuyDon : Form
    {
        public static bool checkHuy = false;
        public static NguoiDung_DTO user = new NguoiDung_DTO();
        public FHuyDon()
        {
            InitializeComponent();
        }

        public void setUser(NguoiDung_DTO u)
        {
            user = u;
        }
        public bool getCheckHuy()
        {
            return checkHuy;
        }

        public string getLyDo()
        {
            return txb_LyDo.Text;
        }
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if(txb_LyDo.Text != string.Empty )
            {
                checkHuy = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập lý do thanh toán");
            }
            
        }
    }
}
