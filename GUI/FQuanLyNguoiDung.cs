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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace GUI
{
    public partial class FQuanLyNguoiDung : UserControl
    {
        private static int indexRowClickND = -1;
        private static NguoiDung_DTO selectItem = new NguoiDung_DTO();
        private static int checkChucNang = 0;
        public static NguoiDung_DTO user = new NguoiDung_DTO();
        private static int indexRowClickCV = -1;
        private static ChucVu_DTO selectItemCV = new ChucVu_DTO();
        private static int checkChucNangCV = 0;
        public static bool checkChageIncontrol = false;
        public FQuanLyNguoiDung()
        {
            InitializeComponent();
        }

        public void setUser(NguoiDung_DTO u)
        {
            user = u;
        }
        
        private void FQuanLyNguoiDung_Load(object sender, EventArgs e)
        {
            setCMB();
            lbl_ThongBao.Text = string.Empty;
            lbl_ThongBao2.Text = string.Empty;
            setDefaut();
            setDataGirdView(QLNguoiDung_BUS.LayDuLieu());
            setDataGridViewCV(QLChucVu_BUS.layDuLieuKemSoNhanVien());
        }

        public void setData()
        {
            setCMB();
            setDataGirdView(QLNguoiDung_BUS.LayDuLieu());
            setDataGridViewCV(QLChucVu_BUS.layDuLieuKemSoNhanVien());
        }

        private void resetPage1()
        {
            setCMB();
            lbl_ThongBao.Text = string.Empty;
            setDefaut();
            setDataGirdView(QLNguoiDung_BUS.LayDuLieu());
            checkChageIncontrol = false;
        }

        private void resetpage2()
        {
            lbl_ThongBao2.Text = string.Empty;
            setDataGridViewCV(QLChucVu_BUS.layDuLieuKemSoNhanVien());
            checkChageIncontrol = false;
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
            txb_MatKhau.Text = txb_Email.Text = txb_SoDienThoai.Text = txb_TenNguoiDung.Text = txb_TenDangNhap.Text = string.Empty;
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
            item.TENTRANGTHAI = cmb_TrangThai.Text;
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
                                checkChageIncontrol = true;
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
                                checkChageIncontrol = true;
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
                                if(selectItem.MANGUOIDUNG != user.MANGUOIDUNG || selectItem.MACHUCVU != user.MACHUCVU)
                                {
                                    if (QLNguoiDung_BUS.kiemTraCoTheXoa(selectItem) == 1)
                                    {
                                        if (xoaNguoiDung() == 1)
                                        {
                                            checkChageIncontrol = true;
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
                                else
                                {
                                    hienThongBao(lbl_ThongBao, "Không thể xóa chính bạn", Color.Red);
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

        // page 2

        private void setDefautPage2()
        {
            selectItemCV = new ChucVu_DTO();
            indexRowClickCV = -1;
            checkChucNangCV = 0;
            txb_TenChucVu.Text = string.Empty;
        }

        private bool checkNullPage2()
        {
            if (txb_TenChucVu.Text == string.Empty)
                return false;
            return true;
        }

        private void setDataGridViewCV(List<ChucVu_DTO> list)
        {
            dgv_ChucVu.Rows.Clear();
            if(list.Count > 0 )
            {
                int index = 0;
                list.ForEach(c =>
                {
                    dgv_ChucVu.Rows.Add(c.MACHUCVU, c.TENCHUCVU, c.SONHANVIEN);
                    dgv_ChucVu.Rows[index].Tag = c;
                    index++;
                });
            }
        }

        private void dgv_ChucVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                indexRowClickCV = e.RowIndex;
                selectItemCV = new ChucVu_DTO();
                selectItemCV = dgv_ChucVu.Rows[e.RowIndex].Tag as ChucVu_DTO;
                txb_TenChucVu.Text = dgv_ChucVu.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void btn_ThemCV_Click(object sender, EventArgs e)
        {
            if(checkChucNangCV!=1)
            {

                checkChucNangCV = 1;
                hienThongBao(lbl_ThongBao2, "Chức năng Thêm Chức Vụ", Color.Green);
            }
        }

        private void btn_SuaCV_Click(object sender, EventArgs e)
        {
            if (checkChucNangCV != 2)
            {
                checkChucNangCV = 2;
                hienThongBao(lbl_ThongBao2, "Chức năng Sửa Chức Vụ", Color.Green);
            }
        }

        private void btn_XoaCV_Click(object sender, EventArgs e)
        {
            if (checkChucNangCV != 3)
            {
                checkChucNangCV = 3;
                hienThongBao(lbl_ThongBao2, "Chức năng Xóa Chức Vụ", Color.Green);
            }
        }

        private void addRowCV(ChucVu_DTO c)
        {
            dgv_ChucVu.Rows.Add(c.MACHUCVU, c.TENCHUCVU, c.SONHANVIEN);
            dgv_ChucVu.Rows[dgv_ChucVu.RowCount - 1].Tag = c;
        }
        private int themChucVu(ChucVu_DTO item)
        {
            if(item!=null)
            {
                item = QLChucVu_BUS.themChucVu(item);
                if (item.MACHUCVU!=string.Empty)
                {
                    addRowCV(item);
                    return 1;
                }
            }
            return 0;
        }

        private void updateRowCV(ChucVu_DTO c)
        {
            if (indexRowClickCV >= 0)
            {
                dgv_ChucVu.Rows[indexRowClickCV].Cells[1].Value =c.TENCHUCVU;
                dgv_ChucVu.Rows[indexRowClickCV].Tag = c;
            }
        }

        private int suaChucVu(ChucVu_DTO item)
        {
            if(item!=null)
            {
                if(QLChucVu_BUS.suaChucVu(item) != null)
                {
                    updateRowCV(item);
                    return 1;
                }
            }

            return 0;
        }

        private void deleteRowCV()
        {
            if (indexRowClickCV >= 0)
            {
                dgv_ChucVu.Rows.RemoveAt(indexRowClickCV);
            }
        }
        private int xoaChucVu(ChucVu_DTO item)
        {
            if(item.MACHUCVU!=string.Empty)
            {
                if(QLChucVu_BUS.xoaChucVu(item) !=null)
                {
                    deleteRowCV();
                    return 1;
                }
            }
            return 0;
        }

        private void btn_XacNhanCV_Click(object sender, EventArgs e)
        {
            if(checkChucNangCV!=0)
            {

                if(checkChucNangCV==3)
                {
                    if(selectItemCV.MACHUCVU!= string.Empty)
                    {
                        if(QLChucVu_BUS.kiemTraCoTheXoa(selectItemCV))
                        {
                            DialogResult result = MessageBox.Show($"Bạn có đồng ý xóa Chức Vụ {selectItemCV.TENCHUCVU}",
                        "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {

                                if (xoaChucVu(selectItemCV) == 1)
                                {
                                    checkChageIncontrol = true;
                                    hienThongBao(lbl_ThongBao2, "Xóa chức vụ thành công", Color.Green);
                                }
                                else
                                {
                                    hienThongBao(lbl_ThongBao2, "Xóa chức vụ thất bại", Color.Red);
                                }
                            }
                            
                        }
                        else
                        {
                            hienThongBao(lbl_ThongBao2, "Chức vụ không thể xóa", Color.Red);
                        }
                    }
                    else
                    {
                        hienThongBao(lbl_ThongBao2, "Chọn Chức vụ cần xóa", Color.Red);
                    }
                }
                if (checkNullPage2())
                {
                    if (checkChucNangCV == 1)
                    {
                        ChucVu_DTO item = new ChucVu_DTO();
                        item.TENCHUCVU = txb_TenChucVu.Text;
                        if (themChucVu(item) == 1)
                        {
                            checkChageIncontrol = true;
                            hienThongBao(lbl_ThongBao2, "Thêm Chức Vụ Thành Công", Color.Green);
                            setDefautPage2();
                        }
                        else
                        {
                            hienThongBao(lbl_ThongBao2, "Thêm Chức Vụ Thất Bại", Color.Red);
                        }
                    }
                    else
                    {
                        if(checkChucNangCV ==2 && selectItemCV.MACHUCVU!= string.Empty)
                        {
                            selectItemCV.TENCHUCVU = txb_TenChucVu.Text;
                            if(suaChucVu(selectItemCV) ==1)
                            {
                                checkChageIncontrol = true;
                                hienThongBao(lbl_ThongBao2, "Sửa Chức Vụ Thành Công", Color.Green);
                                setDefautPage2();
                            }
                            else
                            {
                                hienThongBao(lbl_ThongBao2, "Sửa Chức Vụ Thất Bại", Color.Red);
                            }
                        }
                    }
                }
                else
                {
                    hienThongBao(lbl_ThongBao2, "Nhập đủ thông tin", Color.Red);
                }
               
            }
            else
            {
                hienThongBao(lbl_ThongBao2, "Vui lòng chọn chức năng", Color.Red);
            }
        }

        private void btn_ThoatCV_Click(object sender, EventArgs e)
        {
            setDefaut();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (checkChageIncontrol)
            {
                if(tabControl1.SelectedIndex == 0)
                {
                    MessageBox.Show(tabControl1.SelectedIndex.ToString());
                    resetPage1();
                }
                else
                {
                    resetpage2();
                }
            }
        }
    }
}
