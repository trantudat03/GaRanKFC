using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;



namespace GUI
{
    public partial class FQuanLySanPham : UserControl
    {

        private static string linkImg = string.Empty;
        public static bool checkThayDoi = false;
        public static string chosen_File = string.Empty;
        public static string fileNameOld = string.Empty;
        public static SanPham_DTO SPSelect = new SanPham_DTO();
        public static int clickIndexRowSP = -1;
        public static int clickIndexRowLoai = -1;
        public static LoaiSanPham_DTO LoaiSelect = new LoaiSanPham_DTO();
        public static int checkChucNangPage3 = 0;
        public FQuanLySanPham()
        {
            InitializeComponent();
        }

        public void setCMBLocLoaiSP()
        {
            List<LoaiSanPham_DTO> list = new List<LoaiSanPham_DTO>();
            LoaiSanPham_DTO item = new LoaiSanPham_DTO();
            item.TENLOAISP = "Tất cả";
            item.MALOAISP = "0";
            list.Add(item);
            List<LoaiSanPham_DTO> resultList = list.Concat(QuanLyLoaiSP_BUS.LayDuLieu()).ToList();

            cmb_LocLoaiSP.DataSource = null;
            cmb_LocLoaiSP.DataSource = resultList;
            cmb_LocLoaiSP.SelectedIndex = 0;
            cmb_LocLoaiSP.DisplayMember = "TENLOAISP";
            cmb_LocLoaiSP.ValueMember = "MALOAISP";
        }

        private void FQuanLyLoaiSanPham_Load(object sender, EventArgs e)
        {

            setDefaut();
            setDefautPage2();
            setDefautPage3();
            SetDataGridView(QuanLySanPham_BUS.layDuLieu());
            setDGVLoaiSanPham(QuanLyLoaiSP_BUS.soLuongSanPhamTheoLoai());
            setCMBLocLoaiSP();
            if (cmb_SuaLoaiSP.DataSource == null)
            {
                cmb_SuaLoaiSP.DataSource = QuanLyLoaiSP_BUS.LayDuLieu();
                cmb_SuaLoaiSP.DisplayMember = "TENLOAISP";
                cmb_SuaLoaiSP.ValueMember = "MALOAISP";
            }
            cmb_SuaLoaiSP.SelectedIndex = 0;

            if (cmb_SuaTrangThai.DataSource == null)
            {
                cmb_SuaTrangThai.DataSource = QLTrangThai_BUS.layDuLieu();
                cmb_SuaTrangThai.DisplayMember = "TENTRANGTHAI";
                cmb_SuaTrangThai.ValueMember = "MATRANGTHAI";

            }

            if (cmb_LoaiSanPham.DataSource == null)
            {
                cmb_LoaiSanPham.DataSource = QuanLyLoaiSP_BUS.LayDuLieu();
                cmb_LoaiSanPham.DisplayMember = "TENLOAISP";
                cmb_LoaiSanPham.ValueMember = "MALOAISP";
            }
            cmb_LoaiSanPham.SelectedIndex = 0;

            if (cmb_TrangThai.DataSource == null)
            {
                cmb_TrangThai.DataSource = QLTrangThai_BUS.layDuLieu();
                cmb_TrangThai.DisplayMember = "TENTRANGTHAI";
                cmb_TrangThai.ValueMember = "MATRANGTHAI";

            }
            cmb_TrangThai.SelectedIndex = 0;
            cmb_SuaTrangThai.SelectedIndex = 0;
            lbl_ThongBao2.Text = string.Empty;
            lbl_thongBaoPage3.Text = string.Empty;
            lbl_ThongBao.Text = string.Empty;
        }

        private void setDGVLoaiSanPham(List<LoaiSanPham_DTO> list) 
        {
            if(list.Count>0)
            {
                int index = 0;
                list.ForEach(l =>
                {
                    
                   
                    if(l.TONGSOLUON> 0)
                    {
                        dgv_LoaiSanPham.Rows.Add(l.MALOAISP, l.TENLOAISP, l.TONGSOLUON);
                    }
                    else
                    {
                        dgv_LoaiSanPham.Rows.Add(l.MALOAISP, l.TENLOAISP, 0);
                    }
                    dgv_LoaiSanPham.Rows[index].Tag = l;
                    index++;
                });
            }
        }

        private void setDefautPage3()
        {
            txb_LoaiSPTen.Text = string.Empty;
            groupBoxLoaiSP.Visible = false;
            checkChucNangPage3 = 0;
            clickIndexRowLoai = -1;
        }
        private void setDefautPage2()
        {
            txb_SuaGiaSP.Text = string.Empty;
            txb_SuaTenSP.Text = string.Empty;
            groupBox_Sua.Visible = false;
            pcb_HienThiAnhSp.Visible = false;
            lbl_TenSanPham.Text = string.Empty;
            linkImg = string.Empty;
            chosen_File = string.Empty;
            clickIndexRowSP = -1;
        }

        private void setDefaut()
        {
            txb_GiaSanPham.Text = string.Empty;
            txb_TenSanPham.Text = string.Empty;
            nud_HanSanPham.Value = 0;
            PB_AnhSanPham.Image = Properties.Resources.imgIcon;
            
            linkImg = string.Empty;
        }

        private bool checkNullPage2()
        {
            if(txb_SuaTenSP.Text == string.Empty || txb_SuaGiaSP.Text == string.Empty || nud_SuaHanSP.Value<=0)
            {
                return false;
            }
            return true;
        }

        private void hienThongBao(Control control, string text, Color color)
        {
            control.Text = text;
            control.ForeColor = color;

            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 2000;

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




        public void SetDataGridView(List<SanPham_DTO> list)
        {
            this.dgv_DanhSach.Rows.Clear();
            int index = 0;
            list.ForEach((s) =>
            {

                dgv_DanhSach.Rows.Add(s.MASANPHAM, s.TENSANPHAM, s.GIASANPHAM, s.ANHSANPHAM, (s.THOIHAN + " giờ"),  s.LoaiSanPham.TENLOAISP, s.TRANGTHAI.TENTRANGTHAI);
                dgv_DanhSach.Rows[index].Tag = (SanPham_DTO)s;
                index++;
            });

        }

        public void them1RowVaoDataGirdView(SanPham_DTO s)
        {
            dgv_DanhSach.Rows.Add(s.MASANPHAM, s.TENSANPHAM, s.GIASANPHAM, s.ANHSANPHAM, (s.THOIHAN + " giờ"), s.LoaiSanPham.TENLOAISP, s.TRANGTHAI.TENTRANGTHAI);
        }

        
        public static string RemoveAfterDot(string input)
        {
            string[] parts = input.Split('.');
            if (parts.Length > 0)
            {
                return parts[0];
            }
            else
            {
                return input;
            }
        }


        private void GetFile(PictureBox p)
        {

            System.Windows.Forms.OpenFileDialog openImage = new OpenFileDialog();
            openImage.Title = "Select your image";
            openImage.InitialDirectory = "C:";
            openImage.Filter = "Image Only(.jpg; *.jpeg; *.gif; *.bmp; *.png)|.jpg; *.jpeg; *.gif; *.bmp; *.png";
            openImage.AutoUpgradeEnabled = true;
            if (openImage.ShowDialog() == DialogResult.OK)
            {
                chosen_File = openImage.FileName;

                string filename = System.IO.Path.GetFileName(chosen_File);
                string inputExt = (Path.GetExtension(filename).ToLower());
                
                Invoke((MethodInvoker)delegate
                {
                    Image image = Image.FromFile(chosen_File);
                    p.Image = image;
                    linkImg = filename;
                });
                
            }
            
        }

        private void PB_AnhSanPham_Click(object sender, EventArgs e)
        {
            GetFile(PB_AnhSanPham);
        }

        private bool checkNull()
        {
            if(txb_GiaSanPham.Text == string.Empty || txb_TenSanPham.Text == string.Empty || linkImg==string.Empty)
            {
                return false;
            }
            return true;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if(checkNull() )
            {
                try
                {
                    
                    System.IO.File.Copy(chosen_File, @"..\\..\\Resources\\" + linkImg);

                    
                }
                catch
                {
                    hienThongBao(lbl_ThongBao, "Lỗi thêm ảnh", Color.Red);
                }
                SanPham_DTO item = new SanPham_DTO();
                item.TENSANPHAM = txb_TenSanPham.Text;
                item.MASANPHAM = "1";
                item.MALOAISP = cmb_LoaiSanPham.SelectedValue.ToString();
                item.MATRANGTHAI = cmb_TrangThai.SelectedValue.ToString();
                item.ANHSANPHAM = linkImg;
                item.GIASANPHAM = int.Parse(txb_GiaSanPham.Text);
                item.THOIHAN = (int)nud_HanSanPham.Value;
                if (QuanLySanPham_BUS.themSanPham(item) == 1)
                {
                    hienThongBao(lbl_ThongBao, "Thêm sản phẩm thành công", Color.Green);
                    setDefaut();
                }
                else
                {
                    hienThongBao(lbl_ThongBao, "Thêm sản phẩm thất bại", Color.Red);
                }

            }
            else
            {
                hienThongBao(lbl_ThongBao, "Nhập đầy đủ thông tin", Color.Red);
            }
            
            
        }

        private void dgv_DanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0) 
            {
                DataGridViewRow selectedRow = dgv_DanhSach.Rows[e.RowIndex];
                clickIndexRowSP = e.RowIndex;
                 SPSelect = new SanPham_DTO();
                 SPSelect = selectedRow.Tag as SanPham_DTO;

                //MessageBox.Show(item.TENSANPHAM);
                if(SPSelect != null)
                {
                    try
                    {
                        pcb_HienThiAnhSp.Visible = true;
                        lbl_TenSanPham.Text = SPSelect.TENSANPHAM;
                        Invoke((MethodInvoker)delegate
                        {
                            if (SPSelect.ANHSANPHAM != string.Empty)
                            {
                                Image image = Image.FromFile(@"..\\..\\Resources\\" + SPSelect.ANHSANPHAM);
                                pcb_HienThiAnhSp.Image = image;
                                pcb_SuaAnhSP.Image = image;
                                fileNameOld = SPSelect.ANHSANPHAM;
                            }
                            else
                            {
                                Image image = Properties.Resources.imgIcon;
                                pcb_HienThiAnhSp.Image = image;
                                pcb_SuaAnhSP.Image = image;
                                
                            }
                        });
                    }
                    catch
                    {
                        hienThongBao(lbl_ThongBao2, "Lỗi hiện hình ảnh", Color.Red);
                    }
                    
                    cmb_SuaLoaiSP.Text = SPSelect.LoaiSanPham.TENLOAISP;
                    txb_SuaTenSP.Text = SPSelect.TENSANPHAM;
                    txb_SuaGiaSP.Text = SPSelect.GIASANPHAM.ToString();
                    cmb_SuaTrangThai.Text = SPSelect.TRANGTHAI.TENTRANGTHAI;
                    nud_SuaHanSP.Value = SPSelect.THOIHAN;
                }

                
            }
            
        }

        private void txb_SearchDGV_TextChanged(object sender, EventArgs e)
        {
            if (cmb_LocLoaiSP.SelectedValue.ToString() != "0")
                SetDataGridView(QuanLySanPham_BUS.timTheoTenVaLoai(txb_SearchDGV.Text, cmb_LocLoaiSP.SelectedValue.ToString()));
            else
                SetDataGridView(QuanLySanPham_BUS.timTheoTen(txb_SearchDGV.Text));
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if(!groupBox_Sua.Visible) 
            {
                groupBox_Sua.Visible = true;
            }
        }

        private void setNullControl(Control c)
        {
            foreach(TextBox t in c.Controls)
            {
                t.Text = string.Empty;
            }
            foreach (ComboBox t in c.Controls)
            {
                t.SelectedIndex = 0;
            }
            foreach (PictureBox t in c.Controls)
            {
                t.Image = (Image)Properties.Resources.imgIcon;
            }
            foreach (NumericUpDown t in c.Controls)
            {
                t.Value = 1;
            }
        }

        private void btn_LuuSua_Click(object sender, EventArgs e)
        {
            if(SPSelect.MASANPHAM != null && checkNullPage2())
            {
                
               
                    SPSelect.TENSANPHAM = txb_SuaTenSP.Text;
                    SPSelect.MALOAISP = cmb_SuaLoaiSP.SelectedValue.ToString();
                    SPSelect.MATRANGTHAI = cmb_SuaTrangThai.SelectedValue.ToString();
                    SPSelect.TRANGTHAI.MATRANGTHAI = cmb_SuaTrangThai.SelectedValue.ToString();
                    SPSelect.TRANGTHAI.TENTRANGTHAI = cmb_SuaTrangThai.Text;
                    SPSelect.LoaiSanPham.MALOAISP = cmb_SuaLoaiSP.SelectedValue.ToString();
                    SPSelect.LoaiSanPham.TENLOAISP = cmb_SuaLoaiSP.Text;
                    SPSelect.GIASANPHAM = int.Parse(txb_SuaGiaSP.Text);
                    if (linkImg != string.Empty)
                    {
                        SPSelect.ANHSANPHAM = linkImg;
                    }
                    SPSelect.THOIHAN = (int)nud_SuaHanSP.Value;

                    if (QuanLySanPham_BUS.suaSanPham(SPSelect) == 1)
                    {
                        
                        if (clickIndexRowSP >= 0)
                        {
                            dgv_DanhSach.Rows[clickIndexRowSP].Tag = SPSelect;
                            dgv_DanhSach.Rows[clickIndexRowSP].Cells[0].Value = SPSelect.MASANPHAM;
                            dgv_DanhSach.Rows[clickIndexRowSP].Cells[1].Value = SPSelect.TENSANPHAM;
                            dgv_DanhSach.Rows[clickIndexRowSP].Cells[2].Value = SPSelect.GIASANPHAM;
                            dgv_DanhSach.Rows[clickIndexRowSP].Cells[3].Value = SPSelect.ANHSANPHAM;
                            dgv_DanhSach.Rows[clickIndexRowSP].Cells[4].Value = SPSelect.THOIHAN + " Giờ";
                            dgv_DanhSach.Rows[clickIndexRowSP].Cells[5].Value = SPSelect.LoaiSanPham.TENLOAISP;
                            dgv_DanhSach.Rows[clickIndexRowSP].Cells[6].Value = SPSelect.TRANGTHAI.TENTRANGTHAI;
                        }
                        hienThongBao(lbl_ThongBao2, "Sửa Thành Công", Color.Green);
                        try
                        {
                            if (linkImg != "" && chosen_File != "")
                            {
                                System.IO.File.Copy(chosen_File, @"..\\..\\Resources\\" + linkImg);

                            }
                            setDefautPage2();
                        }catch
                        {
                            hienThongBao(lbl_ThongBao2, "Sửa Thành Công", Color.Green);
                            setDefautPage2();
                        }
                       
                        
                    }
                    else
                    {
                        hienThongBao(lbl_ThongBao2, "Sửa Thất Bại", Color.Red);
                    }

                    
                    
                    // chua set null, chua setdefaut, chua capnhat dgv
              



            }
            

            
        }

        private void pcb_SuaAnhSP_Click(object sender, EventArgs e)
        {
            GetFile(pcb_SuaAnhSP);
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show(SPSelect.MASANPHAM);
            if (SPSelect.MASANPHAM != null)
            {
                string checkXoa = QuanLySanPham_BUS.kiemTraSanPhamCoTheXoa(SPSelect);
                if (checkXoa== null)
                {
                    MessageBox.Show("Sản phẩm không thể xóa, bạn có thể thay đổi trạng thái của sản phẩm");
                }
                else
                {
                    DialogResult result = MessageBox.Show($"Bạn có đồng ý xóa Sản phẩm {SPSelect.TENSANPHAM}",
     "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        if (QuanLySanPham_BUS.xoaSanPham(checkXoa) == 1)
                        {
                            if (clickIndexRowSP >= 0)
                            {
                                dgv_DanhSach.Rows.RemoveAt(clickIndexRowSP);
                            }
                            hienThongBao(lbl_ThongBao2, "Xóa Thành Công", Color.Green);
                            setDefautPage2();
                        }
                        else
                        {
                            hienThongBao(lbl_ThongBao2, "Xóa Thất Bại", Color.Red);
                        }
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("chon sp can xoa");
            }
        }

        private bool checkNullPage3()
        {
            if(txb_LoaiSPTen.Text == string.Empty)
            {
                return false;
            }
            return true;
        }

        private void btn_ThemLoaiSP_Click(object sender, EventArgs e)
        {
            if(checkChucNangPage3 != 1)
            {
                checkChucNangPage3 = 1;
            }
            groupBoxLoaiSP.Visible = true;

        }

        private void btn_SuaLoaiSanPham_Click(object sender, EventArgs e)
        {
            if (checkChucNangPage3 != 2)
            {
                checkChucNangPage3 = 2;
            }
            groupBoxLoaiSP.Visible = true;
            if(LoaiSelect== null)
            {
                hienThongBao(lbl_thongBaoPage3, "Vui Lòng chọn Loại sản phẩm cần sửa", Color.Red);
            }
        }

        private void addDGVLoaiSp(LoaiSanPham_DTO item)
        {
            dgv_LoaiSanPham.Rows.Add(item.MALOAISP, item.TENLOAISP, item.TONGSOLUON);
        }
        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            if (checkNullPage3())
            {
                
                if (checkChucNangPage3 ==1)
                {
                    LoaiSelect = new LoaiSanPham_DTO();
                    LoaiSelect.MALOAISP = null;
                    LoaiSelect.TENLOAISP = txb_LoaiSPTen.Text;
                    LoaiSelect.TONGSOLUON = 0;
                    string maLoai = QuanLyLoaiSP_BUS.themLoaiSP(LoaiSelect);
                    if ( maLoai!= null )
                    {
                        LoaiSelect.MALOAISP = maLoai;
                        addDGVLoaiSp(LoaiSelect);
                        hienThongBao(lbl_thongBaoPage3, "Thêm Thành Công", Color.Green);
                        setDefautPage3();
                    }
                    else
                    {
                        hienThongBao(lbl_thongBaoPage3, "Lỗi trong quá trình thêm", Color.Green);
                    }
                }
                else
                {
                    if(checkChucNangPage3 == 2)
                    {
                        if(LoaiSelect.MALOAISP != null)
                        {
                            LoaiSelect.TENLOAISP = txb_LoaiSPTen.Text;
                            string checkSua = QuanLyLoaiSP_BUS.suaLoaiSp(LoaiSelect);
                            if(checkSua !=null )
                            {
                                dgv_LoaiSanPham.Rows[clickIndexRowLoai].Cells[1].Value = LoaiSelect.TENLOAISP;
                                hienThongBao(lbl_thongBaoPage3, "Sửa thành công", Color.Green);
                                setDefautPage3();
                            }
                        }
                        else
                        {
                            hienThongBao(lbl_thongBaoPage3, "Chọn Loại sản phẩm cần sửa", Color.Red);
                        }
                        
                    } 
                }
            }
            else
            {
                hienThongBao(lbl_thongBaoPage3, "Nhập tên loại sản phẩm", Color.Red);
            }
        }

        private void dgv_LoaiSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >=0)
            {
                LoaiSelect = new LoaiSanPham_DTO();
                LoaiSelect = dgv_LoaiSanPham.Rows[e.RowIndex].Tag as LoaiSanPham_DTO;
                if (LoaiSelect != null)
                {
                    txb_LoaiSPTen.Text = dgv_LoaiSanPham.Rows[e.RowIndex].Cells[1].Value.ToString();
                    clickIndexRowLoai = e.RowIndex;
                }
            }
            
        }

        private void btn_XoaLoaiSP_Click(object sender, EventArgs e)
        {
            if(LoaiSelect.MALOAISP != null)
            {
                string checkXoa = QuanLyLoaiSP_BUS.kiemTraCoTheXoa(LoaiSelect);
                if(checkXoa != null)
                {
                    DialogResult result = MessageBox.Show($"Bạn có đồng ý xóa Loại {LoaiSelect.TENLOAISP} có mã {LoaiSelect.MALOAISP}",
                        "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {

                        if(QuanLyLoaiSP_BUS.xoaLoaiSanPham(checkXoa)==1)
                        {
                            dgv_LoaiSanPham.Rows.RemoveAt(clickIndexRowLoai);
                            hienThongBao(lbl_thongBaoPage3, "Xóa Thành Công", Color.Green);
                            setDefautPage3();
                        }

                    }
                }
                else
                {
                    hienThongBao(lbl_thongBaoPage3, "Loại sản phẩm này không thể xóa ", Color.Red);
                    setDefautPage3();
                }
                
            }
            else
            {
                hienThongBao(lbl_thongBaoPage3, "Chọn Loại sản phẩm cần xóa", Color.Red);
            }
            
        }

        private void cmb_LocLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            try
            {
                if(cmb_LocLoaiSP.SelectedIndex == 0)
                {
                    SetDataGridView(QuanLySanPham_BUS.layDuLieu());
                }
                else
                {
                    SetDataGridView(QuanLySanPham_BUS.layTheoLoai(cmb_LocLoaiSP.SelectedValue.ToString()));
                }
            }
            catch
            {

            }
        }
    }
}
