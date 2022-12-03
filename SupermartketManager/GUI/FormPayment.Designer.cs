namespace SupermartketManager.GUI
{
    partial class FormPayment
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDeleteBillInfo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnCustomerSearch = new System.Windows.Forms.Button();
            this.lbCPoint = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbFinalTotal = new System.Windows.Forms.Label();
            this.btnPayment = new System.Windows.Forms.Button();
            this.txtCName = new System.Windows.Forms.TextBox();
            this.txtCPhone = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.dgvBillInfos = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtEId = new System.Windows.Forms.TextBox();
            this.lbAccountInfo = new System.Windows.Forms.Label();
            this.btnReload = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillInfos)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nunito ExtraBold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 46);
            this.label1.TabIndex = 45;
            this.label1.Text = "Bán hàng";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1134, 625);
            this.panel1.TabIndex = 46;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.btnSave);
            this.panel5.Controls.Add(this.btnDeleteBillInfo);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.txtQuantity);
            this.panel5.Controls.Add(this.txtName);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.txtPrice);
            this.panel5.Location = new System.Drawing.Point(8, 439);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(610, 183);
            this.panel5.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(459, 70);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 40);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDeleteBillInfo
            // 
            this.btnDeleteBillInfo.Location = new System.Drawing.Point(459, 118);
            this.btnDeleteBillInfo.Name = "btnDeleteBillInfo";
            this.btnDeleteBillInfo.Size = new System.Drawing.Size(140, 40);
            this.btnDeleteBillInfo.TabIndex = 7;
            this.btnDeleteBillInfo.Text = "Xóa";
            this.btnDeleteBillInfo.UseVisualStyleBackColor = true;
            this.btnDeleteBillInfo.Click += new System.EventHandler(this.btnCancelBillInfo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số lượng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 28);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mặt hàng:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Nunito SemiBold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(135, 96);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(222, 53);
            this.txtQuantity.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(10, 31);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(347, 35);
            this.txtName.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(372, -1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 28);
            this.label6.TabIndex = 1;
            this.label6.Text = "Đơn giá:";
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Location = new System.Drawing.Point(371, 30);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(228, 35);
            this.txtPrice.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.dgvBillInfos);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(630, 40);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(501, 619);
            this.panel4.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnCustomerSearch);
            this.panel6.Controls.Add(this.lbCPoint);
            this.panel6.Controls.Add(this.lbTotal);
            this.panel6.Controls.Add(this.lbFinalTotal);
            this.panel6.Controls.Add(this.btnPayment);
            this.panel6.Controls.Add(this.txtCName);
            this.panel6.Controls.Add(this.txtCPhone);
            this.panel6.Controls.Add(this.btnCancel);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.txtDiscount);
            this.panel6.Location = new System.Drawing.Point(0, 300);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(500, 279);
            this.panel6.TabIndex = 46;
            // 
            // btnCustomerSearch
            // 
            this.btnCustomerSearch.BackgroundImage = global::SupermartketManager.Properties.Resources.search_icon;
            this.btnCustomerSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCustomerSearch.Location = new System.Drawing.Point(297, 2);
            this.btnCustomerSearch.Name = "btnCustomerSearch";
            this.btnCustomerSearch.Size = new System.Drawing.Size(36, 36);
            this.btnCustomerSearch.TabIndex = 15;
            this.btnCustomerSearch.UseVisualStyleBackColor = true;
            this.btnCustomerSearch.Click += new System.EventHandler(this.btnCustomerSearch_Click);
            // 
            // lbCPoint
            // 
            this.lbCPoint.Font = new System.Drawing.Font("Nunito ExtraBold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCPoint.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbCPoint.Location = new System.Drawing.Point(338, 28);
            this.lbCPoint.Name = "lbCPoint";
            this.lbCPoint.Size = new System.Drawing.Size(153, 46);
            this.lbCPoint.TabIndex = 4;
            this.lbCPoint.Text = "0";
            this.lbCPoint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbTotal
            // 
            this.lbTotal.Font = new System.Drawing.Font("Nunito", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbTotal.Location = new System.Drawing.Point(121, 121);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(194, 41);
            this.lbTotal.TabIndex = 4;
            this.lbTotal.Text = "0";
            this.lbTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbFinalTotal
            // 
            this.lbFinalTotal.Font = new System.Drawing.Font("Nunito ExtraBold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFinalTotal.ForeColor = System.Drawing.Color.Crimson;
            this.lbFinalTotal.Location = new System.Drawing.Point(121, 207);
            this.lbFinalTotal.Name = "lbFinalTotal";
            this.lbFinalTotal.Size = new System.Drawing.Size(194, 46);
            this.lbFinalTotal.TabIndex = 4;
            this.lbFinalTotal.Text = "0";
            this.lbFinalTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnPayment.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnPayment.Location = new System.Drawing.Point(338, 195);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(158, 58);
            this.btnPayment.TabIndex = 13;
            this.btnPayment.Text = "THANH TOÁN";
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // txtCName
            // 
            this.txtCName.Enabled = false;
            this.txtCName.Location = new System.Drawing.Point(121, 44);
            this.txtCName.Name = "txtCName";
            this.txtCName.Size = new System.Drawing.Size(211, 35);
            this.txtCName.TabIndex = 11;
            // 
            // txtCPhone
            // 
            this.txtCPhone.Location = new System.Drawing.Point(121, 3);
            this.txtCPhone.Name = "txtCPhone";
            this.txtCPhone.Size = new System.Drawing.Size(170, 35);
            this.txtCPhone.TabIndex = 10;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancel.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCancel.Location = new System.Drawing.Point(338, 131);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(158, 58);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "HỦY BỎ";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 221);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 28);
            this.label9.TabIndex = 1;
            this.label9.Text = "Thành tiền:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 28);
            this.label8.TabIndex = 1;
            this.label8.Text = "Dùng điểm:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 28);
            this.label10.TabIndex = 1;
            this.label10.Text = "Họ tên:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(341, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(150, 28);
            this.label11.TabIndex = 1;
            this.label11.Text = "Điểm khả dụng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "SĐT KH:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 28);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tổng cộng:";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(121, 171);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(194, 35);
            this.txtDiscount.TabIndex = 12;
            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            // 
            // dgvBillInfos
            // 
            this.dgvBillInfos.AllowUserToAddRows = false;
            this.dgvBillInfos.AllowUserToDeleteRows = false;
            this.dgvBillInfos.AllowUserToResizeColumns = false;
            this.dgvBillInfos.AllowUserToResizeRows = false;
            this.dgvBillInfos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBillInfos.Location = new System.Drawing.Point(6, 48);
            this.dgvBillInfos.Name = "dgvBillInfos";
            this.dgvBillInfos.ReadOnly = true;
            this.dgvBillInfos.RowHeadersWidth = 51;
            this.dgvBillInfos.RowTemplate.Height = 24;
            this.dgvBillInfos.Size = new System.Drawing.Size(490, 246);
            this.dgvBillInfos.TabIndex = 0;
            this.dgvBillInfos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBillInfos_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nunito SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 38);
            this.label4.TabIndex = 45;
            this.label4.Text = "Chi tiết hóa đơn";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.dgvProducts);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(621, 429);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnReload);
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Location = new System.Drawing.Point(5, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(610, 77);
            this.panel3.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::SupermartketManager.Properties.Resources.search_icon;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.Location = new System.Drawing.Point(414, 34);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(36, 36);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(-2, 3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(303, 28);
            this.label15.TabIndex = 1;
            this.label15.Text = "Nhập tên hàng hóa để tìm kiếm:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(3, 34);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(405, 35);
            this.txtSearch.TabIndex = 1;
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AllowUserToResizeColumns = false;
            this.dgvProducts.AllowUserToResizeRows = false;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(5, 86);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowTemplate.Height = 24;
            this.dgvProducts.Size = new System.Drawing.Size(598, 331);
            this.dgvProducts.TabIndex = 0;
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellClick);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(181, 7);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(140, 35);
            this.txtId.TabIndex = 5;
            this.txtId.Visible = false;
            // 
            // txtEId
            // 
            this.txtEId.Location = new System.Drawing.Point(328, 7);
            this.txtEId.Name = "txtEId";
            this.txtEId.Size = new System.Drawing.Size(100, 35);
            this.txtEId.TabIndex = 47;
            this.txtEId.Visible = false;
            // 
            // lbAccountInfo
            // 
            this.lbAccountInfo.Font = new System.Drawing.Font("Nunito SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAccountInfo.ForeColor = System.Drawing.Color.Blue;
            this.lbAccountInfo.Location = new System.Drawing.Point(615, 7);
            this.lbAccountInfo.Name = "lbAccountInfo";
            this.lbAccountInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbAccountInfo.Size = new System.Drawing.Size(531, 32);
            this.lbAccountInfo.TabIndex = 48;
            this.lbAccountInfo.Text = "Thông tin tài khoản";
            this.lbAccountInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(460, 32);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(140, 40);
            this.btnReload.TabIndex = 8;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // FormPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1158, 685);
            this.Controls.Add(this.lbAccountInfo);
            this.Controls.Add(this.txtEId);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtId);
            this.Font = new System.Drawing.Font("Nunito SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPayment";
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillInfos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvBillInfos;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.TextBox txtCPhone;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDeleteBillInfo;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label lbCPoint;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbFinalTotal;
        private System.Windows.Forms.TextBox txtCName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnCustomerSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtEId;
        private System.Windows.Forms.Label lbAccountInfo;
        private System.Windows.Forms.Button btnReload;
    }
}