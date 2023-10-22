using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FKhuyenMai : UserControl
    {

        public static int indexRowClickKM = -1;
        public static KhuyenMai_DTO selectItem;
        public static int checkChucNang = 0;
        public FKhuyenMai()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxContent_Enter(object sender, EventArgs e)
        {

        }

        private void FKhuyenMai_Load(object sender, EventArgs e)
        {
            
            setDataGirdView(QLKhuyenMai_BUS.layDuLieu());
            setCMB();
            setDefaut();
            lbl_ThongBao.Text = string.Empty;
        }

        private void setDefaut()
        {
            groupBoxControl.Visible = true;
            groupBoxContent.Visible = false;
            checkChucNang = 0;
            indexRowClickKM = -1;
            selectItem = new KhuyenMai_DTO();
            txb_TenKhuyenMai.Text = string.Empty;
            txb_SoTienGiam.Text = string.Empty;
            txb_GiamToiDa.Text = string.Empty;
            cmb_DieuKien.SelectedIndex = 0;
            nud_PhanTram.Value = 0;
            dtp_NgayBatDau.Value = dtp_NgayKetThuc.Value = DateTime.Now;

        }

        private void setCMB()
        {
            cmb_DieuKien.DataSource = null;
            cmb_DieuKien.DataSource = QLDieuKien_BUS.layDuLieu();
            cmb_DieuKien.ValueMember = "MADIEUKIEN";
            cmb_DieuKien.DisplayMember = "TENDIEUKIEN";
            cmb_DieuKien.SelectedIndex = 0;

        }

       

        private void hienThongBao(Control control, string text, Color color)
        {
            if (control.InvokeRequired)
            {
                control.Invoke((MethodInvoker)(() =>
                {
                    control.Text = text;
                    control.ForeColor = color;
                    control.Visible = true;
                }));
            }
            else
            {
                control.Text = text;
                control.ForeColor = color;
                control.Visible = true;
            }

            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 2000;

            timer.Elapsed += (sender, e) =>
            {
                if (control.InvokeRequired)
                {
                    control.Invoke((MethodInvoker)(() =>
                    {
                        // Gọi hàm khác sau 2 giây
                        //control.ForeColor = Color.White;
                        control.Visible = false;
                    }));
                }
                else
                {
                    // Gọi hàm khác sau 2 giây
                    //control.ForeColor = Color.White;
                    control.Visible = false;
                }

                // Hủy timer sau khi hoàn thành công việc
                timer.Dispose();
            };

            // Bắt đầu đếm thời gian
            timer.Start();
        }

        private void setDataGirdView(List<KhuyenMai_DTO> list)
        {
            dgv_DanhSachKM.Rows.Clear();
            if (list.Count > 0)
            {
                int index = 0;
                list.ForEach(k =>
                {
                    if(k.MAKHUYENMAI!= "0")
                    {
                        dgv_DanhSachKM.Rows.Add(k.MAKHUYENMAI, k.TENKHUYENMAI, k.PHANTRAM, k.SOTIENGIAM, k.SOTIENGIAMTOIDA, k.DIEUKIEN.TENDIEUKIEN, k.NGAYBATDAU, k.NGAYKETTHUC);
                        dgv_DanhSachKM.Rows[index].Tag = k;
                        index++;
                    }
                    
                });
            }
        }

        private void dgv_DanhSachKM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                indexRowClickKM = e.RowIndex;
                selectItem = new KhuyenMai_DTO();
                selectItem = dgv_DanhSachKM.Rows[e.RowIndex].Tag as KhuyenMai_DTO;
                txb_TenKhuyenMai.Text = dgv_DanhSachKM.Rows[e.RowIndex].Cells[1].Value.ToString();
                nud_PhanTram.Value = (int)dgv_DanhSachKM.Rows[e.RowIndex].Cells[2].Value;
                txb_SoTienGiam.Text = dgv_DanhSachKM.Rows[e.RowIndex].Cells[3].Value.ToString();
                txb_GiamToiDa.Text = dgv_DanhSachKM.Rows[e.RowIndex].Cells[4].Value.ToString();
                cmb_DieuKien.Text = dgv_DanhSachKM.Rows[e.RowIndex].Cells[5].Value.ToString();
                string format = "dd-MM-yyyy";
                DateTime dateTime = DateTime.ParseExact(dgv_DanhSachKM.Rows[e.RowIndex].Cells[6].Value.ToString(), format, CultureInfo.InvariantCulture);
                dtp_NgayBatDau.Value = dateTime;
                dtp_NgayKetThuc.Value = DateTime.ParseExact(dgv_DanhSachKM.Rows[e.RowIndex].Cells[7].Value.ToString(), format, CultureInfo.InvariantCulture);

            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if(checkChucNang!=1)
            {
                groupBoxContent.Visible = true;
                groupBoxControl.Visible = false;
                checkChucNang = 1;
                hienThongBao(lbl_ThongBao, "Chức năng thêm", Color.Green);
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            setDefaut();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (checkChucNang != 2)
            {
                groupBoxContent.Visible = true;
                groupBoxControl.Visible = false;
                checkChucNang = 2;
                hienThongBao(lbl_ThongBao, "Chức năng sửa", Color.Green);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (checkChucNang != 3)
            {
                groupBoxContent.Visible = true;
                groupBoxControl.Visible = false;
                checkChucNang = 3;
                hienThongBao(lbl_ThongBao, "Chức Năng Xóa", Color.Green);
            }
        }

        private bool checkNull()
        {
            if(txb_TenKhuyenMai.Text == string.Empty)
            {
                return false;
            }
            else
            {
                if(nud_PhanTram.Value >0)
                {
                    if(txb_GiamToiDa.Text == string.Empty)
                    {
                        return false;
                    }
                }
                else
                {
                    if(txb_SoTienGiam.Text == string.Empty)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private bool checkDateTime()
        {
            if(dtp_NgayBatDau.Value> dtp_NgayKetThuc.Value)
            {
                return false;
            }
            return true;
        }

        private void addRow(KhuyenMai_DTO k)
        {
            k.NGAYBATDAU = dtp_NgayBatDau.Value.ToString("dd-MM-yyyy");
            k.NGAYKETTHUC = dtp_NgayKetThuc.Value.ToString("dd-MM-yyyy");
            dgv_DanhSachKM.Rows.Add(k.MAKHUYENMAI, k.TENKHUYENMAI, k.PHANTRAM, k.SOTIENGIAM, k.SOTIENGIAMTOIDA, k.DIEUKIEN.TENDIEUKIEN, k.NGAYBATDAU, k.NGAYKETTHUC);
            dgv_DanhSachKM.Rows[dgv_DanhSachKM.RowCount - 1].Tag = k;
        }
        private int themKhuyenMai()
        {
            KhuyenMai_DTO item = new KhuyenMai_DTO();
            item.TENKHUYENMAI = txb_TenKhuyenMai.Text;
            item.PHANTRAM = (int)nud_PhanTram.Value;
            int sotienGiam;
            bool parseSuccess = int.TryParse(txb_SoTienGiam.Text, out sotienGiam);
            if (parseSuccess)
            {
                item.SOTIENGIAM = sotienGiam;
            }
            else
            {
                item.SOTIENGIAM = 0;
            }

            int sotienGiamTD;
            bool parseSuccessTD = int.TryParse(txb_SoTienGiam.Text, out sotienGiamTD);
            if (parseSuccess)
            {
                item.SOTIENGIAMTOIDA = sotienGiamTD;
            }
            else
            {
                item.SOTIENGIAMTOIDA = 0;
            }

            item.MADIEUKIEN = cmb_DieuKien.SelectedValue.ToString();
            item.NGAYBATDAU = dtp_NgayBatDau.Value.ToString("yyyy-MM-dd");
            item.NGAYKETTHUC = dtp_NgayKetThuc.Value.ToString("yyyy-MM-dd");
            item.DIEUKIEN.TENDIEUKIEN = cmb_DieuKien.Text;
            string checkAdd = QLKhuyenMai_BUS.themKhuyenMai(item);
            if (checkAdd != null) 
            {
                item.MAKHUYENMAI = checkAdd;
                addRow(item);
                return 1;
            }
            return 0;
        }

        private void updateRow(KhuyenMai_DTO k)
        {
            if (indexRowClickKM >= 0)
            {
                dgv_DanhSachKM.Rows[indexRowClickKM].Cells[0].Value = k.MAKHUYENMAI;
                dgv_DanhSachKM.Rows[indexRowClickKM].Cells[1].Value = k.TENKHUYENMAI;
                dgv_DanhSachKM.Rows[indexRowClickKM].Cells[2].Value = k.PHANTRAM;
                dgv_DanhSachKM.Rows[indexRowClickKM].Cells[3].Value = k.SOTIENGIAM ;
                dgv_DanhSachKM.Rows[indexRowClickKM].Cells[4].Value = k.SOTIENGIAMTOIDA;
                dgv_DanhSachKM.Rows[indexRowClickKM].Cells[5].Value = k.DIEUKIEN.TENDIEUKIEN;
                dgv_DanhSachKM.Rows[indexRowClickKM].Cells[6].Value = k.NGAYBATDAU;
                dgv_DanhSachKM.Rows[indexRowClickKM].Cells[7].Value = k.NGAYKETTHUC;
                dgv_DanhSachKM.Rows[indexRowClickKM].Tag = k;
            }

        }

        private int suaKhuyenMai()
        {
            selectItem.TENKHUYENMAI = txb_TenKhuyenMai.Text;
            selectItem.PHANTRAM = (int)nud_PhanTram.Value;
            int sotienGiam;
            bool parseSuccess = int.TryParse(txb_SoTienGiam.Text, out sotienGiam);
            if (parseSuccess)
            {
                selectItem.SOTIENGIAM = sotienGiam;
            }
            else
            {
                selectItem.SOTIENGIAM = 0;
            }

            int sotienGiamTD;
            bool parseSuccessTD = int.TryParse(txb_GiamToiDa.Text, out sotienGiamTD);
            if (parseSuccess)
            {
                selectItem.SOTIENGIAMTOIDA = sotienGiamTD;
            }
            else
            {
                selectItem.SOTIENGIAMTOIDA = 0;
            }
            selectItem.MADIEUKIEN = cmb_DieuKien.SelectedValue.ToString();
            selectItem.DIEUKIEN.TENDIEUKIEN = cmb_DieuKien.Text;
            selectItem.NGAYBATDAU = dtp_NgayBatDau.Value.ToString("yyyy-MM-dd");
            selectItem.NGAYKETTHUC = dtp_NgayKetThuc.Value.ToString("yyyy-MM-dd");
            if(QLKhuyenMai_BUS.suaKhuyenMai(selectItem)==1)
            {
                selectItem.NGAYBATDAU = dtp_NgayBatDau.Value.ToString("dd-MM-yyyy");
                selectItem.NGAYKETTHUC = dtp_NgayKetThuc.Value.ToString("dd-MM-yyyy");
                updateRow(selectItem);
                return 1;
            }

            return 0;
        }

        private void deleteRow(int index)
        {
            if(index >=0)
            {
                dgv_DanhSachKM.Rows.RemoveAt(index);
            }
        }

        private int xoaKhuyenMai()
        {
            if(selectItem.MAKHUYENMAI != string.Empty)
            {
                if(QLKhuyenMai_BUS.xoaKhuyenMai(selectItem.MAKHUYENMAI)==1)
                {
                    deleteRow(indexRowClickKM);
                    return 1;
                }
            }
            return 0;
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            if(checkChucNang!=0)
            {
                if (checkChucNang == 3 && selectItem.MAKHUYENMAI != string.Empty)// chuc nang xoa
                {
                    if (QLKhuyenMai_BUS.kiemTraCoTheXoa(selectItem.MAKHUYENMAI) == null)
                    {
                        hienThongBao(lbl_ThongBao, $"{selectItem.TENKHUYENMAI}  Không thể xóa", Color.Red);
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show($"Bạn có đồng ý xóa Khuyễn Mãi {selectItem.TENKHUYENMAI}",
                        "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            if (xoaKhuyenMai() == 1)
                            {
                                hienThongBao(lbl_ThongBao, $"Xóa {selectItem.TENKHUYENMAI} Thành Công", Color.Red);
                                setDefaut();
                            }
                            else
                            {
                                hienThongBao(lbl_ThongBao, $"Xóa Thất Bại", Color.Red);
                            }
                        }


                    }
                }
                else
                {
                    if (checkChucNang != 3)
                    {
                        if (checkNull())
                        {
                            if (checkDateTime())
                            {
                                if (checkChucNang == 1)
                                {
                                    if (themKhuyenMai() == 1)
                                    {
                                        setDefaut();
                                        hienThongBao(lbl_ThongBao, "Thêm Khuyễn Mãi Thành Công ", Color.Green);
                                    }
                                    else
                                    {
                                        hienThongBao(lbl_ThongBao, "Thêm Khuyễn Mãi Thất Bại ", Color.Red);
                                    }
                                }
                                else
                                {
                                    if (checkChucNang == 2 && selectItem.MAKHUYENMAI != string.Empty)
                                    {
                                        if (suaKhuyenMai() == 1)
                                        {
                                            setDefaut();
                                            hienThongBao(lbl_ThongBao, "Sửa Khuyễn Mãi Thành Công ", Color.Green);

                                        }
                                        else
                                        {
                                            hienThongBao(lbl_ThongBao, "Sửa Khuyễn Mãi Thất Bại ", Color.Red);

                                        }
                                    }
                                    else
                                    {
                                        if (selectItem.MAKHUYENMAI != string.Empty)
                                        {
                                            hienThongBao(lbl_ThongBao, "Chọn KM Cần Cập Nhật", Color.Red);
                                        }
                                    }
                                }
                            }
                            else
                            {
                                hienThongBao(lbl_ThongBao, "Lỗi thông tin", Color.Red);
                            }

                        }
                        else
                        {
                            hienThongBao(lbl_ThongBao, "Nhập đủ thông tin", Color.Red);
                        }
                    }
                    else
                    {
                        if (selectItem.MAKHUYENMAI == string.Empty)
                        {
                            hienThongBao(lbl_ThongBao, "Chọn KM Cần Cập Nhật", Color.Red);
                        }

                    }



                }
            }
            else
            {
                hienThongBao(lbl_ThongBao, "Chọn Chức Năng", Color.Red);
            }
        }

        
    }
}
