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
        int checkMenu = 1;

        private void FOrder_Load(object sender, EventArgs e)
        {
            hienMenu(1, "");
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
            MessageBox.Show(sp.TENSANPHAM);
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
