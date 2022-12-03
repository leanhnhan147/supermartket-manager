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
    public partial class FormMain : Form
    {
        string employeeId;
        string employeeName;
        string positionName;
        public FormMain(string employee_id, string employee_name, string position_name)
        {
            InitializeComponent();
            employeeId = employee_id;
            employeeName = employee_name;
            positionName = position_name;
            groupInfo1.BringToFront();
            lbAccountInfo.Text = $"Nhân viên: {employeeName} [{positionName}]";
        }

        private void mniImport_Click(object sender, EventArgs e)
        {
            controlImport1.BringToFront();
        }

        private void mniPayment_Click(object sender, EventArgs e)
        {
            FormPayment formPayment = new FormPayment(employeeId, employeeName, positionName);
            formPayment.ShowDialog();

        }

        private void danhMụcHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucCategory1.BringToFront();
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

        private void chứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucPosition1.BringToFront();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlEmployee1.BringToFront();
        }

        private void mniLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát ứng dụng?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void FormMain_FormClosing_2(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát ứng dụng?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void doanhThuTheoThángToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void doanhThuTheoNămToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlRevenue1.BringToFront();
        }

        private void côngTyCungCấpHàngNhiềuNhấtTrongThángToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlTopCompany1.BringToFront();
        }

        private void mặtHàngĐãBánTrongThángToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlProductSoldByMonth1.BringToFront();
        }

        private void controlProductSoldByMonth1_Load(object sender, EventArgs e)
        {

        }

        private void quảnLíTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlAccount1.BringToFront();
        }

        private void controlAccount2_Load(object sender, EventArgs e)
        {

        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlViewBill1.BringToFront();
        }

        private void controlViewBill1_Load(object sender, EventArgs e)
        {

        }

        private void controlRevenue1_Load(object sender, EventArgs e)
        {

        }

        private void controlCompany1_Load(object sender, EventArgs e)
        {

        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlCustomer1.BringToFront();
        }
    }
}
