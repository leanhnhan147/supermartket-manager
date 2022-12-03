namespace SupermartketManager.GUI
{
    partial class FormManager
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.mniPayment = new System.Windows.Forms.ToolStripMenuItem();
            this.mniImport = new System.Windows.Forms.ToolStripMenuItem();
            this.mniManager = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hàngHóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khoHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.côngTyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mniAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.mniLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.lbAccountInfo = new System.Windows.Forms.Label();
            this.controlImport1 = new SupermartketManager.GUI.ControlImport();
            this.controlCategory1 = new SupermartketManager.GUI.ControlCategory();
            this.controlProduct1 = new SupermartketManager.GUI.ControlProduct();
            this.controlWarehouse1 = new SupermartketManager.GUI.ControlWarehouse();
            this.controlCompany1 = new SupermartketManager.GUI.ControlCompany();
            this.controlCustomer1 = new SupermartketManager.GUI.ControlCustomer();
            this.groupInfo1 = new SupermartketManager.GUI.GroupInfo();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniPayment,
            this.mniImport,
            this.mniManager,
            this.mniAccount});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1158, 36);
            this.menu.TabIndex = 8;
            this.menu.Text = "menuStrip1";
            // 
            // mniPayment
            // 
            this.mniPayment.Name = "mniPayment";
            this.mniPayment.Size = new System.Drawing.Size(115, 32);
            this.mniPayment.Text = "Bán hàng";
            this.mniPayment.Click += new System.EventHandler(this.mniPayment_Click);
            // 
            // mniImport
            // 
            this.mniImport.Name = "mniImport";
            this.mniImport.Size = new System.Drawing.Size(128, 32);
            this.mniImport.Text = "Nhập hàng";
            this.mniImport.Click += new System.EventHandler(this.mniImport_Click);
            // 
            // mniManager
            // 
            this.mniManager.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhMụcHàngToolStripMenuItem,
            this.hàngHóaToolStripMenuItem,
            this.khoHàngToolStripMenuItem,
            this.côngTyToolStripMenuItem,
            this.kháchHàngToolStripMenuItem});
            this.mniManager.Name = "mniManager";
            this.mniManager.Size = new System.Drawing.Size(99, 32);
            this.mniManager.Text = "Quản lý";
            // 
            // danhMụcHàngToolStripMenuItem
            // 
            this.danhMụcHàngToolStripMenuItem.Name = "danhMụcHàngToolStripMenuItem";
            this.danhMụcHàngToolStripMenuItem.Size = new System.Drawing.Size(244, 32);
            this.danhMụcHàngToolStripMenuItem.Text = "Danh mục hàng";
            this.danhMụcHàngToolStripMenuItem.Click += new System.EventHandler(this.danhMụcHàngToolStripMenuItem_Click);
            // 
            // hàngHóaToolStripMenuItem
            // 
            this.hàngHóaToolStripMenuItem.Name = "hàngHóaToolStripMenuItem";
            this.hàngHóaToolStripMenuItem.Size = new System.Drawing.Size(244, 32);
            this.hàngHóaToolStripMenuItem.Text = "Hàng hóa";
            this.hàngHóaToolStripMenuItem.Click += new System.EventHandler(this.hàngHóaToolStripMenuItem_Click);
            // 
            // khoHàngToolStripMenuItem
            // 
            this.khoHàngToolStripMenuItem.Name = "khoHàngToolStripMenuItem";
            this.khoHàngToolStripMenuItem.Size = new System.Drawing.Size(244, 32);
            this.khoHàngToolStripMenuItem.Text = "Kho hàng";
            this.khoHàngToolStripMenuItem.Click += new System.EventHandler(this.khoHàngToolStripMenuItem_Click);
            // 
            // côngTyToolStripMenuItem
            // 
            this.côngTyToolStripMenuItem.Name = "côngTyToolStripMenuItem";
            this.côngTyToolStripMenuItem.Size = new System.Drawing.Size(244, 32);
            this.côngTyToolStripMenuItem.Text = "Công Ty";
            this.côngTyToolStripMenuItem.Click += new System.EventHandler(this.côngTyToolStripMenuItem_Click);
            // 
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(244, 32);
            this.kháchHàngToolStripMenuItem.Text = "Khách hàng";
            this.kháchHàngToolStripMenuItem.Click += new System.EventHandler(this.kháchHàngToolStripMenuItem_Click);
            // 
            // mniAccount
            // 
            this.mniAccount.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniLogout});
            this.mniAccount.Name = "mniAccount";
            this.mniAccount.Size = new System.Drawing.Size(117, 32);
            this.mniAccount.Text = "Tài khoản";
            // 
            // mniLogout
            // 
            this.mniLogout.BackColor = System.Drawing.Color.White;
            this.mniLogout.ForeColor = System.Drawing.Color.Red;
            this.mniLogout.Name = "mniLogout";
            this.mniLogout.Size = new System.Drawing.Size(195, 32);
            this.mniLogout.Text = "Đăng xuất";
            this.mniLogout.Click += new System.EventHandler(this.mniLogout_Click);
            // 
            // lbAccountInfo
            // 
            this.lbAccountInfo.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAccountInfo.ForeColor = System.Drawing.Color.Blue;
            this.lbAccountInfo.Location = new System.Drawing.Point(723, 4);
            this.lbAccountInfo.Name = "lbAccountInfo";
            this.lbAccountInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbAccountInfo.Size = new System.Drawing.Size(435, 32);
            this.lbAccountInfo.TabIndex = 9;
            this.lbAccountInfo.Text = "Thông tin tài khoản";
            this.lbAccountInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // controlImport1
            // 
            this.controlImport1.Font = new System.Drawing.Font("Nunito SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlImport1.Location = new System.Drawing.Point(26, 78);
            this.controlImport1.Name = "controlImport1";
            this.controlImport1.Size = new System.Drawing.Size(1120, 558);
            this.controlImport1.TabIndex = 10;
            // 
            // controlCategory1
            // 
            this.controlCategory1.Location = new System.Drawing.Point(12, 78);
            this.controlCategory1.Name = "controlCategory1";
            this.controlCategory1.Size = new System.Drawing.Size(1120, 558);
            this.controlCategory1.TabIndex = 11;
            // 
            // controlProduct1
            // 
            this.controlProduct1.Font = new System.Drawing.Font("Nunito SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlProduct1.Location = new System.Drawing.Point(26, 90);
            this.controlProduct1.Name = "controlProduct1";
            this.controlProduct1.Size = new System.Drawing.Size(1120, 558);
            this.controlProduct1.TabIndex = 12;
            // 
            // controlWarehouse1
            // 
            this.controlWarehouse1.Font = new System.Drawing.Font("Nunito SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlWarehouse1.Location = new System.Drawing.Point(12, 90);
            this.controlWarehouse1.Name = "controlWarehouse1";
            this.controlWarehouse1.Size = new System.Drawing.Size(1120, 558);
            this.controlWarehouse1.TabIndex = 13;
            // 
            // controlCompany1
            // 
            this.controlCompany1.Font = new System.Drawing.Font("Nunito SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlCompany1.Location = new System.Drawing.Point(25, 78);
            this.controlCompany1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.controlCompany1.Name = "controlCompany1";
            this.controlCompany1.Size = new System.Drawing.Size(1120, 558);
            this.controlCompany1.TabIndex = 14;
            // 
            // controlCustomer1
            // 
            this.controlCustomer1.Font = new System.Drawing.Font("Nunito SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlCustomer1.Location = new System.Drawing.Point(12, 90);
            this.controlCustomer1.Name = "controlCustomer1";
            this.controlCustomer1.Size = new System.Drawing.Size(1120, 558);
            this.controlCustomer1.TabIndex = 15;
            this.controlCustomer1.Load += new System.EventHandler(this.controlCustomer1_Load);
            // 
            // groupInfo1
            // 
            this.groupInfo1.Font = new System.Drawing.Font("Nunito SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupInfo1.Location = new System.Drawing.Point(12, 56);
            this.groupInfo1.Name = "groupInfo1";
            this.groupInfo1.Size = new System.Drawing.Size(1120, 558);
            this.groupInfo1.TabIndex = 16;
            // 
            // FormManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1158, 685);
            this.Controls.Add(this.groupInfo1);
            this.Controls.Add(this.controlCustomer1);
            this.Controls.Add(this.controlCompany1);
            this.Controls.Add(this.controlWarehouse1);
            this.Controls.Add(this.controlProduct1);
            this.Controls.Add(this.controlCategory1);
            this.Controls.Add(this.controlImport1);
            this.Controls.Add(this.lbAccountInfo);
            this.Controls.Add(this.menu);
            this.Font = new System.Drawing.Font("Nunito SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormManager";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem mniPayment;
        private System.Windows.Forms.ToolStripMenuItem mniImport;
        private System.Windows.Forms.ToolStripMenuItem mniManager;
        private System.Windows.Forms.ToolStripMenuItem danhMụcHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hàngHóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khoHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem côngTyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mniAccount;
        private System.Windows.Forms.ToolStripMenuItem mniLogout;
        private System.Windows.Forms.Label lbAccountInfo;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;
        private ControlImport controlImport1;
        private ControlCategory controlCategory1;
        private ControlProduct controlProduct1;
        private ControlWarehouse controlWarehouse1;
        private ControlCompany controlCompany1;
        private ControlCustomer controlCustomer1;
        private GroupInfo groupInfo1;
    }
}