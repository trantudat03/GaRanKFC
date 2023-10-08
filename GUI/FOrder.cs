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
        private static int startY = 10;
        int checkMenu = 1;

        private void FOrder_Load(object sender, EventArgs e)
        {
            hienMenu(1, "");
            //int checkPanelHeight = 300;
            //int checkPanelWidth = 300;

            //Panel checkPanel = new Panel();
            //checkPanel.Size = new Size(checkPanelWidth, checkPanelHeight);
            //checkPanel.TabIndex = 10;
            //checkPanel.BackColor = Color.Red;
            //checkPanel.Location = new Point((panel_Group.Width) / 2, (panel_Group.Height) / 2);
        }

        private void setStyle()
        {
            //txb_Search.

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

        private void addItemToOrder(SanPham_DTO sp)
        {
            if(sp != null)
            {
                themVaoListOrderUI(sp);
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
                int spacing = 10;
                int panelWidth = panel_OrderLeft.Width - 50;
                int panelHeight = 30;
                int startX = 10;
                Panel panel = new Panel();
                panel.Tag = sp;
                panel.Size = new Size(panelWidth, panelHeight);
                panel.Location = new Point(startX, startY);
                panel.BackColor = Color.White;
                panel.BorderStyle = BorderStyle.FixedSingle;
                Label label = new Label();
                label.Tag = sp;
                label.Text = $"{sp.LoaiSanPham.TENLOAISP}: {sp.TENSANPHAM}, {sp.GIASANPHAM} VNĐ, SL:{sp.SLORDER}";
                label.Font = new Font("Arial", 14, FontStyle.Regular);
                label.Size = new Size(panelWidth-45, panelHeight);
                label.Location = new Point(5, 2);
                label.Parent = panel;
                System.Windows.Forms.Button xoaBTN = new System.Windows.Forms.Button();
                xoaBTN.Text = "Xóa";
                xoaBTN.Size = new Size(40, 25);
                xoaBTN.Cursor = Cursors.Hand;
                xoaBTN.Font = new Font("Arial", 10, FontStyle.Regular);
                xoaBTN.Location = new Point(panelWidth-43,2);
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
                }
            });

                foreach (Control control in panel.Controls)
                {
                    if (control is Panel)
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
                                        label.Text = $"{tagControl.LoaiSanPham.TENLOAISP}: {tagControl.TENSANPHAM}, {tagControl.GIASANPHAM} VNĐ, SL:{tagControl.SLORDER}";
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
                    label.Text = $"{sp.LoaiSanPham.TENLOAISP}: {sp.TENSANPHAM}, {sp.GIASANPHAM} VNĐ, SL:{sp.SLORDER}";
                    listOrder.ForEach(s =>
                    {
                        if (s.MASANPHAM == sp.MASANPHAM)
                        {
                            s.SLORDER = sp.SLORDER;
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
           
            Panel panelDelete = new Panel();
            int check = 0;
            foreach (Control control in panel.Controls)
            {
                if (control is Panel)
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
                        control.Location = new Point(10, y - 40);
                        
                    }
                }
            }
            if(check==1)
            {
                startY -= 40;
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
                                lableGia.Text = $"{sp.GIASANPHAM} VNĐ ";
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
                                txbTen.Location = new Point(1, panelHeight - 60);
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
                                    startX = 10;
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
                                lableGia.Text = $"{sp.GIASANPHAM} VNĐ ";
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
                                txbTen.Location = new Point(1, panelHeight - 60);
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
                                    startX = 10;
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
            hienMenu(1,"");
            checkMenu = 1;
        }

        private void btn_DoUong_Click(object sender, EventArgs e)
        {
            hienMenu(2, "");
            checkMenu= 2;
        }

        private void txb_Search_TextChanged(object sender, EventArgs e)
        {
            hienMenu(checkMenu, txb_Search.Text);

        }
    }
}
