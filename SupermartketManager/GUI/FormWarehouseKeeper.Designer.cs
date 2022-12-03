namespace SupermartketManager.GUI
{
    partial class FormWarehouseKeeper
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
            this.lbAccountInfo = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.mniPayment = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.côngTyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khoHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mniAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.mniLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.controlProduct1 = new SupermartketManager.GUI.ControlProduct();
            this.controlImport1 = new SupermartketManager.GUI.ControlImport();
            this.groupInfo1 = new SupermartketManager.GUI.GroupInfo();
            this.controlWarehouse1 = new SupermartketManager.GUI.ControlWarehouse();
            this.controlCompany1 = new SupermartketManager.GUI.ControlCompany();
            this.controlCompany2 = new SupermartketManager.GUI.ControlCompany();
            this.controlWarehouse2 = new SupermartketManager.GUI.ControlWarehouse();
            this.groupInfo2 = new SupermartketManager.GUI.GroupInfo();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbAccountInfo
            // 
            this.lbAccountInfo.Font = new System.Drawing.Font("Nunito SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAccountInfo.ForeColor = System.Drawing.Color.Blue;
            this.lbAccountInfo.Location = new System.Drawing.Point(723, 0);
            this.lbAccountInfo.Name = "lbAccountInfo";
            this.lbAccountInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbAccountInfo.Size = new System.Drawing.Size(435, 32);
            this.lbAccountInfo.TabIndex = 11;
            this.lbAccountInfo.Text = "Thông tin tài khoản";
            this.lbAccountInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // menu
            // 
            this.menu.Font = new System.Drawing.Font("Nunito SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniPayment,
            this.kháchHàngToolStripMenuItem,
            this.côngTyToolStripMenuItem,
            this.khoHàngToolStripMenuItem,
            this.mniAccount});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1158, 36);
            this.menu.TabIndex = 10;
            this.menu.Text = "menuStrip1";
            // 
            // mniPayment
            // 
            this.mniPayment.Name = "mniPayment";
            this.mniPayment.Size = new System.Drawing.Size(128, 32);
            this.mniPayment.Text = "Nhập hàng";
            this.mniPayment.Click += new System.EventHandler(this.mniPayment_Click);
            // 
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(115, 32);
            this.kháchHàngToolStripMenuItem.Text = "Hàng hóa";
            this.kháchHàngToolStripMenuItem.Click += new System.EventHandler(this.kháchHàngToolStripMenuItem_Click);
            // 
            // côngTyToolStripMenuItem
            // 
            this.côngTyToolStripMenuItem.Name = "côngTyToolStripMenuItem";
            this.côngTyToolStripMenuItem.Size = new System.Drawing.Size(96, 32);
            this.côngTyToolStripMenuItem.Text = "Công ty";
            this.côngTyToolStripMenuItem.Click += new System.EventHandler(this.côngTyToolStripMenuItem_Click);
            // 
            // khoHàngToolStripMenuItem
            // 
            this.khoHàngToolStripMenuItem.Name = "khoHàngToolStripMenuItem";
            this.khoHàngToolStripMenuItem.Size = new System.Drawing.Size(114, 32);
            this.khoHàngToolStripMenuItem.Text = "Kho hàng";
            this.khoHàngToolStripMenuItem.Click += new System.EventHandler(this.khoHàngToolStripMenuItem_Click);
            // 
            // mniAccount
            // 
            this.mniAccount.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniLogout});
            this.mniAccount.Name = "mniAccount";
            this.mniAccount.Size = new System.Drawing.Size(115, 32);
            this.mniAccount.Text = "Tài khoản";
            // 
            // mniLogout
            // 
            this.mniLogout.BackColor = System.Drawing.Color.White;
            this.mniLogout.ForeColor = System.Drawing.Color.Red;
            this.mniLogout.Name = "mniLogout";
            this.mniLogout.Size = new System.Drawing.Size(193, 32);
            this.mniLogout.Text = "Đăng xuất";
            this.mniLogout.Click += new System.EventHandler(this.FormWarehouseKeeper_FormClosing);
            // 
            // controlProduct1
            // 
            this.controlProduct1.Font = new System.Drawing.Font("Nunito SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlProduct1.Location = new System.Drawing.Point(13, 50);
            this.controlProduct1.Name = "controlProduct1";
            this.controlProduct1.Size = new System.Drawing.Size(1120, 558);
            this.controlProduct1.TabIndex = 13;
            // 
            // controlImport1
            // 
            this.controlImport1.Font = new System.Drawing.Font("Nunito SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlImport1.Location = new System.Drawing.Point(13, 40);
            this.controlImport1.Name = "controlImport1";
            this.controlImport1.Size = new System.Drawing.Size(1120, 558);
            this.controlImport1.TabIndex = 12;
            // 
            // groupInfo1
            // 
            this.groupInfo1.Font = new System.Drawing.Font("Nunito SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupInfo1.Location = new System.Drawing.Point(13, 33);
            this.groupInfo1.Name = "groupInfo1";
            this.groupInfo1.Size = new System.Drawing.Size(1120, 558);
            this.groupInfo1.TabIndex = 14;
            // 
            // controlWarehouse1
            // 
            this.controlWarehouse1.Font = new System.Drawing.Font("Nunito SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlWarehouse1.Location = new System.Drawing.Point(26, 35);
            this.controlWarehouse1.Name = "controlWarehouse1";
            this.controlWarehouse1.Size = new System.Drawing.Size(1120, 558);
            this.controlWarehouse1.TabIndex = 15;
            // 
            // controlCompany1
            // 
            this.controlCompany1.Font = new System.Drawing.Font("Nunito SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlCompany1.Location = new System.Drawing.Point(13, 41);
            this.controlCompany1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.controlCompany1.Name = "controlCompany1";
            this.controlCompany1.Size = new System.Drawing.Size(1120, 558);
            this.controlCompany1.TabIndex = 16;
            // 
            // controlCompany2
            // 
            this.controlCompany2.Font = new System.Drawing.Font("Nunito SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlCompany2.Location = new System.Drawing.Point(13, 41);
            this.controlCompany2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.controlCompany2.Name = "controlCompany2";
            this.controlCompany2.Size = new System.Drawing.Size(1120, 558);
            this.controlCompany2.TabIndex = 18;
            this.controlCompany2.Load += new System.EventHandler(this.controlCompany2_Load);
            // 
            // controlWarehouse2
            // 
            this.controlWarehouse2.Font = new System.Drawing.Font("Nunito SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlWarehouse2.Location = new System.Drawing.Point(12, 33);
            this.controlWarehouse2.Name = "controlWarehouse2";
            this.controlWarehouse2.Size = new System.Drawing.Size(1120, 558);
            this.controlWarehouse2.TabIndex = 19;
            // 
            // groupInfo2
            // 
            this.groupInfo2.Font = new System.Drawing.Font("Nunito SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupInfo2.Location = new System.Drawing.Point(12, 35);
            this.groupInfo2.Name = "groupInfo2";
            this.groupInfo2.Size = new System.Drawing.Size(1120, 558);
            this.groupInfo2.TabIndex = 20;
            // 
            // FormWarehouseKeeper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1158, 603);
            this.Controls.Add(this.groupInfo2);
            this.Controls.Add(this.lbAccountInfo);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.controlCompany2);
            this.Controls.Add(this.groupInfo1);
            this.Controls.Add(this.controlProduct1);
            this.Controls.Add(this.controlImport1);
            this.Controls.Add(this.controlCompany1);
            this.Controls.Add(this.controlWarehouse1);
            this.Controls.Add(this.controlWarehouse2);
            this.Font = new System.Drawing.Font("Nunito SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormWarehouseKeeper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thủ kho";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormWarehouseKeeper_FormClosing);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAccountInfo;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem mniPayment;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mniAccount;
        private System.Windows.Forms.ToolStripMenuItem mniLogout;
        private ControlImport controlImport1;
        private ControlProduct controlProduct1;
        private GroupInfo groupInfo1;
        private ControlWarehouse controlWarehouse1;
        private ControlCompany controlCompany1;
        private System.Windows.Forms.ToolStripMenuItem côngTyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khoHàngToolStripMenuItem;
        private ControlCompany controlCompany2;
        private ControlWarehouse controlWarehouse2;
        private GroupInfo groupInfo2;
    }
}