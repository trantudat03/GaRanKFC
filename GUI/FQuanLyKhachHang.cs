using BUS;
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
    public partial class FQuanLyKhachHang : UserControl
    {

        public static int checkChucNang = 0;
        public static KhachHang_DTO selectItem = new KhachHang_DTO();
        public static int indexSelectRow = -1;
        public static bool checkChangeInControl = false;
        public FQuanLyKhachHang()
        {
            InitializeComponent();
            setDataGridView(QLKhachHang_BUS.layDuLieu());
        }

        private void FQuanLyKhachHang_Load(object sender, EventArgs e)
        {
            lbl_ThongBao.Text = string.Empty;
            lbl_ThongBao2.Text = string.Empty;
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

        private void setDataGridView(List<KhachHang_DTO> list)
        {
            dgv_KhachHang.Rows.Clear();
            if(list.Count > 0)
            {
                int index = 0;
                list.ForEach(k =>
                {
                    dgv_KhachHang.Rows.Add(k.MAKHACHHANG, k.TENKHACHHANG, k.SODIENTHOAI, k.DIEM);
                    dgv_KhachHang.Rows[index].Tag = k;
                    index++;
                });
            }
        }

        private void setDefaut()
        {
            txb_SuaSDT.Text = string.Empty;
            txb_SuaTenKH.Text = string.Empty;
            nud_SuaDiem.Value = 0;
            checkChucNang = 0;
            indexSelectRow = -1;
            selectItem = new KhachHang_DTO(); 
        }

        private void setDefautPage1()
        {
            txb_TenKhachHang.Text = string.Empty;
            txb_SoDienThoai.Text = string.Empty;
            
        }

        private bool checkNull()
        {
            if(txb_TenKhachHang.Text == string.Empty || txb_SoDienThoai.Text == string.Empty)
            {
                return false;
            }
            return true;
        }

        private bool checkNullPage2()
        {
            if (txb_SuaTenKH.Text == string.Empty || txb_SuaSDT.Text == string.Empty)
            {
                return false;
            }
            return true;
        }

        private bool checkSDT(TextBox t)
        {
            if(t.Text.Length <10 )
            {
                return false;
            }
            return true;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if(checkNull())
            {
                if(checkSDT(txb_SoDienThoai))
                {
                    KhachHang_DTO item = new KhachHang_DTO();
                    item.SODIENTHOAI = txb_SoDienThoai.Text;
                    item.TENKHACHHANG = txb_TenKhachHang.Text;
                    if(QLKhachHang_BUS.themKhachHang(item) == 1)
                    {
                        hienThongBao(lbl_ThongBao, "Thêm Khách Hàng Thành Công", Color.Green);
                        checkChangeInControl = true;
                        setDefautPage1();
                    }
                }
                else
                {
                    hienThongBao(lbl_ThongBao, "Nhập sai Số Điện Thoại", Color.Red);
                }

            }
            else
            {
                hienThongBao(lbl_ThongBao, "Nhập đầy đủ thông tin", Color.Red);
            }
        }

        private void txb_SoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Chặn ký tự không phải là số và các ký tự điều khiển (Control characters)
            }
        }

        private void btn_HuyKH_Click(object sender, EventArgs e)
        {
            setDefaut();
        }

        private void dgv_KhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >=0)
            {
                indexSelectRow = e.RowIndex;
                selectItem = dgv_KhachHang.Rows[indexSelectRow].Tag as KhachHang_DTO;
                if (selectItem != null)
                {
                    txb_SuaTenKH.Text = selectItem.TENKHACHHANG;
                    txb_SuaSDT.Text = selectItem.SODIENTHOAI;
                    nud_SuaDiem.Value = selectItem.DIEM;
                }
            }
        }

        private void btn_SuaCV_Click(object sender, EventArgs e)
        {
            if(checkChucNang !=1)
            {
                checkChucNang = 1;
                hienThongBao(lbl_ThongBao2, "Chức năng sửa khách hàng", Color.Green);
            }
        }

        private void btn_XoaCV_Click(object sender, EventArgs e)
        {
            if (checkChucNang != 2)
            {
                checkChucNang = 2;
                hienThongBao(lbl_ThongBao2, "Chức năng Xóa khách hàng", Color.Green);
            }
        }


        private void updateRow()
        {
            if(indexSelectRow >=0)
            {
                dgv_KhachHang.Rows[indexSelectRow].Cells[0].Value = selectItem.MAKHACHHANG;
                dgv_KhachHang.Rows[indexSelectRow].Cells[1].Value = selectItem.TENKHACHHANG;
                dgv_KhachHang.Rows[indexSelectRow].Cells[2].Value = selectItem.SODIENTHOAI;
                dgv_KhachHang.Rows[indexSelectRow].Cells[3].Value = selectItem.DIEM;
                dgv_KhachHang.Rows[indexSelectRow].Tag = selectItem;
            }
            
        }
        private int suaKhachHang(KhachHang_DTO item)
        {
            item.SODIENTHOAI = txb_SuaSDT.Text;
            item.TENKHACHHANG = txb_SuaTenKH.Text;
            item.DIEM = (int)nud_SuaDiem.Value;
            if(QLKhachHang_BUS.suaKhachHang(item) != null )
            {
                updateRow();
                return 1;
            }

            return 0;
        }

        private void deleteRow()
        {
            if(indexSelectRow>=0)
            {
                dgv_KhachHang.Rows.RemoveAt(indexSelectRow);    
            }
        }

        private int xoaKhachHang(KhachHang_DTO item)
        {
           
            if (QLKhachHang_BUS.xoaKhachHang(item) == null)
            {
                deleteRow();
                return 1;
            }

            return 0;
        }


        private void btn_XacNhanKH_Click(object sender, EventArgs e)
        {
            if(checkChucNang!= 0)
            {
                if(checkChucNang == 2)
                {
                    if(selectItem.MAKHACHHANG != string.Empty)
                    {
                        if (QLKhachHang_BUS.kiemTraCoTheXoa(selectItem))
                        {
                            DialogResult result = MessageBox.Show($"Bạn có đồng ý xóa Khách Hàng {selectItem.TENKHACHHANG}",
                            "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                if (xoaKhachHang(selectItem) == 1)
                                {
                                    hienThongBao(lbl_ThongBao2, "Xóa Khách Hàng Thành Công", Color.Red);
                                    checkChangeInControl = true;
                                    setDefaut();
                                }
                                else
                                {
                                    hienThongBao(lbl_ThongBao2, "Xóa Khách Hàng Thất Bại", Color.Red);
                                }
                            }
                        }
                        else
                        {
                            hienThongBao(lbl_ThongBao2, "Khách hàng không thể xóa", Color.Red);
                        }
                    }
                    else
                    {
                        hienThongBao(lbl_ThongBao2, "Chọn Khách Hàng Cần Xóa", Color.Red);
                    }  
                }
                else
                {
                    if (checkChucNang == 1)
                    {
                        if (checkNullPage2() && checkSDT(txb_SuaSDT))
                        {
                            if (suaKhachHang(selectItem) == 1)
                            {
                                checkChangeInControl = true;
                                setDefaut();
                                hienThongBao(lbl_ThongBao2, "Sửa khách hàng thành công", Color.Green);
                            }
                            else
                            {
                                hienThongBao(lbl_ThongBao2, "Sửa Khách Hàng thất bại", Color.Red);
                            }
                        }
                        else
                        {
                            hienThongBao(lbl_ThongBao2, "Nhập sai thông tin", Color.Red);
                        }

                    }
                }
                
            }
            else
            {
                hienThongBao(lbl_ThongBao2, "Vui lòng chọn chức năng", Color.Red);
            }
        }

        private void resetPage2()
        {
            if(checkChangeInControl)
            {
                checkChangeInControl = false;
                setDataGridView(QLKhachHang_BUS.layDuLieu());
            }
        }


        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(checkChangeInControl)
            {
                if(tabControl1.SelectedIndex ==1)
                {
                    resetPage2();
                }
            }
        }
    }
}
