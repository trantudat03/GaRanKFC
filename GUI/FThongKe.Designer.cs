namespace GUI
{
    partial class FThongKe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabThongKe = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dgv_ThongKe = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox_DateTime = new System.Windows.Forms.GroupBox();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.cmb_ListThongKe = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.BieuDoCotSpBanChay = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel_NameColumn = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox_DateTimeSP = new System.Windows.Forms.GroupBox();
            this.dateTimePickerToSP = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePickerFromSP = new System.Windows.Forms.DateTimePicker();
            this.cmb_DateTimeSP = new System.Windows.Forms.ComboBox();
            this.tabThongKe.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongKe)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox_DateTime.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel9.SuspendLayout();
            this.BieuDoCotSpBanChay.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox_DateTimeSP.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabThongKe
            // 
            this.tabThongKe.Controls.Add(this.tabPage1);
            this.tabThongKe.Controls.Add(this.tabPage2);
            this.tabThongKe.Location = new System.Drawing.Point(16, 19);
            this.tabThongKe.Name = "tabThongKe";
            this.tabThongKe.SelectedIndex = 0;
            this.tabThongKe.Size = new System.Drawing.Size(1166, 723);
            this.tabThongKe.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1158, 691);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Doanh Thu";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(865, 685);
            this.panel4.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dgv_ThongKe);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 45);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(865, 640);
            this.panel6.TabIndex = 5;
            // 
            // dgv_ThongKe
            // 
            this.dgv_ThongKe.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dgv_ThongKe.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_ThongKe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_ThongKe.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_ThongKe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_ThongKe.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ThongKe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_ThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ThongKe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgv_ThongKe.Location = new System.Drawing.Point(3, 22);
            this.dgv_ThongKe.Name = "dgv_ThongKe";
            this.dgv_ThongKe.RowHeadersWidth = 51;
            this.dgv_ThongKe.RowTemplate.Height = 24;
            this.dgv_ThongKe.Size = new System.Drawing.Size(844, 271);
            this.dgv_ThongKe.TabIndex = 1;
            this.dgv_ThongKe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã Đơn Hàng";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 120;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên Nhân Viên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tên Khách Hàng";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tên Khuyễn Mãi";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 140;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Giá Trị ĐH";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Thời Gian";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel5.Controls.Add(this.label2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(865, 45);
            this.panel5.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thống Kê Đơn Hàng";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.groupBox_DateTime);
            this.panel3.Controls.Add(this.cmb_ListThongKe);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(868, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(287, 685);
            this.panel3.TabIndex = 2;
            // 
            // groupBox_DateTime
            // 
            this.groupBox_DateTime.Controls.Add(this.dateTimePickerTo);
            this.groupBox_DateTime.Controls.Add(this.label3);
            this.groupBox_DateTime.Controls.Add(this.label1);
            this.groupBox_DateTime.Controls.Add(this.dateTimePickerFrom);
            this.groupBox_DateTime.Location = new System.Drawing.Point(5, 138);
            this.groupBox_DateTime.Name = "groupBox_DateTime";
            this.groupBox_DateTime.Size = new System.Drawing.Size(265, 255);
            this.groupBox_DateTime.TabIndex = 6;
            this.groupBox_DateTime.TabStop = false;
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTo.Location = new System.Drawing.Point(18, 169);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(200, 30);
            this.dateTimePickerTo.TabIndex = 6;
            this.dateTimePickerTo.ValueChanged += new System.EventHandler(this.dateTimePickerTo_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Đến Ngày";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Từ Ngày";
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(18, 69);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(200, 30);
            this.dateTimePickerFrom.TabIndex = 0;
            this.dateTimePickerFrom.ValueChanged += new System.EventHandler(this.dateTimePickerFrom_ValueChanged);
            // 
            // cmb_ListThongKe
            // 
            this.cmb_ListThongKe.FormattingEnabled = true;
            this.cmb_ListThongKe.Location = new System.Drawing.Point(25, 44);
            this.cmb_ListThongKe.Name = "cmb_ListThongKe";
            this.cmb_ListThongKe.Size = new System.Drawing.Size(224, 27);
            this.cmb_ListThongKe.TabIndex = 5;
            this.cmb_ListThongKe.SelectedIndexChanged += new System.EventHandler(this.cmb_ListThongKe_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.panel7);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1158, 691);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sản Phẩm";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(864, 45);
            this.panel1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(11, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(281, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Thống Kê Sản Phẩm Bán Chạy";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(864, 685);
            this.panel7.TabIndex = 3;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.BieuDoCotSpBanChay);
            this.panel9.Controls.Add(this.panel_NameColumn);
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Location = new System.Drawing.Point(15, 61);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(830, 524);
            this.panel9.TabIndex = 7;
            // 
            // BieuDoCotSpBanChay
            // 
            this.BieuDoCotSpBanChay.AutoScroll = true;
            this.BieuDoCotSpBanChay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BieuDoCotSpBanChay.Controls.Add(this.dateTimePicker1);
            this.BieuDoCotSpBanChay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BieuDoCotSpBanChay.Location = new System.Drawing.Point(57, 0);
            this.BieuDoCotSpBanChay.Name = "BieuDoCotSpBanChay";
            this.BieuDoCotSpBanChay.Size = new System.Drawing.Size(773, 444);
            this.BieuDoCotSpBanChay.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(104, 88);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 30);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // panel_NameColumn
            // 
            this.panel_NameColumn.AutoScroll = true;
            this.panel_NameColumn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_NameColumn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_NameColumn.Location = new System.Drawing.Point(57, 444);
            this.panel_NameColumn.Name = "panel_NameColumn";
            this.panel_NameColumn.Size = new System.Drawing.Size(773, 80);
            this.panel_NameColumn.TabIndex = 8;
            // 
            // panel10
            // 
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(57, 524);
            this.panel10.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox_DateTimeSP);
            this.panel2.Controls.Add(this.cmb_DateTimeSP);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(867, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(288, 685);
            this.panel2.TabIndex = 1;
            // 
            // groupBox_DateTimeSP
            // 
            this.groupBox_DateTimeSP.Controls.Add(this.dateTimePickerToSP);
            this.groupBox_DateTimeSP.Controls.Add(this.label5);
            this.groupBox_DateTimeSP.Controls.Add(this.label6);
            this.groupBox_DateTimeSP.Controls.Add(this.dateTimePickerFromSP);
            this.groupBox_DateTimeSP.Location = new System.Drawing.Point(20, 150);
            this.groupBox_DateTimeSP.Name = "groupBox_DateTimeSP";
            this.groupBox_DateTimeSP.Size = new System.Drawing.Size(265, 255);
            this.groupBox_DateTimeSP.TabIndex = 7;
            this.groupBox_DateTimeSP.TabStop = false;
            // 
            // dateTimePickerToSP
            // 
            this.dateTimePickerToSP.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerToSP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerToSP.Location = new System.Drawing.Point(18, 169);
            this.dateTimePickerToSP.Name = "dateTimePickerToSP";
            this.dateTimePickerToSP.Size = new System.Drawing.Size(200, 30);
            this.dateTimePickerToSP.TabIndex = 6;
            this.dateTimePickerToSP.ValueChanged += new System.EventHandler(this.dateTimePickerToSP_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 32);
            this.label5.TabIndex = 5;
            this.label5.Text = "Đến Ngày";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 32);
            this.label6.TabIndex = 1;
            this.label6.Text = "Từ Ngày";
            // 
            // dateTimePickerFromSP
            // 
            this.dateTimePickerFromSP.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFromSP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFromSP.Location = new System.Drawing.Point(18, 69);
            this.dateTimePickerFromSP.Name = "dateTimePickerFromSP";
            this.dateTimePickerFromSP.Size = new System.Drawing.Size(200, 30);
            this.dateTimePickerFromSP.TabIndex = 0;
            this.dateTimePickerFromSP.ValueChanged += new System.EventHandler(this.dateTimePickerFromSP_ValueChanged);
            // 
            // cmb_DateTimeSP
            // 
            this.cmb_DateTimeSP.FormattingEnabled = true;
            this.cmb_DateTimeSP.Location = new System.Drawing.Point(34, 61);
            this.cmb_DateTimeSP.Name = "cmb_DateTimeSP";
            this.cmb_DateTimeSP.Size = new System.Drawing.Size(224, 27);
            this.cmb_DateTimeSP.TabIndex = 6;
            this.cmb_DateTimeSP.SelectedIndexChanged += new System.EventHandler(this.cmb_DateTimeSP_SelectedIndexChanged);
            // 
            // FThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabThongKe);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FThongKe";
            this.Size = new System.Drawing.Size(1185, 759);
            this.Load += new System.EventHandler(this.FThongKe_Load);
            this.tabThongKe.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongKe)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox_DateTime.ResumeLayout(false);
            this.groupBox_DateTime.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.BieuDoCotSpBanChay.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox_DateTimeSP.ResumeLayout(false);
            this.groupBox_DateTimeSP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabThongKe;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgv_ThongKe;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox cmb_ListThongKe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.GroupBox groupBox_DateTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel BieuDoCotSpBanChay;
        private System.Windows.Forms.Panel panel_NameColumn;
        private System.Windows.Forms.GroupBox groupBox_DateTimeSP;
        private System.Windows.Forms.DateTimePicker dateTimePickerToSP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePickerFromSP;
        private System.Windows.Forms.ComboBox cmb_DateTimeSP;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}
