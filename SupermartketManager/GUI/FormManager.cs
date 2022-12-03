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
    public partial class FormManager : Form
    {
        string employeeId;
        string employeeName;
        string positionName;
        public FormManager(string employee_id, string employee_name, string position_name)
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

        private void mniImport_Click(object sender, EventArgs e)
        {
            controlImport1.BringToFront();
        }

        private void mniLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát ứng dụng này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void danhMụcHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlCategory1.BringToFront();
        }

        private void hàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlProduct1.BringToFront();
        }

        private void khoHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlWarehouse1.BringToFront();
        }

        private void côngTyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlCompany1.BringToFront();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlCustomer1.BringToFront();
        }

        private void controlCustomer1_Load(object sender, EventArgs e)
        {

        }
    }
}
