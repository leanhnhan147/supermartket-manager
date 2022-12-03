using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermartketManager.GUI
{
    public partial class FormWarehouseKeeper : Form
    {
        string employeeId;
        string employeeName;
        string positionName;
        public FormWarehouseKeeper(string employee_id, string employee_name, string position_name)
        {
            InitializeComponent();
            employeeId = employee_id;
            employeeName = employee_name;
            positionName = position_name;
            lbAccountInfo.Text = $"Nhân viên: {employeeName} [{positionName}]";
        }

        private void FormWarehouseKeeper_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát ứng dụng?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void mniPayment_Click(object sender, EventArgs e)
        {
            controlImport1.BringToFront();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlProduct1.BringToFront();
        }

        private void FormWarehouseKeeper_FormClosing(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát ứng dụng?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void côngTyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlCompany1.BringToFront();
        }

        private void controlCompany2_Load(object sender, EventArgs e)
        {

        }

        private void khoHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlWarehouse1.BringToFront();
        }
    }
}
