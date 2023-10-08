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
using DTO;

namespace GUI
{
    public partial class FQuanLyLoaiSanPham : UserControl
    {
        public FQuanLyLoaiSanPham()
        {
            InitializeComponent();
        }

        private void FQuanLyLoaiSanPham_Load(object sender, EventArgs e)
        {
            //QuanLySanPham_BUS.layLoai().ForEach(x =>
            //{
            //    MessageBox.Show(x.TENLOAISP);
            //});
            SetDataGridView();
        }



        public void SetDataGridView()
        {
            this.dataGridView1.Rows.Clear();
            QuanLySanPham_BUS.layDuLieu().ForEach(s =>
            {
                dataGridView1.Rows.Add(s.MASANPHAM, s.TENSANPHAM, s.GIASANPHAM, s.ANHSANPHAM, (s.THOIHAN + " giờ"), s.SOLUONG, s.LoaiSanPham.TENLOAISP);

            });

        }

        public void them1RowVaoDataGirdView(SanPham_DTO s)
        {
            dataGridView1.Rows.Add(s.MASANPHAM, s.TENSANPHAM, s.GIASANPHAM, s.ANHSANPHAM, (s.THOIHAN + " giờ"), s.SOLUONG, s.LoaiSanPham.TENLOAISP);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SanPham_DTO sp = new SanPham_DTO();
            sp.MALOAISP = textBox1.Text;
            // ten, loai sp, sl, thoi
            QuanLySanPham_BUS.themSanPham(sp);
            them1RowVaoDataGirdView(sp);

        }
    }
}
