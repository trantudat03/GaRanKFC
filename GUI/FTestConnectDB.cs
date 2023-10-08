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
namespace GUI
{
    public partial class FTestConnectDB : Form
    {
        public FTestConnectDB()
        {
            InitializeComponent();
            dataGridView1.DataSource = QLNguoiDung_BUS.LayDuLieu();
        }

        private void FTestConnectDB_Load(object sender, EventArgs e)
        {

        }
    }
}
