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
    public partial class FormCashier : Form
    {
        string employeeId;
        string employeeName;
        string positionName;

        public FormCashier(string employee_id, string employee_name, string position_name)
        {
            InitializeComponent();
            employeeId = employee_id;
            employeeName = employee_name;
            positionName = position_name;
            lbAccountInfo.Text = $"Nhân viên: {employeeName} [{positionName}]";
        }

        private void mniPayment_Click(object sender, EventArgs e)
        {
            FormPayment formPayment = new FormPayment(employeeId, employeeName, positionName);
            formPayment.ShowDialog();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlCustomer1.BringToFront();
        }

        private void FormCashier_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát ứng dụng?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void mniLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát ứng dụng?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
