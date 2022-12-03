namespace SupermartketManager.GUI
{
    partial class FormCashier
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
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mniAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.mniLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.lbAccountInfo = new System.Windows.Forms.Label();
            this.groupInfo1 = new SupermartketManager.GUI.GroupInfo();
            this.controlCustomer1 = new SupermartketManager.GUI.ControlCustomer();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Font = new System.Drawing.Font("Nunito SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniPayment,
            this.kháchHàngToolStripMenuItem,
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
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(135, 32);
            this.kháchHàngToolStripMenuItem.Text = "Khách hàng";
            this.kháchHàngToolStripMenuItem.Click += new System.EventHandler(this.kháchHàngToolStripMenuItem_Click);
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
            this.mniLogout.Size = new System.Drawing.Size(224, 32);
            this.mniLogout.Text = "Đăng xuất";
            this.mniLogout.Click += new System.EventHandler(this.mniLogout_Click);
            // 
            // lbAccountInfo
            // 
            this.lbAccountInfo.Font = new System.Drawing.Font("Nunito SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAccountInfo.ForeColor = System.Drawing.Color.Blue;
            this.lbAccountInfo.Location = new System.Drawing.Point(723, 4);
            this.lbAccountInfo.Name = "lbAccountInfo";
            this.lbAccountInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbAccountInfo.Size = new System.Drawing.Size(435, 32);
            this.lbAccountInfo.TabIndex = 9;
            this.lbAccountInfo.Text = "Thông tin tài khoản";
            this.lbAccountInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupInfo1
            // 
            this.groupInfo1.Font = new System.Drawing.Font("Nunito SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupInfo1.Location = new System.Drawing.Point(21, 39);
            this.groupInfo1.Name = "groupInfo1";
            this.groupInfo1.Size = new System.Drawing.Size(1120, 558);
            this.groupInfo1.TabIndex = 11;
            // 
            // controlCustomer1
            // 
            this.controlCustomer1.Font = new System.Drawing.Font("Nunito SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlCustomer1.Location = new System.Drawing.Point(21, 33);
            this.controlCustomer1.Name = "controlCustomer1";
            this.controlCustomer1.Size = new System.Drawing.Size(1120, 558);
            this.controlCustomer1.TabIndex = 10;
            // 
            // FormCashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1158, 603);
            this.Controls.Add(this.groupInfo1);
            this.Controls.Add(this.controlCustomer1);
            this.Controls.Add(this.lbAccountInfo);
            this.Controls.Add(this.menu);
            this.Font = new System.Drawing.Font("Nunito SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormCashier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCashier";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCashier_FormClosing);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem mniPayment;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mniAccount;
        private System.Windows.Forms.ToolStripMenuItem mniLogout;
        private System.Windows.Forms.Label lbAccountInfo;
        private ControlCustomer controlCustomer1;
        private GroupInfo groupInfo1;
    }
}