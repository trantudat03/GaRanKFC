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
using BUS;
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Drawing.Drawing2D;
using System.Reflection;

namespace GUI
{
    public partial class FOrder : UserControl
    {
        public FOrder()
        {
            InitializeComponent();
            listSP = QuanLySanPham_BUS.layDuLieu();
        }

        List<SanPham_DTO> listSP = new List<SanPham_DTO>();
        List<SanPham_DTO> listOrder = new List<SanPham_DTO>();
        KhachHang_DTO khachHang = new KhachHang_DTO();
        //Panel detailOrder = new Panel();
        private static int startY = 10;
        int checkMenu = 1;

        private void FOrder_Load(object sender, EventArgs e)
        {
            hienMenu(1, "");
            setDefaut();
            //MessageBox.Show(QLKhachHang_BUS.taoMa(10));
        }

        private void setStyle()
        {
            //txb_Search.

        }

        private void setDefaut()
        {
            lbl_ThanhTien.Text = "0";
            panel_Detail.Visible = false;
            panel_KhachHang.Visible = false;
            panel_ThemKH.Visible = false;
        }
       

        private void panel_OrderList_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_Menu_Paint(object sender, PaintEventArgs e)
        {
           
        }

        // ham loai bo dau
        private string RemoveDiacritics(string text)
        {
            string formD = text.Normalize(NormalizationForm.FormD);
            StringBuilder sb = new StringBuilder();
            // ham loai bo dau
            foreach (char ch in formD)
            {
                UnicodeCategory category = CharUnicodeInfo.GetUnicodeCategory(ch);
                if (category != UnicodeCategory.NonSpacingMark)
                {
                    sb.Append(ch);
                }
            }

            return sb.ToString().Normalize(NormalizationForm.FormC);
        }

        private int timChuoiTrongChuoi(string ch1, string ch2)
        {
            if(ch1.IndexOf(ch2, StringComparison.OrdinalIgnoreCase) >= 0) 
            {
                return 1;
            }
            

            return -1;
        }

        public string themDauChamVaoSo(int number)
        {
            
                string numberStr = number.ToString("N0", CultureInfo.InvariantCulture);
                numberStr = numberStr.Replace(",", ".");
                return numberStr;

        }
        private void addItemToOrder(SanPham_DTO sp)
        {
            if(sp != null)
            {
                themVaoListOrderUI(sp);
            }
            
        }


        private void setValuePanel(Panel p)
        {
            p.Visible = true;
            int heght = 400;
            int width = 420;
            p.Size = new Size(width, heght);
            p.Location = new Point(60, 25);
            p.TabIndex = 3;
        }
        private void hienThiDetail(SanPham_DTO sp)
        {

            setValuePanel(panel_Detail);
            //panel_Detail.Dock = DockStyle.Fill;
            txb_Note.Text = sp.NOTE;
            nub_soLuong.Value = sp.SLORDER;
            pictureBox_Detail.Image = (Image)Properties.Resources.ResourceManager.GetObject(sp.ANHSANPHAM);
            lbl_GiaSP.Text = themDauChamVaoSo(sp.GIASANPHAM);
            lbl_tenSP.Text = sp.TENSANPHAM;
        }

        private void btn_CloseDetail_Click(object sender, EventArgs e)
        {
            panel_Detail.Visible = false;
        }

        private void btn_ThoatDetail_Click(object sender, EventArgs e)
        {
            panel_Detail.Visible = false;
        }

        private void btn_closeKH_Click(object sender, EventArgs e)
        {
            panel_KhachHang.Visible = false;
        }

        private void btn_ThoatKH_Click(object sender, EventArgs e)
        {
            panel_KhachHang.Visible = false;
        }

        private int tinhTongTien(List<SanPham_DTO> listOrder)
        {
            int tong = 0;
            if(listOrder!= null)
            {
                listOrder.ForEach(s => 
                {
                    if(s!=null)
                    {
                        tong += (s.GIASANPHAM * s.SLORDER);
                    }
                });
            }

            return tong;
        }

        private void setTongTienUI()
        {
            string price = themDauChamVaoSo(tinhTongTien(listOrder));
            if(price!=null)
            {
                lbl_ThanhTien.Text = price;
            }
        }
        private void btn_luuDetail_Click(object sender, EventArgs e)
        {
            // sua gia tri list
            // sua ui
            SanPham_DTO spfocus = panel_Detail.Tag as SanPham_DTO;
            SanPham_DTO spFind =  listOrder.Find(s => s.MASANPHAM == spfocus.MASANPHAM);

            if(spFind!= null)
            {
                spFind.SLORDER = (int)nub_soLuong.Value;
                spFind.NOTE = txb_Note.Text;
                spfocus.SLORDER = (int)nub_soLuong.Value;
                spfocus.NOTE = txb_Note.Text;
                setTongTienUI();
            }

            foreach(Panel p in panel_OrderList.Controls)
            {
                if(p is Panel && p!= panel_Detail)
                {
                    SanPham_DTO s = p.Tag as SanPham_DTO;
                    if(s != null && s.MASANPHAM == spFind.MASANPHAM)
                    {
                        foreach (Control l in p.Controls)
                        {
                            if (l is Label)
                            {
                                l.Text = $"{spFind.LoaiSanPham.TENLOAISP}: {spFind.TENSANPHAM}, {themDauChamVaoSo(spFind.GIASANPHAM)} VNĐ, SL:{spFind.SLORDER}"; 
                                panel_Detail.Visible = false;
                                break;
                            }
                        }
                        break;
                    }
                    
                }
            }

        }

        private void themVaoListOrderUI(SanPham_DTO sp)// item menu duoc click
        {
            SanPham_DTO spFind = listOrder.Find(s => s.MASANPHAM == sp.MASANPHAM);
            if(spFind == null)
            {
                sp.SLORDER = 1;
                //sp.SLORDER += 1;
                listOrder.Add(sp);
                setTongTienUI();
                int spacing = 10;
                int panelWidth = panel_OrderList.Width - 20;
                int panelHeight = 35;
                int startX = 10;
                Panel panel = new Panel();
                panel.Tag = sp;
                panel.Size = new Size(panelWidth, panelHeight);
                panel.Location = new Point(startX, startY);
                panel.BackColor = Color.White;
                panel.BorderStyle = BorderStyle.FixedSingle;
                Label label = new Label();
                label.Tag = sp;
                label.Text = $"{sp.LoaiSanPham.TENLOAISP}: {sp.TENSANPHAM}, {themDauChamVaoSo(sp.GIASANPHAM)} VNĐ, SL:{sp.SLORDER}";
                label.Font = new Font("Arial", 14, FontStyle.Regular);
                label.Size = new Size(panelWidth-75, panelHeight);
                label.Location = new Point(5, 5);
                label.Parent = panel;
                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = Properties.Resources.detail;
                pictureBox.Size = new Size(30, 35);
                pictureBox.Location = new Point(panelWidth - 70, 2);
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Cursor = Cursors.Hand;
                pictureBox.Click += (sender, e) =>
                {
                    hienThiDetail(sp);
                };
                System.Windows.Forms.Button xoaBTN = new System.Windows.Forms.Button();
                xoaBTN.Text = "Xóa";
                xoaBTN.Size = new Size(40, 30);
                xoaBTN.Cursor = Cursors.Hand;
                xoaBTN.Font = new Font("Arial", 10, FontStyle.Regular);
                xoaBTN.Location = new Point(panelWidth-35,2);
                xoaBTN.ForeColor = Color.Red;
                xoaBTN.FlatStyle = FlatStyle.Flat;
                xoaBTN.BackColor = Color.Transparent;
                xoaBTN.Padding = new Padding(0);
                xoaBTN.FlatAppearance.BorderSize = 0;
                xoaBTN.Click += (sender, e) =>
                {
                    xoaSPFromListOrder(label);
                };

                panel.Controls.Add(label);
                panel.Controls.Add(pictureBox);
                panel.Controls.Add(xoaBTN);

                panel_OrderList.Controls.Add(panel);
                startY += spacing + panelHeight;
            }else
            {
                // tim và hiển thị lại 
                timVaThayDoiSL(sp, panel_OrderList);
                //MessageBox.Show("hello");
            }
            
        }

        private void timVaThayDoiSL(SanPham_DTO spFind, Panel panel)
        {
            spFind.SLORDER += 1;
            listOrder.ForEach(s =>
            {
                if(s.MASANPHAM == spFind.MASANPHAM) 
                {
                    s.SLORDER = spFind.SLORDER;
                    setTongTienUI();
                }
            });

                foreach (Control control in panel.Controls)
                {
                    if (control is Panel && control != panel_Detail)
                    {
                        SanPham_DTO tagControl = control.Tag as SanPham_DTO;
                        if (tagControl != null)
                        {
                            if (tagControl.MASANPHAM == spFind.MASANPHAM)
                            {
                                // tagControl.SLORDER += 1;
                                foreach (Control label in control.Controls)
                                {
                                    if (label is Label)
                                    {
                                        label.Text = $"{tagControl.LoaiSanPham.TENLOAISP}: {tagControl.TENSANPHAM}, {themDauChamVaoSo(tagControl.GIASANPHAM)} VNĐ, SL:{tagControl.SLORDER}";
                                    }
                                }
                            }
                        }
                    }
                }    
        }

        private void xoaSPFromListOrder(Label label)
        {
            SanPham_DTO sp = label.Tag as SanPham_DTO;
            if (sp != null)
            {
                if (sp.SLORDER > 1)
                {
                    sp.SLORDER -= 1;
                    label.Text = $"{sp.LoaiSanPham.TENLOAISP}: {sp.TENSANPHAM}, {themDauChamVaoSo(sp.GIASANPHAM)} VNĐ, SL:{sp.SLORDER}";
                    listOrder.ForEach(s =>
                    {
                        if (s.MASANPHAM == sp.MASANPHAM)
                        {
                            s.SLORDER = sp.SLORDER;
                            setTongTienUI();
                        }
                    });
                }
                else
                {
                    if(sp.SLORDER == 1)
                    {
                        timVaXoaSP(sp, panel_OrderList);
                    }
                }
            
            }
        }

        private void timVaXoaSP(SanPham_DTO spFind, Panel panel)
        {
            SanPham_DTO spDelete = listOrder.Find(s => s.MASANPHAM == spFind.MASANPHAM);
            listOrder.Remove(spDelete);
            setTongTienUI();

            Panel panelDelete = new Panel();
            int check = 0;
            foreach (Control control in panel.Controls)
            {
                if (control is Panel && control != panel_Detail)
                {
                    SanPham_DTO tagControl = control.Tag as SanPham_DTO;
                    if (tagControl != null)
                    {
                        if (tagControl.MASANPHAM == spFind.MASANPHAM)
                        {
                            panelDelete = (Panel)control;
                            check = 1;
                            continue;
                        }
                        
                    }
                    if(check == 1)
                    {
                        int x = control.Location.X;
                        int y = control.Location.Y;
                        control.Location = new Point(10, y - 45);
                        
                    }
                }
            }
            if(check==1)
            {
                startY -= 45;
                panel.Controls.Remove(panelDelete);
            }
            
            //MessageBox.Show(index.ToString());
        }


        private void hienMenu(int type, string strSearch)
        {
            
            if (type != 0)
            {
                panel_Menu.Controls.Clear();
                if(listSP != null)

                    
                {
                    
                    
                    int spacing = 30;
                    int startX = 15;
                    int startY = 10;
                    int panelWidth = 160;
                    int panelHeight = 210;

                    if (strSearch != "")
                    {
                        listSP.ForEach((sp) =>
                        {
                            string tenSearch = RemoveDiacritics(strSearch);
                            string tenSP = RemoveDiacritics(sp.TENSANPHAM);
                            //MessageBox.Show(tenSearch + "  " + tenSP);
                            if (sp.MALOAISP == type.ToString() && tenSP.IndexOf(tenSearch, StringComparison.OrdinalIgnoreCase) >= 0)
                            {


                                Panel panel = new Panel();
                                // gan san pham vào panel
                                panel.Tag = sp;
                                panel.Click += (sender, e) =>
                                {
                                    Panel clickedPanel = (Panel)sender;
                                    SanPham_DTO spClick = clickedPanel.Tag as SanPham_DTO;
                                    addItemToOrder(spClick);
                                }; // them su kien click
                                panel.Size = new Size(panelWidth, panelHeight);
                                panel.Cursor = Cursors.Hand;
                                PictureBox pictureBox = new PictureBox();
                                pictureBox.Tag = sp;
                                pictureBox.Size = new Size(panelWidth, 120);
                                //pictureBox.Image = Properties.Resources._1mienggaran;
                                pictureBox.Image = (Image)Properties.Resources.ResourceManager.GetObject(sp.ANHSANPHAM);
                                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                                pictureBox.Location = new Point(0, 0);
                                Label lableGia = new Label();
                                lableGia.Tag = sp;
                                string gia = themDauChamVaoSo(sp.GIASANPHAM);
                                lableGia.Text = $"{gia} VNĐ ";
                                lableGia.Location = new Point(1, panelHeight - 80);
                                lableGia.TextAlign = ContentAlignment.TopCenter;
                                lableGia.Font = new Font("Arial", 14, FontStyle.Regular);
                                lableGia.ForeColor = Color.Red;
                                lableGia.Size = new Size(panelWidth, 20);
                                RichTextBox txbTen = new RichTextBox();
                                txbTen.Tag = sp;
                                txbTen.Enabled = false;
                                txbTen.ForeColor = Color.SteelBlue;
                                //Label txbTen = new Label();
                                txbTen.Text = $"{sp.TENSANPHAM}";
                                txbTen.Location = new Point(1, panelHeight - 55);
                                txbTen.ReadOnly = true;
                                txbTen.Multiline = true;
                                txbTen.WordWrap = true;
                                txbTen.SelectAll();
                                txbTen.SelectionAlignment = HorizontalAlignment.Center;
                                txbTen.BorderStyle = BorderStyle.None;
                                txbTen.Cursor = Cursors.Hand;
                                txbTen.Font = new Font("Arial", 15, FontStyle.Bold);

                                txbTen.Size = new Size(panelWidth, 50);
                                txbTen.AutoSize = true;
                                txbTen.MaximumSize = new Size(panelWidth, 50);

                                // Tạo sự kiện click cho PictureBox
                                pictureBox.Click += (sender, e) =>
                                {
                                    PictureBox pictureClick = (PictureBox)sender;
                                    SanPham_DTO spClick = pictureClick.Tag as SanPham_DTO;
                                    addItemToOrder(spClick);
                                };

                                // Tạo sự kiện click cho Label
                                lableGia.Click += (sender, e) =>
                                {
                                    Label lblClick = (Label)sender;
                                    SanPham_DTO spClick = lblClick.Tag as SanPham_DTO;
                                    addItemToOrder(spClick);
                                };

                                // Tạo sự kiện click cho RichTextBox
                                txbTen.Click += (sender, e) =>
                                {
                                    RichTextBox txb_click = (RichTextBox)sender;
                                    SanPham_DTO spClick = txb_click.Tag as SanPham_DTO;
                                    addItemToOrder(spClick);
                                };

                                panel.Controls.Add(pictureBox);
                                panel.Controls.Add(lableGia);
                                panel.Controls.Add(txbTen);
                                panel.Location = new Point(startX, startY);
                                startX += panelWidth + spacing;
                                panel.BorderStyle = BorderStyle.FixedSingle;
                                panel_Menu.Controls.Add(panel);

                                // Kiểm tra nếu đã đạt đến cuối hàng
                                if (startX + panelWidth > panel_Menu.Width)
                                {
                                    startX = 15;
                                    startY += panelHeight + 20;
                                }
                            }

                        });
                    }
                    else
                    {
                        listSP.ForEach((sp) =>
                        {

                            if (sp.MALOAISP == type.ToString())
                            {
                                Panel panel = new Panel();
                                // gan san pham vào panel
                                panel.Tag = sp;
                                panel.Click += (sender, e) =>
                                {
                                    Panel clickedPanel = (Panel)sender;
                                    SanPham_DTO spClick = clickedPanel.Tag as SanPham_DTO;
                                    addItemToOrder(spClick);
                                }; // them su kien click
                                panel.Size = new Size(panelWidth, panelHeight);
                                panel.Cursor = Cursors.Hand;
                                PictureBox pictureBox = new PictureBox();
                                pictureBox.Tag = sp;
                                pictureBox.Size = new Size(panelWidth, 120);
                                //pictureBox.Image = Properties.Resources._1mienggaran;
                                pictureBox.Image = (Image)Properties.Resources.ResourceManager.GetObject(sp.ANHSANPHAM);
                                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                                pictureBox.Location = new Point(0, 0);
                                Label lableGia = new Label();
                                lableGia.Tag = sp;
                                string gia = themDauChamVaoSo(sp.GIASANPHAM);
                                lableGia.Text = $"{gia} VNĐ ";
                                lableGia.Location = new Point(1, panelHeight - 80);
                                lableGia.TextAlign = ContentAlignment.TopCenter;
                                lableGia.Font = new Font("Arial", 14, FontStyle.Regular);
                                lableGia.ForeColor = Color.Red;
                                lableGia.Size = new Size(panelWidth, 20);
                                RichTextBox txbTen = new RichTextBox();
                                txbTen.Tag = sp;
                                txbTen.Enabled = false;
                                txbTen.ForeColor = Color.SteelBlue;
                                //Label txbTen = new Label();
                                txbTen.Text = $"{sp.TENSANPHAM}";
                                txbTen.Location = new Point(1, panelHeight - 55);
                                txbTen.ReadOnly = true;
                                txbTen.Multiline = true;
                                txbTen.WordWrap = true;
                                txbTen.SelectAll();
                                txbTen.SelectionAlignment = HorizontalAlignment.Center;
                                txbTen.BorderStyle = BorderStyle.None;
                                txbTen.Cursor = Cursors.Hand;
                                txbTen.Font = new Font("Arial", 15, FontStyle.Bold);

                                txbTen.Size = new Size(panelWidth, 50);
                                txbTen.AutoSize = true;
                                txbTen.MaximumSize = new Size(panelWidth, 50);

                                // Tạo sự kiện click cho PictureBox
                                pictureBox.Click += (sender, e) =>
                                {
                                    PictureBox pictureClick = (PictureBox)sender;
                                    SanPham_DTO spClick = pictureClick.Tag as SanPham_DTO;
                                    addItemToOrder(spClick);
                                };

                                // Tạo sự kiện click cho Label
                                lableGia.Click += (sender, e) =>
                                {
                                    Label lblClick = (Label)sender;
                                    SanPham_DTO spClick = lblClick.Tag as SanPham_DTO;
                                    addItemToOrder(spClick);
                                };

                                // Tạo sự kiện click cho RichTextBox
                                txbTen.Click += (sender, e) =>
                                {
                                    RichTextBox txb_click = (RichTextBox)sender;
                                    SanPham_DTO spClick = txb_click.Tag as SanPham_DTO;
                                    addItemToOrder(spClick);
                                };

                                panel.Controls.Add(pictureBox);
                                panel.Controls.Add(lableGia);
                                panel.Controls.Add(txbTen);
                                panel.Location = new Point(startX, startY);
                                startX += panelWidth + spacing;
                                panel.BorderStyle = BorderStyle.FixedSingle;
                                panel_Menu.Controls.Add(panel);

                                // Kiểm tra nếu đã đạt đến cuối hàng
                                if (startX + panelWidth > panel_Menu.Width)
                                {
                                    startX = 15;
                                    startY += panelHeight + 20;
                                }
                            }

                        });
                    }

                    
                }
            }
        } 

        private void btn_DoAn_Click(object sender, EventArgs e)
        {
            if(checkMenu != 1)
            {
                hienMenu(1, "");
                checkMenu = 1;
            }
            
        }

        private void btn_DoUong_Click(object sender, EventArgs e)
        {
            if(checkMenu != 2)
            {
                hienMenu(2, "");
                checkMenu = 2;
            }
            
        }

        private void txb_Search_TextChanged(object sender, EventArgs e)
        {
            hienMenu(checkMenu, txb_Search.Text);

        }

        private void btn_KhachHang_Click(object sender, EventArgs e)
        {
            setValuePanel(panel_KhachHang);
            
            if(khachHang.MAKHACHHANG != "")
            {
                txb_SDT.Text = khachHang.SODIENTHOAI;
                lbl_TenKhachHang.Text = "Tên Khách Hàng: " + khachHang.TENKHACHHANG;
            }
            else
            {
                lbl_TenKhachHang.Text = string.Empty;
                txb_SDT.Text = string.Empty;
            }
        }


        private void txb_SDT_TextChanged(object sender, EventArgs e)
        {
            if(txb_SDT.Text.Length >=10)
            {
                KhachHang_DTO kh = new KhachHang_DTO();
                kh = QLKhachHang_BUS.timKhachHang(txb_SDT.Text);
                panel_KhachHang.Tag = kh;
                if (kh.SODIENTHOAI != "")
                {
                    
                    lbl_TenKhachHang.Text = "Tên Khách Hàng: " +kh.TENKHACHHANG;
                    lbl_TenKhachHang.ForeColor = Color.Green;
                }
                else
                {
                    lbl_TenKhachHang.Text = "Không tìm thấy khách hàng!";
                    lbl_TenKhachHang.ForeColor = Color.Red;
                }
            }
            else
            {
                lbl_TenKhachHang.Text = "";
                
            }
        }

        private void btn_LuuKH_Click(object sender, EventArgs e)
        {
            KhachHang_DTO kh = panel_KhachHang.Tag as KhachHang_DTO;
            if(kh.SODIENTHOAI != "")
            {
                khachHang = kh;
                panel_KhachHang.Visible = false;
            }
            else
            {
                lbl_TenKhachHang.Text = "Không thể lưu!";
                lbl_TenKhachHang.ForeColor = Color.Red;
            }
        }

        private void btn_ThemKH_Click(object sender, EventArgs e)
        {
            panel_ThemKH.Visible = true;
            
        }

        private void btn_closeThem_Click(object sender, EventArgs e)
        {
            panel_ThemKH.Visible = false;
        }

        private void btn_ThoatThem_Click(object sender, EventArgs e)
        {
            panel_ThemKH.Visible = false;
        }


        private bool checkTxbThem()
        {
            if(txb_ThemSDTKH.Text == "" || txb_ThemTenKH.Text == "")
            {
                return false;
            }
            return true;
        }
        private void btn_ThemSubmit_Click(object sender, EventArgs e)
        {
            
            if(checkTxbThem())
            {
                KhachHang_DTO khNew = new KhachHang_DTO();
                khNew.SODIENTHOAI = txb_ThemSDTKH.Text.Replace(" ", "");
                khNew.TENKHACHHANG = txb_ThemTenKH.Text;
                khachHang.DIEM = 0;

                //KhachHang_DTO kh = panel_ThemKH.Tag as KhachHang_DTO;
                if (khNew.SODIENTHOAI != "")
                {
                    int check = QLKhachHang_BUS.themKhachHang(khNew);
                    if(check == 1 )
                    {
                        panel_ThemKH.Tag = khNew;
                        MessageBox.Show("Thêm thành công!");
                        txb_SDT.Text = khNew.SODIENTHOAI;
                        lbl_TenKhachHang.Text = khNew.TENKHACHHANG;
                        panel_ThemKH.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại!");
                    }
                }

            }
            else
            {
                MessageBox.Show("Nhập đầy đủ thông tin!");
            }
        }
    }
}
