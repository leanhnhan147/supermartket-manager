using SupermartketManager.DAO;
using SupermartketManager.DTO;
using SupermartketManager.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SupermartketManager.GUI
{
    public partial class ControlAccount : UserControl
    {
        AccountDAO accountDAO;
        string errorMessage;
        bool isAddMode;
        List<ComboboxItem> employeeItems;

        public ControlAccount()
        {
            InitializeComponent();
            accountDAO = new AccountDAO();
            errorMessage = "";
            isAddMode = false;
            employeeItems = new List<ComboboxItem>();
            LoadData();
        }

        private void EnableInput(bool enable)
        {
            txtUsername.Enabled = enable;
            txtPassword.Enabled = enable;
            cbEmployee.Enabled = enable;
        }

        private void ResetButton()
        {
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnCancel.Enabled = false;
            btnSave.Enabled = false;
        }

        private void ResetInput()
        {
            txtUsername.ResetText();
            txtPassword.ResetText();
        }

        private void LoadData()
        {
            try
            {
                // Load data in employee combobox
                EmployeeDAO employeeDAO = new EmployeeDAO();
                DataTable employeesTable = new DataTable();
                employeesTable = employeeDAO.GetAll(ref errorMessage);
                employeeItems.Clear();
                foreach (DataRow row in employeesTable.Rows)
                {
                    employeeItems.Add(new ComboboxItem(row["name"].ToString(), row["employee_id"].ToString()));
                }
                cbEmployee.DisplayMember = "Text";
                cbEmployee.ValueMember = "Value";
                cbEmployee.DataSource = null;
                cbEmployee.DataSource = employeeItems;

                // Load data in datagridview
                DataTable accountsTable = new DataTable();

                // Retrieve data from db
                accountsTable = accountDAO.GetAll(ref errorMessage);
                dgvAccount.DataSource = accountsTable;

                // Styling categories datagridview
                dgvAccount.RowHeadersVisible = false;
                int width = dgvAccount.Width;
                dgvAccount.Columns[0].Width = (int)(width * 0.5); // username
                dgvAccount.Columns[0].HeaderText = "Tên tài khoản";
                dgvAccount.Columns[1].Visible = false; // password
                dgvAccount.Columns[2].Visible = false; // employee id
                dgvAccount.Columns[3].Width = (int)(width * 0.5); // employee name
                dgvAccount.Columns[3].HeaderText = "Tên nhân viên";

                ResetButton();

                ResetInput();
                EnableInput(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(!string.IsNullOrEmpty(errorMessage) ? errorMessage : ex.Message, "Thông báo!");
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            isAddMode = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnCancel.Enabled = true;
            btnSave.Enabled = true;

            ResetInput();
            EnableInput(true);
            txtUsername.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            isAddMode = false;
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnCancel.Enabled = true;
            btnSave.Enabled = true;

            txtPassword.Enabled = true;
            txtPassword.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            if (!string.IsNullOrEmpty(username))
            {
                DialogResult userConfirmation = MessageBox.Show("Bạn có chắc chắn xóa tài khoản này?", "Thông báo", MessageBoxButtons.OKCancel);
                if (userConfirmation == DialogResult.OK)
                {
                    try
                    {
                        if (accountDAO.Delete(username, ref errorMessage) > 0)
                        {
                            MessageBox.Show("Xóa thành công");
                        }
                        else
                        {
                            MessageBox.Show("Xóa không thành công");
                        }
                        LoadData();
                    }
                    catch
                    {
                        MessageBox.Show(errorMessage);
                    }
                }
            }
            else
            {
                MessageBox.Show("Tên tài khoản không hợp lệ");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isAddMode)
            {
                // Get data from inputs
                string username = txtUsername.Text.Trim();
                string password = txtPassword.Text.Trim();
                Int32.TryParse(cbEmployee.SelectedValue.ToString(), out int employee_id);

                // Validate data
                bool isValidData = !string.IsNullOrEmpty(username) &&
                                    !string.IsNullOrEmpty(password) &&
                                    employee_id != 0;

                if (isValidData)
                {
                    try
                    {
                        if (accountDAO.Insert(new AccountDTO(username, password, employee_id), ref errorMessage) > 0)
                        {
                            MessageBox.Show("Thêm thành công");
                        }
                        else
                        {
                            MessageBox.Show("Thêm không thành công");
                        }
                        LoadData();
                    }
                    catch
                    {
                        MessageBox.Show(errorMessage);
                    }
                }
                else
                {
                    MessageBox.Show("Thông tin nhập vào không hợp lệ, vui lòng kiểm tra lại!");
                }

            }
            else // Edit mode
            {
                // Get data from inputs
                string username = txtUsername.Text.Trim();
                string password = txtPassword.Text.Trim();
                Int32.TryParse(cbEmployee.SelectedValue.ToString(), out int employee_id);

                // Validate data
                bool isValidData = !string.IsNullOrEmpty(username) &&
                                    !string.IsNullOrEmpty(password) &&
                                    employee_id != 0;

                if (isValidData)
                {
                    try
                    {
                        if (accountDAO.Update(new AccountDTO(username, password, employee_id), ref errorMessage) > 0)
                        {
                            MessageBox.Show("Cập nhật thành công");
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật không thành công");
                        }
                    }
                    catch
                    {
                        MessageBox.Show(errorMessage);
                    }
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Thông tin nhập vào không hợp lệ, vui lòng kiểm tra lại!");
                }
            }
        }

        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Prevent click on header
            if (e.RowIndex == -1) return;

            // Get selected row
            int curr = dgvAccount.CurrentCell.RowIndex;

            // Get data from selected row
            string username = dgvAccount.Rows[curr].Cells[0].Value.ToString();
            string password = dgvAccount.Rows[curr].Cells[1].Value.ToString();
            string employee_id = dgvAccount.Rows[curr].Cells[2].Value.ToString();

            // Fill data in inputs
            txtUsername.Text = username;
            txtPassword.Text = password;
            cbEmployee.SelectedItem = employeeItems.Find(item => item.Value == employee_id);
        }
    }
}
