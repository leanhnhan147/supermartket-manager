using SupermartketManager.DAO;
using SupermartketManager.DTO;
using SupermartketManager.Helpers;
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
    public partial class ControlCustomerMaxSpending : UserControl
    {
        CustomerDAO customerDAO;
        String errorMessage;
        public ControlCustomerMaxSpending()
        {
            InitializeComponent();
            customerDAO = new CustomerDAO();
            errorMessage = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            txtPhone.ResetText();
            txtName.ResetText();
            txtTotalSpending.ResetText();
            txtPoint.ResetText();
            int month = -1;
            int year = -1;
            if ((Int32.TryParse(txtMonthInput.Text, out month) | Int32.TryParse(txtYearInput.Text, out year)) == false)
            {
                MessageBox.Show("Nhập khống đúng tháng hoặc năm", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (month >= 1 && month <= 12 && year >= 0)
            {
                FindCustomerMaxSpending(year, month);
            }
        }
        private void FindCustomerMaxSpending(int year, int month)
        {
            try
            {
                // Load data 
                DataTable customerTable = new DataTable();
                customerTable = customerDAO.MaxSpending(year, month, ref errorMessage);

                dgvCustomer.DataSource = customerTable;

                // Styling categories datagridview
                dgvCustomer.RowHeadersVisible = false;

                int width = dgvCustomer.Width;
                dgvCustomer.Columns[0].Width = (int)(width * 0.5); // phone number
                dgvCustomer.Columns[0].HeaderText = "Số điện thoại";
                dgvCustomer.Columns[1].Width = (int)(width *0.5); // total spending
                dgvCustomer.Columns[1].HeaderText = "Tổng tiền tiêu trong tháng";

            }
            catch (Exception ex)
            {
                MessageBox.Show(!string.IsNullOrEmpty(errorMessage) ? errorMessage : ex.Message, "Thông báo!");
            }

        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Prevent click on header
            if (e.RowIndex == -1) return;

            try
            {
                // Get selected row
                int curr = dgvCustomer.CurrentCell.RowIndex;

                // Get data from selected row
                string customner_phone = dgvCustomer.Rows[curr].Cells[0].Value.ToString();

                // Fill data in inputs
                DataTable customerTable = new DataTable();
                customerTable = customerDAO.FindByPhone(customner_phone, ref errorMessage);
                txtPhone.Text = customerTable.Rows[0]["customer_phone"].ToString();
                txtName.Text = customerTable.Rows[0]["name"].ToString(); 
                txtTotalSpending.Text = dgvCustomer.Rows[curr].Cells[1].Value.ToString();
                txtPoint.Text = customerTable.Rows[0]["point"].ToString();

            }
            catch(Exception ex)
            {
                MessageBox.Show(!string.IsNullOrEmpty(errorMessage) ? errorMessage : ex.Message, "Thông báo!");
            }
        }
    }
}
