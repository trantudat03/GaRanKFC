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
            this.btn_QuanLy = new System.Windows.Forms.Button();
            this.btn_Order = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel_Header = new System.Windows.Forms.Panel();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.lbl_logout = new System.Windows.Forms.Label();
            this.panel_sideBar.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMain.SuspendLayout();
            this.panel_Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_sideBar
            // 
            this.panel_sideBar.BackColor = System.Drawing.SystemColors.Control;
            this.panel_sideBar.Controls.Add(this.btn_QuanLy);
            this.panel_sideBar.Controls.Add(this.btn_Order);
            this.panel_sideBar.Controls.Add(this.panel2);
            this.panel_sideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_sideBar.Location = new System.Drawing.Point(0, 0);
            this.panel_sideBar.Margin = new System.Windows.Forms.Padding(4);
            this.panel_sideBar.Name = "panel_sideBar";
            this.panel_sideBar.Size = new System.Drawing.Size(208, 720);
            this.panel_sideBar.TabIndex = 0;
            // 
            // btn_QuanLy
            // 
            this.btn_QuanLy.BackColor = System.Drawing.Color.Transparent;
            this.btn_QuanLy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_QuanLy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QuanLy.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QuanLy.ForeColor = System.Drawing.Color.Black;
            this.btn_QuanLy.Location = new System.Drawing.Point(3, 369);
            this.btn_QuanLy.Name = "btn_QuanLy";
            this.btn_QuanLy.Size = new System.Drawing.Size(208, 63);
            this.btn_QuanLy.TabIndex = 2;
            this.btn_QuanLy.Text = "Quản Lý";
            this.btn_QuanLy.UseMnemonic = false;
            this.btn_QuanLy.UseVisualStyleBackColor = false;
            // 
            // btn_Order
            // 
            this.btn_Order.BackColor = System.Drawing.Color.Transparent;
            this.btn_Order.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Order.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Order.ForeColor = System.Drawing.Color.Black;
            this.btn_Order.Location = new System.Drawing.Point(0, 268);
            this.btn_Order.Name = "btn_Order";
            this.btn_Order.Size = new System.Drawing.Size(208, 63);
            this.btn_Order.TabIndex = 1;
            this.btn_Order.Text = "Order";
            this.btn_Order.UseVisualStyleBackColor = false;
            this.btn_Order.Click += new System.EventHandler(this.btn_Order_Click);
            this.btn_Order.MouseHover += new System.EventHandler(this.btn_Order_MouseHover);
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
            this.panel4.Location = new System.Drawing.Point(208, 682);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1152, 38);
            this.panel4.TabIndex = 0;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panel_Header);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(208, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1152, 682);
            this.panelMain.TabIndex = 0;
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
            // lbl_logout
            // 
            this.lbl_logout.AutoSize = true;
            this.lbl_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_logout.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_logout.Location = new System.Drawing.Point(1040, 86);
            this.lbl_logout.Name = "lbl_logout";
            this.lbl_logout.Size = new System.Drawing.Size(82, 19);
            this.lbl_logout.TabIndex = 1;
            this.lbl_logout.Text = "Đăng xuát";
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 720);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel_sideBar);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FMain";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.FMain_Load);
            this.panel_sideBar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panel_Header.ResumeLayout(false);
            this.panel_Header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_sideBar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panel_Header;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_QuanLy;
        private System.Windows.Forms.Button btn_Order;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.Label lbl_logout;
    }
}

