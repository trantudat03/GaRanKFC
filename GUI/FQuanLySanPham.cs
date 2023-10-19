using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
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
        public static SanPham_DTO itemSelect = new SanPham_DTO();
        public FQuanLySanPham()
        {
            InitializeComponent();
        }

       

        private void FQuanLyLoaiSanPham_Load(object sender, EventArgs e)
        {

            setDefaut();
            setDefautPage2();
            SetDataGridView(QuanLySanPham_BUS.layDuLieu());
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
                cmb_SuaTrangThai.ValueMember = "IDTRANGTHAI";

            }
            cmb_SuaTrangThai.SelectedIndex = 0;
            lbl_ThongBao2.Text = string.Empty;
        }

        private void setDefautPage2()
        {
            txb_SuaGiaSP.Text = string.Empty;
            txb_SuaTenSP.Text = string.Empty;
            groupBox_Sua.Visible = false;
            pcb_HienThiAnhSp.Visible = false;
            linkImg = string.Empty;
            chosen_File = string.Empty;
        }

        private void setDefaut()
        {
            txb_GiaSanPham.Text = string.Empty;
            txb_TenSanPham.Text = string.Empty;
            nud_HanSanPham.Value = 0;
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
            cmb_TrangThai.ValueMember = "IDTRANGTHAI";
                
            }
            cmb_TrangThai.SelectedIndex = 0;
            PB_AnhSanPham.Image = Properties.Resources.imgIcon;
            lbl_ThongBao.Text = string.Empty;
            linkImg = string.Empty;
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
            if(txb_GiaSanPham.Text == string.Empty || txb_TenSanPham.Text == string.Empty)
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
                item.IDTRANGTHAI = int.Parse(cmb_TrangThai.SelectedValue.ToString());
                item.ANHSANPHAM = linkImg;
                item.GIASANPHAM = int.Parse(txb_GiaSanPham.Text);
                item.THOIHAN = (int)nud_HanSanPham.Value;
                if (QuanLySanPham_BUS.themSanPham(item) == 1)
                {
                    hienThongBao(lbl_ThongBao, "Thêm sản phẩm thành công", Color.Green);
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

                 itemSelect = new SanPham_DTO();
                 itemSelect = selectedRow.Tag as SanPham_DTO;

                //MessageBox.Show(item.TENSANPHAM);
                if(itemSelect != null)
                {
                    pcb_HienThiAnhSp.Visible = true;
                    Invoke((MethodInvoker)delegate
                    {
                        if(itemSelect.ANHSANPHAM!= string.Empty)
                        {
                            Image image = Image.FromFile(@"..\\..\\Resources\\" + itemSelect.ANHSANPHAM);
                            pcb_HienThiAnhSp.Image = image;
                            pcb_SuaAnhSP.Image = image;
                            fileNameOld = itemSelect.ANHSANPHAM;
                        }
                        

                    });
                    cmb_SuaLoaiSP.Text = itemSelect.LoaiSanPham.TENLOAISP;
                    txb_SuaTenSP.Text = itemSelect.TENSANPHAM;
                    txb_SuaGiaSP.Text = itemSelect.GIASANPHAM.ToString();
                    cmb_SuaTrangThai.Text = itemSelect.TRANGTHAI.TENTRANGTHAI;
                    nud_SuaHanSP.Value = itemSelect.THOIHAN;
                }

                
            }
            
        }

        private void txb_SearchDGV_TextChanged(object sender, EventArgs e)
        {
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
            if(itemSelect != null)
            {
                
                try
                {
                    itemSelect.TENSANPHAM = txb_SuaTenSP.Text;
                    itemSelect.MALOAISP = cmb_SuaLoaiSP.SelectedValue.ToString();
                    itemSelect.IDTRANGTHAI = int.Parse(cmb_SuaTrangThai.SelectedValue.ToString());
                    itemSelect.GIASANPHAM = int.Parse(txb_SuaGiaSP.Text);
                    if (linkImg != string.Empty)
                    {
                        itemSelect.ANHSANPHAM = linkImg;
                    }
                    itemSelect.THOIHAN = (int)nud_SuaHanSP.Value;

                    if (QuanLySanPham_BUS.suaSanPham(itemSelect) == 1)
                    {
                        hienThongBao(lbl_ThongBao2, "Sửa Thành Công", Color.Green);
                        setDefautPage2();

                    }
                    else
                    {
                        hienThongBao(lbl_ThongBao2, "Them That bai", Color.Red);
                    }

                    if (linkImg != "" && chosen_File != "")
                    {
                        System.IO.File.Copy(chosen_File, @"..\\..\\Resources\\" + linkImg);

                    }
                    // chua set null, chua setdefaut, chua capnhat dgv
                }
                catch
                {
                    hienThongBao(lbl_ThongBao2, "Them That bai", Color.Red);
                    
                }



            }
            

            
        }

        private void pcb_SuaAnhSP_Click(object sender, EventArgs e)
        {
            GetFile(pcb_SuaAnhSP);
        }

      
    }
}
