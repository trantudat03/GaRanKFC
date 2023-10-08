namespace GUI
{
    partial class FOrder
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
            this.panel_Type = new System.Windows.Forms.Panel();
            this.btn_DoUong = new System.Windows.Forms.Button();
            this.btn_DoAn = new System.Windows.Forms.Button();
            this.panel_Group = new System.Windows.Forms.Panel();
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.panel_Control = new System.Windows.Forms.Panel();
            this.panel_OrderLeft = new System.Windows.Forms.Panel();
            this.txb_Search = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel_OrderList = new System.Windows.Forms.Panel();
            this.panel_Type.SuspendLayout();
            this.panel_Group.SuspendLayout();
            this.panel_Control.SuspendLayout();
            this.panel_OrderLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Type
            // 
            this.panel_Type.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Type.Controls.Add(this.txb_Search);
            this.panel_Type.Controls.Add(this.btn_DoUong);
            this.panel_Type.Controls.Add(this.btn_DoAn);
            this.panel_Type.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Type.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_Type.Location = new System.Drawing.Point(0, 0);
            this.panel_Type.Name = "panel_Type";
            this.panel_Type.Size = new System.Drawing.Size(547, 73);
            this.panel_Type.TabIndex = 1;
            // 
            // btn_DoUong
            // 
            this.btn_DoUong.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DoUong.Location = new System.Drawing.Point(401, 13);
            this.btn_DoUong.Name = "btn_DoUong";
            this.btn_DoUong.Size = new System.Drawing.Size(130, 48);
            this.btn_DoUong.TabIndex = 2;
            this.btn_DoUong.Text = "Đồ uống";
            this.btn_DoUong.UseVisualStyleBackColor = true;
            this.btn_DoUong.Click += new System.EventHandler(this.btn_DoUong_Click);
            // 
            // btn_DoAn
            // 
            this.btn_DoAn.BackColor = System.Drawing.Color.Transparent;
            this.btn_DoAn.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DoAn.Location = new System.Drawing.Point(265, 13);
            this.btn_DoAn.Name = "btn_DoAn";
            this.btn_DoAn.Size = new System.Drawing.Size(130, 48);
            this.btn_DoAn.TabIndex = 10;
            this.btn_DoAn.Text = "Đồ ăn";
            this.btn_DoAn.UseVisualStyleBackColor = false;
            this.btn_DoAn.Click += new System.EventHandler(this.btn_DoAn_Click);
            // 
            // panel_Group
            // 
            this.panel_Group.Controls.Add(this.panel_Menu);
            this.panel_Group.Controls.Add(this.panel_Type);
            this.panel_Group.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_Group.Location = new System.Drawing.Point(587, 0);
            this.panel_Group.Name = "panel_Group";
            this.panel_Group.Size = new System.Drawing.Size(547, 754);
            this.panel_Group.TabIndex = 0;
            // 
            // panel_Menu
            // 
            this.panel_Menu.AutoScroll = true;
            this.panel_Menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Menu.Location = new System.Drawing.Point(0, 73);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(547, 681);
            this.panel_Menu.TabIndex = 2;
            this.panel_Menu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Menu_Paint);
            // 
            // panel_Control
            // 
            this.panel_Control.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Control.Controls.Add(this.button2);
            this.panel_Control.Controls.Add(this.button1);
            this.panel_Control.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Control.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_Control.Location = new System.Drawing.Point(0, 669);
            this.panel_Control.Name = "panel_Control";
            this.panel_Control.Size = new System.Drawing.Size(585, 83);
            this.panel_Control.TabIndex = 1;
            // 
            // panel_OrderLeft
            // 
            this.panel_OrderLeft.AutoScroll = true;
            this.panel_OrderLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_OrderLeft.Controls.Add(this.panel_OrderList);
            this.panel_OrderLeft.Controls.Add(this.panel_Control);
            this.panel_OrderLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_OrderLeft.Location = new System.Drawing.Point(0, 0);
            this.panel_OrderLeft.Name = "panel_OrderLeft";
            this.panel_OrderLeft.Size = new System.Drawing.Size(587, 754);
            this.panel_OrderLeft.TabIndex = 0;
            this.panel_OrderLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_OrderList_Paint);
            // 
            // txb_Search
            // 
            this.txb_Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_Search.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Search.Location = new System.Drawing.Point(22, 22);
            this.txb_Search.Name = "txb_Search";
            this.txb_Search.Size = new System.Drawing.Size(216, 39);
            this.txb_Search.TabIndex = 11;
            this.txb_Search.Tag = "Tìm kiếm";
            this.txb_Search.TextChanged += new System.EventHandler(this.txb_Search_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(13, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 71);
            this.button1.TabIndex = 0;
            this.button1.Text = "Thanh Toán";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(151, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 71);
            this.button2.TabIndex = 1;
            this.button2.Text = "Hủy";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panel_OrderList
            // 
            this.panel_OrderList.AutoScroll = true;
            this.panel_OrderList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_OrderList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_OrderList.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_OrderList.Location = new System.Drawing.Point(0, 0);
            this.panel_OrderList.Name = "panel_OrderList";
            this.panel_OrderList.Size = new System.Drawing.Size(585, 669);
            this.panel_OrderList.TabIndex = 2;
            // 
            // FOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_OrderLeft);
            this.Controls.Add(this.panel_Group);
            this.Name = "FOrder";
            this.Size = new System.Drawing.Size(1134, 754);
            this.Load += new System.EventHandler(this.FOrder_Load);
            this.panel_Type.ResumeLayout(false);
            this.panel_Type.PerformLayout();
            this.panel_Group.ResumeLayout(false);
            this.panel_Control.ResumeLayout(false);
            this.panel_OrderLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Type;
        private System.Windows.Forms.Panel panel_Group;
        private System.Windows.Forms.Panel panel_OrderLeft;
        private System.Windows.Forms.Panel panel_Control;
        private System.Windows.Forms.Button btn_DoAn;
        private System.Windows.Forms.Button btn_DoUong;
        private System.Windows.Forms.Panel panel_Menu;
        private System.Windows.Forms.TextBox txb_Search;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel_OrderList;
    }
}
