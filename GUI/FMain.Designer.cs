namespace GUI
{
    partial class FMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_sideBar = new System.Windows.Forms.Panel();
            this.panel_QuanLy = new System.Windows.Forms.Panel();
            this.btn_QLKhuyenMai = new System.Windows.Forms.Button();
            this.btn_ThongKe = new System.Windows.Forms.Button();
            this.btn_QLKhachHang = new System.Windows.Forms.Button();
            this.btn_QLNguoiDung = new System.Windows.Forms.Button();
            this.btn_QLSanPham = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Order = new System.Windows.Forms.Button();
            this.btn_QuanLy = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelGroup = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel_Header = new System.Windows.Forms.Panel();
            this.lbl_logout = new System.Windows.Forms.Label();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.panel_sideBar.SuspendLayout();
            this.panel_QuanLy.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelGroup.SuspendLayout();
            this.panel_Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_sideBar
            // 
            this.panel_sideBar.BackColor = System.Drawing.SystemColors.Control;
            this.panel_sideBar.Controls.Add(this.panel_QuanLy);
            this.panel_sideBar.Controls.Add(this.panel3);
            this.panel_sideBar.Controls.Add(this.panel2);
            this.panel_sideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_sideBar.Location = new System.Drawing.Point(0, 0);
            this.panel_sideBar.Margin = new System.Windows.Forms.Padding(4);
            this.panel_sideBar.Name = "panel_sideBar";
            this.panel_sideBar.Size = new System.Drawing.Size(208, 811);
            this.panel_sideBar.TabIndex = 0;
            // 
            // panel_QuanLy
            // 
            this.panel_QuanLy.Controls.Add(this.btn_QLKhuyenMai);
            this.panel_QuanLy.Controls.Add(this.btn_ThongKe);
            this.panel_QuanLy.Controls.Add(this.btn_QLKhachHang);
            this.panel_QuanLy.Controls.Add(this.btn_QLNguoiDung);
            this.panel_QuanLy.Controls.Add(this.btn_QLSanPham);
            this.panel_QuanLy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_QuanLy.Location = new System.Drawing.Point(0, 378);
            this.panel_QuanLy.Name = "panel_QuanLy";
            this.panel_QuanLy.Size = new System.Drawing.Size(208, 433);
            this.panel_QuanLy.TabIndex = 3;
            this.panel_QuanLy.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_QuanLy_Paint);
            // 
            // btn_QLKhuyenMai
            // 
            this.btn_QLKhuyenMai.BackColor = System.Drawing.Color.Transparent;
            this.btn_QLKhuyenMai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_QLKhuyenMai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QLKhuyenMai.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLKhuyenMai.ForeColor = System.Drawing.Color.Black;
            this.btn_QLKhuyenMai.Location = new System.Drawing.Point(6, 246);
            this.btn_QLKhuyenMai.Name = "btn_QLKhuyenMai";
            this.btn_QLKhuyenMai.Size = new System.Drawing.Size(198, 63);
            this.btn_QLKhuyenMai.TabIndex = 7;
            this.btn_QLKhuyenMai.Text = "Khuyễn Mãi";
            this.btn_QLKhuyenMai.UseMnemonic = false;
            this.btn_QLKhuyenMai.UseVisualStyleBackColor = false;
            // 
            // btn_ThongKe
            // 
            this.btn_ThongKe.BackColor = System.Drawing.Color.Transparent;
            this.btn_ThongKe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThongKe.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThongKe.ForeColor = System.Drawing.Color.Black;
            this.btn_ThongKe.Location = new System.Drawing.Point(3, 326);
            this.btn_ThongKe.Name = "btn_ThongKe";
            this.btn_ThongKe.Size = new System.Drawing.Size(202, 63);
            this.btn_ThongKe.TabIndex = 6;
            this.btn_ThongKe.Text = "Thống Kê";
            this.btn_ThongKe.UseMnemonic = false;
            this.btn_ThongKe.UseVisualStyleBackColor = false;
            this.btn_ThongKe.Click += new System.EventHandler(this.btn_ThongKe_Click);
            // 
            // btn_QLKhachHang
            // 
            this.btn_QLKhachHang.BackColor = System.Drawing.Color.Transparent;
            this.btn_QLKhachHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_QLKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QLKhachHang.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLKhachHang.ForeColor = System.Drawing.Color.Black;
            this.btn_QLKhachHang.Location = new System.Drawing.Point(3, 170);
            this.btn_QLKhachHang.Name = "btn_QLKhachHang";
            this.btn_QLKhachHang.Size = new System.Drawing.Size(202, 63);
            this.btn_QLKhachHang.TabIndex = 5;
            this.btn_QLKhachHang.Text = "Khách Hàng";
            this.btn_QLKhachHang.UseMnemonic = false;
            this.btn_QLKhachHang.UseVisualStyleBackColor = false;
            // 
            // btn_QLNguoiDung
            // 
            this.btn_QLNguoiDung.BackColor = System.Drawing.Color.Transparent;
            this.btn_QLNguoiDung.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_QLNguoiDung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QLNguoiDung.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLNguoiDung.ForeColor = System.Drawing.Color.Black;
            this.btn_QLNguoiDung.Location = new System.Drawing.Point(3, 91);
            this.btn_QLNguoiDung.Name = "btn_QLNguoiDung";
            this.btn_QLNguoiDung.Size = new System.Drawing.Size(202, 63);
            this.btn_QLNguoiDung.TabIndex = 4;
            this.btn_QLNguoiDung.Text = "Người Dùng";
            this.btn_QLNguoiDung.UseMnemonic = false;
            this.btn_QLNguoiDung.UseVisualStyleBackColor = false;
            // 
            // btn_QLSanPham
            // 
            this.btn_QLSanPham.BackColor = System.Drawing.Color.Transparent;
            this.btn_QLSanPham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_QLSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QLSanPham.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLSanPham.ForeColor = System.Drawing.Color.Black;
            this.btn_QLSanPham.Location = new System.Drawing.Point(3, 14);
            this.btn_QLSanPham.Name = "btn_QLSanPham";
            this.btn_QLSanPham.Size = new System.Drawing.Size(202, 63);
            this.btn_QLSanPham.TabIndex = 3;
            this.btn_QLSanPham.Text = "Sản Phẩm";
            this.btn_QLSanPham.UseMnemonic = false;
            this.btn_QLSanPham.UseVisualStyleBackColor = false;
            this.btn_QLSanPham.Click += new System.EventHandler(this.btn_QLSanPham_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_Order);
            this.panel3.Controls.Add(this.btn_QuanLy);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 174);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(208, 204);
            this.panel3.TabIndex = 4;
            // 
            // btn_Order
            // 
            this.btn_Order.BackColor = System.Drawing.Color.Transparent;
            this.btn_Order.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Order.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Order.ForeColor = System.Drawing.Color.Black;
            this.btn_Order.Location = new System.Drawing.Point(0, 48);
            this.btn_Order.Name = "btn_Order";
            this.btn_Order.Size = new System.Drawing.Size(205, 63);
            this.btn_Order.TabIndex = 1;
            this.btn_Order.Text = "Order";
            this.btn_Order.UseVisualStyleBackColor = false;
            this.btn_Order.Click += new System.EventHandler(this.btn_Order_Click);
            // 
            // btn_QuanLy
            // 
            this.btn_QuanLy.BackColor = System.Drawing.Color.Transparent;
            this.btn_QuanLy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_QuanLy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QuanLy.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QuanLy.ForeColor = System.Drawing.Color.Black;
            this.btn_QuanLy.Location = new System.Drawing.Point(0, 133);
            this.btn_QuanLy.Name = "btn_QuanLy";
            this.btn_QuanLy.Size = new System.Drawing.Size(208, 63);
            this.btn_QuanLy.TabIndex = 2;
            this.btn_QuanLy.Text = "Quản Lý";
            this.btn_QuanLy.UseMnemonic = false;
            this.btn_QuanLy.UseVisualStyleBackColor = false;
            this.btn_QuanLy.Click += new System.EventHandler(this.btn_QuanLy_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(208, 174);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.logo2;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(208, 773);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1152, 38);
            this.panel4.TabIndex = 0;
            // 
            // panelGroup
            // 
            this.panelGroup.Controls.Add(this.panelMain);
            this.panelGroup.Controls.Add(this.panel_Header);
            this.panelGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGroup.Location = new System.Drawing.Point(208, 0);
            this.panelGroup.Margin = new System.Windows.Forms.Padding(4);
            this.panelGroup.Name = "panelGroup";
            this.panelGroup.Size = new System.Drawing.Size(1152, 773);
            this.panelGroup.TabIndex = 0;
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 143);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1152, 630);
            this.panelMain.TabIndex = 1;
            // 
            // panel_Header
            // 
            this.panel_Header.Controls.Add(this.lbl_logout);
            this.panel_Header.Controls.Add(this.lbl_UserName);
            this.panel_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Header.Location = new System.Drawing.Point(0, 0);
            this.panel_Header.Name = "panel_Header";
            this.panel_Header.Size = new System.Drawing.Size(1152, 143);
            this.panel_Header.TabIndex = 0;
            // 
            // lbl_logout
            // 
            this.lbl_logout.AutoSize = true;
            this.lbl_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_logout.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_logout.Location = new System.Drawing.Point(1040, 86);
            this.lbl_logout.Name = "lbl_logout";
            this.lbl_logout.Size = new System.Drawing.Size(82, 19);
            this.lbl_logout.TabIndex = 1;
            this.lbl_logout.Text = "Đăng xuất";
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserName.Location = new System.Drawing.Point(999, 38);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(123, 26);
            this.lbl_UserName.TabIndex = 0;
            this.lbl_UserName.Text = "UserName";
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 811);
            this.Controls.Add(this.panelGroup);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel_sideBar);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FMain_Load);
            this.panel_sideBar.ResumeLayout(false);
            this.panel_QuanLy.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelGroup.ResumeLayout(false);
            this.panel_Header.ResumeLayout(false);
            this.panel_Header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_sideBar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelGroup;
        private System.Windows.Forms.Panel panel_Header;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_QuanLy;
        private System.Windows.Forms.Button btn_Order;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.Label lbl_logout;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel_QuanLy;
        private System.Windows.Forms.Button btn_QLSanPham;
        private System.Windows.Forms.Button btn_ThongKe;
        private System.Windows.Forms.Button btn_QLKhachHang;
        private System.Windows.Forms.Button btn_QLNguoiDung;
        private System.Windows.Forms.Button btn_QLKhuyenMai;
    }
}

