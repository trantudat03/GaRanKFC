namespace GUI
{
    partial class FQuanLyNguoiDung
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_DanhSachND = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBoxContent = new System.Windows.Forms.GroupBox();
            this.btn_XacNhan = new System.Windows.Forms.Button();
            this.txb_MatKhau = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_TenDangNhap = new System.Windows.Forms.TextBox();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.txb_SoDienThoai = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_TrangThai = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_Email = new System.Windows.Forms.TextBox();
            this.cmb_ChucVu = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_TenNguoiDung = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBoxControl = new System.Windows.Forms.GroupBox();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.lbl_ThongBao = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachND)).BeginInit();
            this.panel5.SuspendLayout();
            this.groupBoxContent.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBoxControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(10, 4);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1450, 666);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(1442, 634);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Người Dùng";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1059, 626);
            this.panel3.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_DanhSachND);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1059, 284);
            this.panel1.TabIndex = 15;
            // 
            // dgv_DanhSachND
            // 
            this.dgv_DanhSachND.AllowUserToAddRows = false;
            this.dgv_DanhSachND.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachND.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgv_DanhSachND.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_DanhSachND.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgv_DanhSachND.Location = new System.Drawing.Point(0, 0);
            this.dgv_DanhSachND.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_DanhSachND.Name = "dgv_DanhSachND";
            this.dgv_DanhSachND.RowHeadersWidth = 51;
            this.dgv_DanhSachND.RowTemplate.Height = 24;
            this.dgv_DanhSachND.Size = new System.Drawing.Size(1059, 284);
            this.dgv_DanhSachND.TabIndex = 15;
            this.dgv_DanhSachND.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSachND_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã Người Dùng";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 140;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên Người Dùng ";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Chức Vụ";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 140;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Số Điện Thoại";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Email";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 180;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Tên Đăng Nhập";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 150;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Trạng Thái";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 120;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.groupBoxContent);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 333);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1059, 293);
            this.panel5.TabIndex = 17;
            // 
            // groupBoxContent
            // 
            this.groupBoxContent.Controls.Add(this.btn_XacNhan);
            this.groupBoxContent.Controls.Add(this.txb_MatKhau);
            this.groupBoxContent.Controls.Add(this.label1);
            this.groupBoxContent.Controls.Add(this.txb_TenDangNhap);
            this.groupBoxContent.Controls.Add(this.btn_Thoat);
            this.groupBoxContent.Controls.Add(this.txb_SoDienThoai);
            this.groupBoxContent.Controls.Add(this.label8);
            this.groupBoxContent.Controls.Add(this.cmb_TrangThai);
            this.groupBoxContent.Controls.Add(this.label7);
            this.groupBoxContent.Controls.Add(this.label6);
            this.groupBoxContent.Controls.Add(this.label3);
            this.groupBoxContent.Controls.Add(this.txb_Email);
            this.groupBoxContent.Controls.Add(this.cmb_ChucVu);
            this.groupBoxContent.Controls.Add(this.label5);
            this.groupBoxContent.Controls.Add(this.txb_TenNguoiDung);
            this.groupBoxContent.Controls.Add(this.label4);
            this.groupBoxContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxContent.Location = new System.Drawing.Point(0, 0);
            this.groupBoxContent.Name = "groupBoxContent";
            this.groupBoxContent.Size = new System.Drawing.Size(1059, 293);
            this.groupBoxContent.TabIndex = 14;
            this.groupBoxContent.TabStop = false;
            // 
            // btn_XacNhan
            // 
            this.btn_XacNhan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_XacNhan.BackColor = System.Drawing.Color.Green;
            this.btn_XacNhan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_XacNhan.ForeColor = System.Drawing.Color.White;
            this.btn_XacNhan.Location = new System.Drawing.Point(643, 221);
            this.btn_XacNhan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_XacNhan.Name = "btn_XacNhan";
            this.btn_XacNhan.Size = new System.Drawing.Size(109, 55);
            this.btn_XacNhan.TabIndex = 25;
            this.btn_XacNhan.Text = "Xác nhận";
            this.btn_XacNhan.UseVisualStyleBackColor = false;
            this.btn_XacNhan.Click += new System.EventHandler(this.btn_XacNhan_Click);
            // 
            // txb_MatKhau
            // 
            this.txb_MatKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_MatKhau.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_MatKhau.Location = new System.Drawing.Point(800, 82);
            this.txb_MatKhau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txb_MatKhau.Name = "txb_MatKhau";
            this.txb_MatKhau.Size = new System.Drawing.Size(178, 28);
            this.txb_MatKhau.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(596, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "Mật Khẩu";
            // 
            // txb_TenDangNhap
            // 
            this.txb_TenDangNhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_TenDangNhap.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_TenDangNhap.Location = new System.Drawing.Point(796, 21);
            this.txb_TenDangNhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txb_TenDangNhap.Name = "txb_TenDangNhap";
            this.txb_TenDangNhap.Size = new System.Drawing.Size(178, 28);
            this.txb_TenDangNhap.TabIndex = 22;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(854, 229);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(96, 47);
            this.btn_Thoat.TabIndex = 21;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // txb_SoDienThoai
            // 
            this.txb_SoDienThoai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_SoDienThoai.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_SoDienThoai.Location = new System.Drawing.Point(266, 147);
            this.txb_SoDienThoai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txb_SoDienThoai.Name = "txb_SoDienThoai";
            this.txb_SoDienThoai.Size = new System.Drawing.Size(178, 28);
            this.txb_SoDienThoai.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(596, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 24);
            this.label8.TabIndex = 18;
            this.label8.Text = "Trạng thái :";
            // 
            // cmb_TrangThai
            // 
            this.cmb_TrangThai.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_TrangThai.FormattingEnabled = true;
            this.cmb_TrangThai.Location = new System.Drawing.Point(800, 151);
            this.cmb_TrangThai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb_TrangThai.Name = "cmb_TrangThai";
            this.cmb_TrangThai.Size = new System.Drawing.Size(178, 29);
            this.cmb_TrangThai.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(68, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 24);
            this.label7.TabIndex = 15;
            this.label7.Text = "Số Điện Thoại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(596, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tên Đăng Nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Chức Vụ";
            // 
            // txb_Email
            // 
            this.txb_Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_Email.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Email.Location = new System.Drawing.Point(266, 207);
            this.txb_Email.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txb_Email.Name = "txb_Email";
            this.txb_Email.Size = new System.Drawing.Size(178, 28);
            this.txb_Email.TabIndex = 12;
            // 
            // cmb_ChucVu
            // 
            this.cmb_ChucVu.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_ChucVu.FormattingEnabled = true;
            this.cmb_ChucVu.Location = new System.Drawing.Point(266, 24);
            this.cmb_ChucVu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb_ChucVu.Name = "cmb_ChucVu";
            this.cmb_ChucVu.Size = new System.Drawing.Size(178, 29);
            this.cmb_ChucVu.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(68, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Email";
            // 
            // txb_TenNguoiDung
            // 
            this.txb_TenNguoiDung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_TenNguoiDung.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_TenNguoiDung.Location = new System.Drawing.Point(266, 82);
            this.txb_TenNguoiDung.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txb_TenNguoiDung.Name = "txb_TenNguoiDung";
            this.txb_TenNguoiDung.Size = new System.Drawing.Size(178, 28);
            this.txb_TenNguoiDung.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(68, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Họ Và Tên";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel4.Controls.Add(this.label15);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1059, 49);
            this.panel4.TabIndex = 16;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(12, 13);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(217, 23);
            this.label15.TabIndex = 2;
            this.label15.Text = "Danh Sách Người Dùng";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBoxControl);
            this.panel2.Controls.Add(this.lbl_ThongBao);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1062, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(377, 626);
            this.panel2.TabIndex = 21;
            // 
            // groupBoxControl
            // 
            this.groupBoxControl.Controls.Add(this.btn_Xoa);
            this.groupBoxControl.Controls.Add(this.btn_Sua);
            this.groupBoxControl.Controls.Add(this.btn_Them);
            this.groupBoxControl.Location = new System.Drawing.Point(16, 13);
            this.groupBoxControl.Name = "groupBoxControl";
            this.groupBoxControl.Size = new System.Drawing.Size(358, 340);
            this.groupBoxControl.TabIndex = 5;
            this.groupBoxControl.TabStop = false;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(26, 257);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(130, 63);
            this.btn_Xoa.TabIndex = 6;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(26, 149);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(130, 63);
            this.btn_Sua.TabIndex = 5;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(26, 27);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(130, 63);
            this.btn_Them.TabIndex = 4;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // lbl_ThongBao
            // 
            this.lbl_ThongBao.AutoSize = true;
            this.lbl_ThongBao.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ThongBao.Location = new System.Drawing.Point(11, 385);
            this.lbl_ThongBao.Name = "lbl_ThongBao";
            this.lbl_ThongBao.Size = new System.Drawing.Size(122, 26);
            this.lbl_ThongBao.TabIndex = 19;
            this.lbl_ThongBao.Text = "Thong Bao";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(1442, 634);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Chức Vụ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // FQuanLyNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FQuanLyNguoiDung";
            this.Size = new System.Drawing.Size(1462, 674);
            this.Load += new System.EventHandler(this.FQuanLyNguoiDung_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachND)).EndInit();
            this.panel5.ResumeLayout(false);
            this.groupBoxContent.ResumeLayout(false);
            this.groupBoxContent.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBoxControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBoxContent;
        private System.Windows.Forms.Label lbl_ThongBao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb_TrangThai;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_Email;
        private System.Windows.Forms.ComboBox cmb_ChucVu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_TenNguoiDung;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgv_DanhSachND;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txb_SoDienThoai;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txb_MatKhau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_TenDangNhap;
        private System.Windows.Forms.Button btn_XacNhan;
        private System.Windows.Forms.GroupBox groupBoxControl;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}
