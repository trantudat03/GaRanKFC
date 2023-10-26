namespace GUI
{
    partial class FQuanLyKhachHang
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_ThongBao = new System.Windows.Forms.Label();
            this.btn_Them = new System.Windows.Forms.Button();
            this.txb_SoDienThoai = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_TenKhachHang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.dgv_KhachHang = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel10 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_SuaSDT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_XacNhanKH = new System.Windows.Forms.Button();
            this.btn_HuyKH = new System.Windows.Forms.Button();
            this.txb_SuaTenKH = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_XoaCV = new System.Windows.Forms.Button();
            this.btn_SuaCV = new System.Windows.Forms.Button();
            this.lbl_ThongBao2 = new System.Windows.Forms.Label();
            this.nud_SuaDiem = new System.Windows.Forms.NumericUpDown();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhachHang)).BeginInit();
            this.panel10.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_SuaDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(3, 4);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1206, 666);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(1198, 634);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thêm Khách Hàng";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1192, 626);
            this.panel3.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1192, 577);
            this.panel1.TabIndex = 15;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_ThongBao);
            this.groupBox3.Controls.Add(this.btn_Them);
            this.groupBox3.Controls.Add(this.txb_SoDienThoai);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txb_TenKhachHang);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(31, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(962, 479);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            // 
            // lbl_ThongBao
            // 
            this.lbl_ThongBao.AutoSize = true;
            this.lbl_ThongBao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ThongBao.Location = new System.Drawing.Point(67, 369);
            this.lbl_ThongBao.Name = "lbl_ThongBao";
            this.lbl_ThongBao.Size = new System.Drawing.Size(105, 23);
            this.lbl_ThongBao.TabIndex = 19;
            this.lbl_ThongBao.Text = "Thong Bao";
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(566, 162);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(130, 63);
            this.btn_Them.TabIndex = 3;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // txb_SoDienThoai
            // 
            this.txb_SoDienThoai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_SoDienThoai.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_SoDienThoai.Location = new System.Drawing.Point(262, 197);
            this.txb_SoDienThoai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txb_SoDienThoai.Name = "txb_SoDienThoai";
            this.txb_SoDienThoai.Size = new System.Drawing.Size(178, 28);
            this.txb_SoDienThoai.TabIndex = 12;
            this.txb_SoDienThoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_SoDienThoai_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(67, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Số Điện Thoại:";
            // 
            // txb_TenKhachHang
            // 
            this.txb_TenKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_TenKhachHang.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_TenKhachHang.Location = new System.Drawing.Point(262, 86);
            this.txb_TenKhachHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txb_TenKhachHang.Name = "txb_TenKhachHang";
            this.txb_TenKhachHang.Size = new System.Drawing.Size(178, 28);
            this.txb_TenKhachHang.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tên Khách Hàng:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel4.Controls.Add(this.label15);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1192, 49);
            this.panel4.TabIndex = 16;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(12, 13);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(170, 23);
            this.label15.TabIndex = 2;
            this.label15.Text = "Thêm Khách Hàng";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel7);
            this.tabPage2.Controls.Add(this.panel6);
            this.tabPage2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(1198, 634);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Danh Sách Khách Hàng";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel11);
            this.panel7.Controls.Add(this.panel10);
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(3, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(815, 626);
            this.panel7.TabIndex = 23;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.dgv_KhachHang);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(0, 49);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(815, 262);
            this.panel11.TabIndex = 27;
            // 
            // dgv_KhachHang
            // 
            this.dgv_KhachHang.AllowUserToAddRows = false;
            this.dgv_KhachHang.AllowUserToDeleteRows = false;
            this.dgv_KhachHang.AllowUserToResizeRows = false;
            this.dgv_KhachHang.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_KhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_KhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column9,
            this.Column1,
            this.Column10});
            this.dgv_KhachHang.Location = new System.Drawing.Point(3, 1);
            this.dgv_KhachHang.Name = "dgv_KhachHang";
            this.dgv_KhachHang.RowHeadersWidth = 51;
            this.dgv_KhachHang.RowTemplate.Height = 24;
            this.dgv_KhachHang.Size = new System.Drawing.Size(613, 255);
            this.dgv_KhachHang.TabIndex = 26;
            this.dgv_KhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_KhachHang_CellClick);
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Mã Khách Hàng";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 140;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Tên Tên Khách Hàng";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 170;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Số Điện Thoại";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 160;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Điểm ";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.Width = 160;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.groupBox2);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel10.Location = new System.Drawing.Point(0, 311);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(815, 315);
            this.panel10.TabIndex = 25;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nud_SuaDiem);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txb_SuaSDT);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btn_XacNhanKH);
            this.groupBox2.Controls.Add(this.btn_HuyKH);
            this.groupBox2.Controls.Add(this.txb_SuaTenKH);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(815, 315);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 28;
            this.label2.Text = "Điểm:";
            // 
            // txb_SuaSDT
            // 
            this.txb_SuaSDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_SuaSDT.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_SuaSDT.Location = new System.Drawing.Point(255, 110);
            this.txb_SuaSDT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txb_SuaSDT.Name = "txb_SuaSDT";
            this.txb_SuaSDT.Size = new System.Drawing.Size(178, 30);
            this.txb_SuaSDT.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "Số Điện Thoại:";
            // 
            // btn_XacNhanKH
            // 
            this.btn_XacNhanKH.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_XacNhanKH.BackColor = System.Drawing.Color.Green;
            this.btn_XacNhanKH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_XacNhanKH.ForeColor = System.Drawing.Color.White;
            this.btn_XacNhanKH.Location = new System.Drawing.Point(525, 162);
            this.btn_XacNhanKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_XacNhanKH.Name = "btn_XacNhanKH";
            this.btn_XacNhanKH.Size = new System.Drawing.Size(109, 55);
            this.btn_XacNhanKH.TabIndex = 25;
            this.btn_XacNhanKH.Text = "Xác nhận";
            this.btn_XacNhanKH.UseVisualStyleBackColor = false;
            this.btn_XacNhanKH.Click += new System.EventHandler(this.btn_XacNhanKH_Click);
            // 
            // btn_HuyKH
            // 
            this.btn_HuyKH.Location = new System.Drawing.Point(657, 170);
            this.btn_HuyKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_HuyKH.Name = "btn_HuyKH";
            this.btn_HuyKH.Size = new System.Drawing.Size(96, 47);
            this.btn_HuyKH.TabIndex = 21;
            this.btn_HuyKH.Text = "Hủy";
            this.btn_HuyKH.UseVisualStyleBackColor = true;
            this.btn_HuyKH.Click += new System.EventHandler(this.btn_HuyKH_Click);
            // 
            // txb_SuaTenKH
            // 
            this.txb_SuaTenKH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_SuaTenKH.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_SuaTenKH.Location = new System.Drawing.Point(255, 38);
            this.txb_SuaTenKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txb_SuaTenKH.Name = "txb_SuaTenKH";
            this.txb_SuaTenKH.Size = new System.Drawing.Size(178, 30);
            this.txb_SuaTenKH.TabIndex = 7;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(47, 38);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(174, 24);
            this.label17.TabIndex = 10;
            this.label17.Text = "Tên Khách Hàng:";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel9.Controls.Add(this.label9);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(815, 49);
            this.panel9.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(12, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(216, 23);
            this.label9.TabIndex = 2;
            this.label9.Text = "Danh Sách Khách Hàng";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.groupBox1);
            this.panel6.Controls.Add(this.lbl_ThongBao2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(818, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(377, 626);
            this.panel6.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_XoaCV);
            this.groupBox1.Controls.Add(this.btn_SuaCV);
            this.groupBox1.Location = new System.Drawing.Point(16, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 241);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // btn_XoaCV
            // 
            this.btn_XoaCV.Location = new System.Drawing.Point(26, 138);
            this.btn_XoaCV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_XoaCV.Name = "btn_XoaCV";
            this.btn_XoaCV.Size = new System.Drawing.Size(130, 63);
            this.btn_XoaCV.TabIndex = 6;
            this.btn_XoaCV.Text = "Xóa";
            this.btn_XoaCV.UseVisualStyleBackColor = true;
            this.btn_XoaCV.Click += new System.EventHandler(this.btn_XoaCV_Click);
            // 
            // btn_SuaCV
            // 
            this.btn_SuaCV.Location = new System.Drawing.Point(26, 38);
            this.btn_SuaCV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_SuaCV.Name = "btn_SuaCV";
            this.btn_SuaCV.Size = new System.Drawing.Size(130, 63);
            this.btn_SuaCV.TabIndex = 5;
            this.btn_SuaCV.Text = "Sửa";
            this.btn_SuaCV.UseVisualStyleBackColor = true;
            this.btn_SuaCV.Click += new System.EventHandler(this.btn_SuaCV_Click);
            // 
            // lbl_ThongBao2
            // 
            this.lbl_ThongBao2.AutoSize = true;
            this.lbl_ThongBao2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ThongBao2.Location = new System.Drawing.Point(11, 350);
            this.lbl_ThongBao2.Name = "lbl_ThongBao2";
            this.lbl_ThongBao2.Size = new System.Drawing.Size(122, 26);
            this.lbl_ThongBao2.TabIndex = 19;
            this.lbl_ThongBao2.Text = "Thong Bao";
            // 
            // nud_SuaDiem
            // 
            this.nud_SuaDiem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_SuaDiem.Location = new System.Drawing.Point(255, 187);
            this.nud_SuaDiem.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nud_SuaDiem.Name = "nud_SuaDiem";
            this.nud_SuaDiem.Size = new System.Drawing.Size(178, 30);
            this.nud_SuaDiem.TabIndex = 29;
            // 
            // FQuanLyKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "FQuanLyKhachHang";
            this.Size = new System.Drawing.Size(1223, 676);
            this.Load += new System.EventHandler(this.FQuanLyKhachHang_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhachHang)).EndInit();
            this.panel10.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nud_SuaDiem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.DataGridView dgv_KhachHang;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_XacNhanKH;
        private System.Windows.Forms.Button btn_HuyKH;
        private System.Windows.Forms.TextBox txb_SuaTenKH;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_XoaCV;
        private System.Windows.Forms.Button btn_SuaCV;
        private System.Windows.Forms.Label lbl_ThongBao2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbl_ThongBao;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.TextBox txb_SoDienThoai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_TenKhachHang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_SuaSDT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nud_SuaDiem;
    }
}
