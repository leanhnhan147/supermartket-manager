namespace SupermartketManager.GUI
{
    partial class ControlTopCompany
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvCompanies = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompanies)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nunito ExtraBold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(550, 46);
            this.label1.TabIndex = 49;
            this.label1.Text = "Công ty cung cấp hàng nhiều nhất";
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(122, 107);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(118, 35);
            this.txtMonth.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 28);
            this.label2.TabIndex = 51;
            this.label2.Text = "Tháng:";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(381, 107);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(118, 35);
            this.txtYear.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(315, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 28);
            this.label3.TabIndex = 51;
            this.label3.Text = "Năm:";
            // 
            // dgvCompanies
            // 
            this.dgvCompanies.AllowUserToAddRows = false;
            this.dgvCompanies.AllowUserToDeleteRows = false;
            this.dgvCompanies.AllowUserToResizeRows = false;
            this.dgvCompanies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompanies.Location = new System.Drawing.Point(44, 198);
            this.dgvCompanies.Name = "dgvCompanies";
            this.dgvCompanies.RowHeadersWidth = 51;
            this.dgvCompanies.RowTemplate.Height = 24;
            this.dgvCompanies.Size = new System.Drawing.Size(1034, 328);
            this.dgvCompanies.TabIndex = 52;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(614, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 35);
            this.button1.TabIndex = 53;
            this.button1.Text = "Xác nhận";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ControlTopCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvCompanies);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nunito SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ControlTopCompany";
            this.Size = new System.Drawing.Size(1120, 558);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompanies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvCompanies;
        private System.Windows.Forms.Button button1;
    }
}
