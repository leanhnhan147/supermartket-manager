namespace SupermartketManager.GUI
{
    partial class ControlRevenue
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGetBill = new System.Windows.Forms.Button();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnStatistic = new System.Windows.Forms.Button();
            this.dgvStatistic = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.btnStatisticY = new System.Windows.Forms.Button();
            this.btnStatisticM = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGetBill);
            this.panel1.Controls.Add(this.txtDate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtYear);
            this.panel1.Controls.Add(this.txtMonth);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnStatistic);
            this.panel1.Location = new System.Drawing.Point(52, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1017, 64);
            this.panel1.TabIndex = 11;
            // 
            // btnGetBill
            // 
            this.btnGetBill.Location = new System.Drawing.Point(782, 12);
            this.btnGetBill.Name = "btnGetBill";
            this.btnGetBill.Size = new System.Drawing.Size(187, 47);
            this.btnGetBill.TabIndex = 6;
            this.btnGetBill.Text = "Hiển thị tất cả đơn";
            this.btnGetBill.UseVisualStyleBackColor = true;
            this.btnGetBill.Click += new System.EventHandler(this.btnGetBill_Click);
            // 
            // txtDate
            // 
            this.txtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.Location = new System.Drawing.Point(142, 19);
            this.txtDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(60, 30);
            this.txtDate.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nhập ngày:";
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.Location = new System.Drawing.Point(462, 19);
            this.txtYear.Margin = new System.Windows.Forms.Padding(2);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(88, 30);
            this.txtYear.TabIndex = 1;
            // 
            // txtMonth
            // 
            this.txtMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonth.Location = new System.Drawing.Point(300, 21);
            this.txtMonth.Margin = new System.Windows.Forms.Padding(2);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(60, 30);
            this.txtMonth.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(379, 24);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "năm:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(223, 24);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "tháng:";
            // 
            // btnStatistic
            // 
            this.btnStatistic.Location = new System.Drawing.Point(589, 12);
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.Size = new System.Drawing.Size(187, 47);
            this.btnStatistic.TabIndex = 3;
            this.btnStatistic.Text = "Thống kê doanh thu";
            this.btnStatistic.UseVisualStyleBackColor = true;
            this.btnStatistic.Click += new System.EventHandler(this.btnStatistic_Click);
            // 
            // dgvStatistic
            // 
            this.dgvStatistic.AllowUserToAddRows = false;
            this.dgvStatistic.AllowUserToDeleteRows = false;
            this.dgvStatistic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatistic.Location = new System.Drawing.Point(63, 135);
            this.dgvStatistic.Name = "dgvStatistic";
            this.dgvStatistic.RowHeadersWidth = 51;
            this.dgvStatistic.RowTemplate.Height = 24;
            this.dgvStatistic.Size = new System.Drawing.Size(1006, 352);
            this.dgvStatistic.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(673, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "BẢNG THỐNG KÊ DOANH THU SIÊU THỊ THEO THÁNG";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(74, 35);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(0, 28);
            this.lb1.TabIndex = 8;
            // 
            // btnStatisticY
            // 
            this.btnStatisticY.Location = new System.Drawing.Point(612, 493);
            this.btnStatisticY.Name = "btnStatisticY";
            this.btnStatisticY.Size = new System.Drawing.Size(301, 47);
            this.btnStatisticY.TabIndex = 13;
            this.btnStatisticY.Text = "Thống kê doanh thu theo năm\r\n";
            this.btnStatisticY.UseVisualStyleBackColor = true;
            this.btnStatisticY.Click += new System.EventHandler(this.btnStatisticY_Click);
            // 
            // btnStatisticM
            // 
            this.btnStatisticM.Location = new System.Drawing.Point(181, 493);
            this.btnStatisticM.Name = "btnStatisticM";
            this.btnStatisticM.Size = new System.Drawing.Size(301, 47);
            this.btnStatisticM.TabIndex = 12;
            this.btnStatisticM.Text = "Thống kê doanh thu theo tháng";
            this.btnStatisticM.UseVisualStyleBackColor = true;
            this.btnStatisticM.Click += new System.EventHandler(this.btnStatisticM_Click);
            // 
            // ControlRevenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvStatistic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.btnStatisticY);
            this.Controls.Add(this.btnStatisticM);
            this.Font = new System.Drawing.Font("Nunito SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ControlRevenue";
            this.Size = new System.Drawing.Size(1120, 558);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGetBill;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnStatistic;
        private System.Windows.Forms.DataGridView dgvStatistic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Button btnStatisticY;
        private System.Windows.Forms.Button btnStatisticM;
    }
}
