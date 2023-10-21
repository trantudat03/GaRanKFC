using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FQuanLyNguoiDung : UserControl
    {
        private static int indexRowClickND = -1;
        private static NguoiDung_DTO selectItem = new NguoiDung_DTO();
        private static int checkChucNang = 0;
        public FQuanLyNguoiDung()
        {
            InitializeComponent();
        }

        
        private void FQuanLyNguoiDung_Load(object sender, EventArgs e)
        {
            setCMB();
            lbl_ThongBao.Text = string.Empty;
            setDefaut();
            setDataGirdView(QLNguoiDung_BUS.LayDuLieu());
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
                control.ForeColor = Color.White;

                // Hủy timer sau khi hoàn thành công việc
                timer.Dispose();
            };

            // Bắt đầu đếm thời gian
            timer.Start();
        }
        private void setCMB()
        {
            cmb_ChucVu.DataSource = null;
            cmb_ChucVu.DataSource = QLChucVu_BUS.layDuLieu();
            cmb_ChucVu.ValueMember = "MACHUCVU";
            cmb_ChucVu.DisplayMember = "TENCHUCVU";
            cmb_ChucVu.SelectedIndex = 0;

            cmb_TrangThai.DataSource = null;
            cmb_TrangThai.DataSource = QLTrangThaiNguoiDung_BUS.layDuLieu();
            cmb_TrangThai.ValueMember = "MATRANGTHAI";
            cmb_TrangThai.DisplayMember = "TENTRANGTHAI";
            cmb_TrangThai.SelectedIndex = 0;
        }

        private void setDefaut()
        {
            txb_MatKhau.Text = txb_Email.Text = txb_SoDienThoai.Text = txb_TenNguoiDung.Text = string.Empty;
            cmb_ChucVu.SelectedIndex = 0;
            cmb_TrangThai.SelectedIndex = 0;
            groupBoxContent.Visible = false;
            groupBoxControl.Visible = true;
            indexRowClickND = -1;
            checkChucNang = 0;
            selectItem = new NguoiDung_DTO();
        }

        private void setDataGirdView(List<NguoiDung_DTO> list)
        {
            dgv_DanhSachND.Rows.Clear();
            if(list.Count > 0 )
            {
                int index = 0;
                list.ForEach(n =>
                {
                    dgv_DanhSachND.Rows.Add(n.MANGUOIDUNG, n.TENNGUOIDUNG, n.TENCHUCVU, n.SODIENTHOAI, n.EMAIL, n.TENDANGNHAP, n.TENTRANGTHAI);
                    dgv_DanhSachND.Rows[index].Tag = n;
                    index++;
                });
            }
        }

        private bool checkNull()
        {
            if(txb_MatKhau.Text == string.Empty || txb_Email.Text == string.Empty || txb_SoDienThoai.Text == string.Empty || txb_TenNguoiDung.Text == string.Empty) 
            {
                return false;
            }
            return true;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if(checkChucNang!=1)
            {
                groupBoxContent.Visible = true;
                groupBoxControl.Visible = false;
                checkChucNang = 1;
            }
            

        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            groupBoxContent.Visible = false;
            groupBoxControl.Visible =true;
            checkChucNang = 0;
        }

        private void dgv_DanhSachND_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >=0 )
            {
                indexRowClickND = e.RowIndex;
                selectItem = new NguoiDung_DTO();
                selectItem = dgv_DanhSachND.Rows[e.RowIndex].Tag as NguoiDung_DTO;
                txb_TenNguoiDung.Text = dgv_DanhSachND.Rows[e.RowIndex].Cells[1].Value.ToString();
                cmb_ChucVu.Text = dgv_DanhSachND.Rows[e.RowIndex].Cells[2].Value.ToString();
                txb_SoDienThoai.Text = dgv_DanhSachND.Rows[e.RowIndex].Cells[3].Value.ToString();
                txb_Email.Text = dgv_DanhSachND.Rows[e.RowIndex].Cells[4].Value.ToString();
                txb_TenDangNhap.Text = dgv_DanhSachND.Rows[e.RowIndex].Cells[5].Value.ToString();
                cmb_TrangThai.Text = dgv_DanhSachND.Rows[e.RowIndex].Cells[6].Value.ToString();
                if(selectItem != null)
                {
                    txb_MatKhau.Text = selectItem.MATKHAU;// mat khau

                }

            }
        }

        private void addRow(NguoiDung_DTO n)
        {
            dgv_DanhSachND.Rows.Add(n.MANGUOIDUNG, n.TENNGUOIDUNG, n.TENCHUCVU, n.SODIENTHOAI, n.EMAIL, n.TENDANGNHAP, n.TENTRANGTHAI);
            dgv_DanhSachND.Rows[dgv_DanhSachND.RowCount-1].Tag = n;
        }

        private void updateRow(NguoiDung_DTO n)
        {
            if(indexRowClickND>=0)
            {
                dgv_DanhSachND.Rows[indexRowClickND].Cells[0].Value = n.MANGUOIDUNG;
                dgv_DanhSachND.Rows[indexRowClickND].Cells[1].Value = n.TENNGUOIDUNG;
                dgv_DanhSachND.Rows[indexRowClickND].Cells[2].Value = n.TENCHUCVU;
                dgv_DanhSachND.Rows[indexRowClickND].Cells[3].Value = n.SODIENTHOAI;
                dgv_DanhSachND.Rows[indexRowClickND].Cells[4].Value = n.EMAIL;
                dgv_DanhSachND.Rows[indexRowClickND].Cells[5].Value = n.TENDANGNHAP;
                dgv_DanhSachND.Rows[indexRowClickND].Cells[6].Value = n.TENTRANGTHAI;
                dgv_DanhSachND.Rows[indexRowClickND].Tag = n;
            }
            
        }

        private void deleteRow(int index)
        {
            dgv_DanhSachND.Rows.RemoveAt(index);
        }

        private int themNguoiDung()
        {
            NguoiDung_DTO item = new NguoiDung_DTO();
            item.TENNGUOIDUNG = txb_TenNguoiDung.Text;
            item.SODIENTHOAI = txb_SoDienThoai.Text;
            item.EMAIL = txb_Email.Text;
            item.TENDANGNHAP = txb_TenDangNhap.Text;
            item.MATKHAU = txb_MatKhau.Text;
            item.MATRANGTHAI = cmb_TrangThai.SelectedValue.ToString();
            item.MACHUCVU = cmb_ChucVu.SelectedValue.ToString();
            item.TENCHUCVU = cmb_ChucVu.Text;
            item.TENTRANGTHAI = cmb_ChucVu.Text;
            string checkThem = QLNguoiDung_BUS.themNguoiDung(item);
            if (checkThem != null)
            {
                item.MANGUOIDUNG = checkThem;
                addRow(item);
                return 1;
            }
            else{
                return 0;
            }
            
        }

        private int suaNguoiDung()
        {
            NguoiDung_DTO item = new NguoiDung_DTO();
            item.TENNGUOIDUNG = txb_TenNguoiDung.Text;
            item.SODIENTHOAI = txb_SoDienThoai.Text;
            item.EMAIL = txb_Email.Text;
            item.TENDANGNHAP = txb_TenDangNhap.Text;
            item.MATKHAU = txb_MatKhau.Text;
            item.MATRANGTHAI = cmb_TrangThai.SelectedValue.ToString();
            item.MACHUCVU = cmb_ChucVu.SelectedValue.ToString();
            item.TENCHUCVU = cmb_ChucVu.Text;
            item.TENTRANGTHAI = cmb_ChucVu.Text;
            item.MANGUOIDUNG = selectItem.MANGUOIDUNG;
            if(QLNguoiDung_BUS.suaNguoiDung(item) ==1)
            {
                
                updateRow(item);
                return 1;
            }
            return 0;
        }

        private int xoaNguoiDung()
        {
            if(selectItem!=null)
            {
                if(QLNguoiDung_BUS.xoaNguoiDung(selectItem) ==1)
                {
                    deleteRow(indexRowClickND);
                    return 1;
                }
            }
            return 0;
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            if(checkNull())
            {
                if (checkChucNang != 0)
                {
                    if (checkChucNang == 1)// chuc nang them
                    {
                        
                            if (themNguoiDung() == 1)
                            {
                                hienThongBao(lbl_ThongBao, "Thêm Thành Công", Color.Green);
                                setDefaut();
                                
                            }
                            else
                            {
                                hienThongBao(lbl_ThongBao, "Thêm Thất Bại", Color.Red);
                            }
                        
                    }
                    else
                    {
                        if(checkChucNang == 2)// chuc nang sua
                        {
                            
                            if(suaNguoiDung() == 1)
                            {
                                hienThongBao(lbl_ThongBao, "Sửa Thành Công", Color.Green);
                                setDefaut();
                                
                            }
                            else
                            {
                                hienThongBao(lbl_ThongBao, "Sửa Thất Bại", Color.Red);
                            }
                        }
                        else
                        {
                            if(checkChucNang == 3)
                            {
                                if(QLNguoiDung_BUS.kiemTraCoTheXoa(selectItem) ==1)
                                {
                                    if(xoaNguoiDung() ==1 )
                                    {
                                        hienThongBao(lbl_ThongBao, "Xoa Nhân Viên Thành Công", Color.Green);
                                        setDefaut();
                                    }
                                    else
                                    {
                                        hienThongBao(lbl_ThongBao, "Xoa Nhân Viên Thất Bại", Color.Red);
                                    }
                                    

                                }
                                else
                                {
                                    hienThongBao(lbl_ThongBao, "Nhân viên không thể xóa!", Color.Red);
                                }
                            }
                        }
                    }
                }
                else
                {
                    hienThongBao(lbl_ThongBao, "Vui Lòng chọn chức năng!", Color.Red);
                }
            }
            else
            {
                hienThongBao(lbl_ThongBao, "Nhập đầy đủ thông tin!", Color.Red);
            }
            
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if(checkChucNang!=2)
            {
                groupBoxContent.Visible = true;
                groupBoxControl.Visible = false;
                checkChucNang = 2;
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if(checkChucNang!=3)
            {
                groupBoxContent.Visible = true;
                groupBoxControl.Visible = false;
                checkChucNang =3;
            }
        }
    }
}
