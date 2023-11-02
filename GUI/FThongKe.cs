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
using System.Windows.Forms.DataVisualization.Charting;
using BUS;
using DTO;
using DTO.ThongKe_DTO;

namespace GUI
{
    public partial class FThongKe : UserControl
    {

        List<string> listThongKe = new List<string>();
        DateTime date = DateTime.Now;
        

        public FThongKe()
        {
            InitializeComponent();
            listThongKe.Add($"Ngày {date.Day}/{date.Month}/{date.Year}");
            listThongKe.Add($"Tháng {date.Month}/{date.Year}");
            listThongKe.Add($"Năm {date.Year}");
            listThongKe.Add("Theo Khoảng Thời Gian");
            setDefaut();
            
        }

        public void setData()
        {
            setDataGridView(cmb_ListThongKe.SelectedIndex);
            setBieuDoSanPham(cmb_DateTimeSP.SelectedIndex);
        }
        public void setDefaut()
        {
            cmb_ListThongKe.Items.Clear();
            cmb_ListThongKe.DataSource = listThongKe;
            cmb_ListThongKe.SelectedIndex = 0;
            cmb_DateTimeSP.Items.Clear();
            cmb_DateTimeSP.DataSource = listThongKe;
            cmb_DateTimeSP.SelectedIndex = 0;
            //setDataGridView(0);
            groupBox_DateTime.Visible = false;
            groupBox_DateTimeSP.Visible = false;
            dateTimePickerFrom.Value = dateTimePickerFrom.Value.Date;
            dateTimePickerTo.Value = dateTimePickerTo.Value.Date.AddDays(1).AddTicks(-1);
           
        }

        public string themDauChamVaoSo(int number)
        {

            string numberStr = number.ToString("N0", CultureInfo.InvariantCulture);
            numberStr = numberStr.Replace(",", ".");
            return numberStr;

        }
        private int tinhTongDoanhThu(List<DonHangThongKe_DTO> list)
        {
            int tong = 0;
            int length = dgv_ThongKe.Rows.Count;
            if (list.Count > 0)
            {
                list.ForEach(d =>
                {
                    int total = d.TONGGIA - d.SOTIENGIAM;
                    if (total < 0)
                        total = 0;
                    tong += total;
                });

            }

            
            return tong;
        }

        private int tinhTongTienKhuyenMai(List<DonHangThongKe_DTO> list)
        {
            int tong = 0;

            if(list.Count > 0)
            {
                list.ForEach(d =>
                {
                    if (d.SOTIENGIAM > d.TONGGIA)
                        tong += d.TONGGIA;
                    else
                        tong += d.SOTIENGIAM;
                    
                });
            }
            return tong;
        }
        public void setDataGridView(int chose)
        {
            List < DonHangThongKe_DTO > list = new List<DonHangThongKe_DTO> ();
            dgv_ThongKe.Rows.Clear();
            if (chose == 0)
            {
                list = ThongKe_BUS.thongKeTheoNgay(date);
            }
            else
            {
                if(chose == 1)
                {
                    list = ThongKe_BUS.thongKeTheoThang(date);
                }
                else
                {
                    if(chose == 3)
                    {
                        list = ThongKe_BUS.thongKeTheoKhoangThoiGian(dateTimePickerFrom.Value, dateTimePickerTo.Value);
                    }
                    else
                    {
                        if (chose == 2)
                        {
                            list = ThongKe_BUS.thongKeTheoNam(date);
                        }
                    }
                }
            }
            if(list.Count >0 )
            {
                list.ForEach(d =>
                {
                    // MessageBox.Show(x.Khoa.TenKhoa);
                    
                    dgv_ThongKe.Rows.Add(d.MADONHANG, d.TENNGUOIDUNG, d.TENKHACHHANG, d.TENKHUYENMAI, d.TONGGIA, d.SOTIENGIAM, d.THOIGIAN);
                });
            }

            lbl_TongDoanhThu.Text = themDauChamVaoSo(tinhTongDoanhThu(list)) + " VNĐ";
            lbl_TongKhuyenMai.Text = themDauChamVaoSo(tinhTongTienKhuyenMai(list)) + " VNĐ";

        }

        private void FThongKe_Load(object sender, EventArgs e)
        {

        }

        private SanPhamThongKe_DTO timMinSL(List<SanPhamThongKe_DTO> list)
        {
            SanPhamThongKe_DTO minSP = new SanPhamThongKe_DTO();
            

            if(list.Count >0 && minSP != null)
            {
                minSP = list.First();
                list.ForEach(s =>
                {
                    if(s.SOLUONG < minSP.SOLUONG)
                    {
                        minSP = s;
                    }
                });
            }
            return minSP;
        }

        private SanPhamThongKe_DTO timMaxSL(List<SanPhamThongKe_DTO> list)
        {
            SanPhamThongKe_DTO maxSP = new SanPhamThongKe_DTO();
            if(list.Count>0)
            {
                maxSP = list.First();

                if (list.Count > 0 && maxSP != null)
                {
                    list.ForEach(s =>
                    {
                        if (s.SOLUONG > maxSP.SOLUONG)
                        {
                            maxSP = s;
                        }
                    });
                }
                
            }
            return maxSP;
        }

        private List<SanPhamThongKe_DTO> setChieuCao(List<SanPhamThongKe_DTO> list, int maxHeight)
        {
            SanPhamThongKe_DTO max = timMaxSL(list);
            SanPhamThongKe_DTO min = timMinSL(list);
            
            if(min != null && max != null && maxHeight >0)
            {
                double heSo =(double)maxHeight / ((double)max.SOLUONG/ (double)min.SOLUONG);
                list.ForEach(s =>
                {
                    double goc = (double)s.SOLUONG / (double)min.SOLUONG;
                    s.CHIEUCAO =(int)Math.Round(goc * heSo) ;
                });

                return list;
            }

            return null;
        }

        private void setBieuDoSanPham(int chose)
        {
            BieuDoCotSpBanChay.Controls.Clear();
            //panel_NameColumn.Controls.Clear();
            
            List<SanPhamThongKe_DTO> list = new List<SanPhamThongKe_DTO>();
            
            if (chose == 0)
            {
                list = new List<SanPhamThongKe_DTO>();
                list = ThongKe_BUS.sanPhamTheoNgay(date);
            }
            else
            {
                if (chose == 1)
                {
                    list = new List<SanPhamThongKe_DTO>();
                    list = ThongKe_BUS.sanPhamTheoThang(date);
                }
                else
                {
                    if(chose == 2)
                    {
                        list = new List<SanPhamThongKe_DTO>();
                        list = ThongKe_BUS.sanPhamTheoNam(date);
                    }
                    else
                    {
                        if(chose==3)
                        {
                            list = new List<SanPhamThongKe_DTO>();
                            list = ThongKe_BUS.sanPhamTheoKhoangThoiGian(dateTimePickerFromSP.Value, dateTimePickerToSP.Value);
                        }
                    }
                }
            }
            //MessageBox.Show(list.Count.ToString());
            int x = 10;
            
            int height = 0;
            int width = 45;
            int space = 30;
            List<SanPhamThongKe_DTO> listHeight =  new List<SanPhamThongKe_DTO>();
            listHeight = setChieuCao(list, BieuDoCotSpBanChay.Height-120);
            if(listHeight != null)
            {
                listHeight.ForEach(s =>
                {
                    TextBox textBox = new TextBox();
                    textBox.Multiline = true; // Cho phép viết nhiều dòng
                    textBox.ReadOnly = true; // Không cho phép sửa đổi nội dung
                    textBox.ScrollBars = ScrollBars.None;
                    textBox.Text = s.TENSANPHAM;
                    textBox.Size = new Size(width + 18, 80);
                    textBox.Location = new Point(x - 4, BieuDoCotSpBanChay.Height - textBox.Height);
                    textBox.BorderStyle = BorderStyle.None;
                    Panel p = new Panel();
                    height = s.CHIEUCAO;
                    
                    p.Location = new Point(x, BieuDoCotSpBanChay.Height - height - textBox.Height);
                    p.Size = new Size(width, height);
                    p.BackColor = Color.Red;
                    ToolTip toolTipNameColumn = new ToolTip();
                    toolTipNameColumn.SetToolTip(p, s.TENSANPHAM + "(" + s.SOLUONG + ")");
                    toolTipNameColumn.ForeColor = Color.Black;
                    Label l = new Label();// so luong
                    l.Text = s.SOLUONG.ToString();
                    l.Font = new Font("Arial", 16, FontStyle.Regular);
                    l.AutoSize = true;
                    l.Location = new Point(x + 5, BieuDoCotSpBanChay.Height - height - 25 - textBox.Height);
                    l.TextAlign = ContentAlignment.MiddleCenter;

                    // panel_NameColumn.Controls.Add(textBox);
                    BieuDoCotSpBanChay.Controls.Add(textBox);
                    BieuDoCotSpBanChay.Controls.Add(l);
                    BieuDoCotSpBanChay.Controls.Add(p);// panel cha

                    x += space + width;
                });
            }
            else
            {
                if (list.Count > 0)
                {

                    list.ForEach(s =>
                    {
                        TextBox textBox = new TextBox();
                        textBox.Multiline = true; // Cho phép viết nhiều dòng
                        textBox.ReadOnly = true; // Không cho phép sửa đổi nội dung
                        textBox.ScrollBars = ScrollBars.None;
                        textBox.Text = s.TENSANPHAM;
                        textBox.Size = new Size(width + 18, 80);
                        textBox.Location = new Point(x - 4, BieuDoCotSpBanChay.Height - textBox.Height);
                        textBox.BorderStyle = BorderStyle.None;
                        Panel p = new Panel();
                        height = (s.SOLUONG * 15);
                        if (height > BieuDoCotSpBanChay.Height - textBox.Height)
                        {
                            height = BieuDoCotSpBanChay.Height - textBox.Height - 100;
                        }
                        p.Location = new Point(x, BieuDoCotSpBanChay.Height - height - textBox.Height);
                        p.Size = new Size(width, height);
                        p.BackColor = Color.Red;
                        ToolTip toolTipNameColumn = new ToolTip();
                        toolTipNameColumn.SetToolTip(p, s.TENSANPHAM + "(" + s.SOLUONG + ")");
                        toolTipNameColumn.ForeColor = Color.Black;
                        Label l = new Label();// so luong
                        l.Text = s.SOLUONG.ToString();
                        l.Font = new Font("Arial", 16, FontStyle.Regular);
                        l.AutoSize = true;
                        l.Location = new Point(x + 5, BieuDoCotSpBanChay.Height - height - 25 - textBox.Height);
                        l.TextAlign = ContentAlignment.MiddleCenter;

                        // panel_NameColumn.Controls.Add(textBox);
                        BieuDoCotSpBanChay.Controls.Add(textBox);
                        BieuDoCotSpBanChay.Controls.Add(l);
                        BieuDoCotSpBanChay.Controls.Add(p);// panel cha

                        x += space + width;
                    });

                }
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmb_ListThongKe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmb_ListThongKe.SelectedIndex != 3)
            {
                
                setDataGridView(cmb_ListThongKe.SelectedIndex);
                if(groupBox_DateTime.Visible == true)
                {
                    groupBox_DateTime.Visible = false;
                }
            }
            else
            {
                groupBox_DateTime.Visible = true;
                setDataGridView(3);
            }
        }

        private void dateTimePickerFrom_ValueChanged(object sender, EventArgs e)
        {
            setDataGridView(3);
        }

        private void dateTimePickerTo_ValueChanged(object sender, EventArgs e)
        {
            setDataGridView(3);
        }

        private void cmb_DateTimeSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if( cmb_DateTimeSP.SelectedIndex != 3)
            {
                setBieuDoSanPham(cmb_DateTimeSP.SelectedIndex);
                groupBox_DateTimeSP.Visible = false;
            }
            else
            {
                dateTimePickerFromSP.Value = dateTimePickerFrom.Value.Date;
                dateTimePickerToSP.Value = dateTimePickerTo.Value.Date.AddDays(1).AddTicks(-1);
                groupBox_DateTimeSP.Visible = true;
                setBieuDoSanPham(3);
            }
        }

        private void dateTimePickerToSP_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerFromSP.Value = dateTimePickerFromSP.Value.Date;
            dateTimePickerToSP.Value = dateTimePickerToSP.Value.Date.AddDays(1).AddTicks(-1);
            setBieuDoSanPham(3);
        }

        private void dateTimePickerFromSP_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerFromSP.Value = dateTimePickerFromSP.Value.Date;
            dateTimePickerToSP.Value = dateTimePickerToSP.Value.Date.AddDays(1).AddTicks(-1);
            setBieuDoSanPham(3);
        }

       
    }
}
