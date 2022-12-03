using SupermartketManager.DAO;
using SupermartketManager.DTO;
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
    public partial class ControlCompany : UserControl
    {
        CompanyDAO companyDAO;
        string errorMessage;
        bool isAddMode;

        public ControlCompany()
        {
            InitializeComponent();
            companyDAO = new CompanyDAO();
            errorMessage = "";
            isAddMode = false;
            LoadData();
        }

        private void EnableInput(bool enable)
        {
            txtName.Enabled = enable;
            txtPhone.Enabled = enable;
            txtAddress.Enabled = enable;
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
            txtId.ResetText();
            txtName.ResetText();
            txtAddress.ResetText();
            txtPhone.ResetText();
        }

        private void LoadData()
        {
            try
            {
                // Retrieve data from db
                DataTable companiesTable = new DataTable();
                companiesTable = companyDAO.GetAll(ref errorMessage);
                dgvCompanies.DataSource = companiesTable;

                // Styling companies datagridview
                dgvCompanies.RowHeadersVisible = false;
                dgvCompanies.Columns[0].Visible = false;
                dgvCompanies.Columns[1].Width = dgvCompanies.Width / 3; // name
                dgvCompanies.Columns[1].HeaderText = "Tên công ty";
                dgvCompanies.Columns[2].Width = dgvCompanies.Width / 3; // address
                dgvCompanies.Columns[2].HeaderText = "Địa chỉ";
                dgvCompanies.Columns[3].Width = dgvCompanies.Width / 3; // phone
                dgvCompanies.Columns[3].HeaderText = "Số điện thoại";

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
            txtName.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            isAddMode = false;
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnCancel.Enabled = true;
            btnSave.Enabled = true;

            EnableInput(true);
            txtName.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(txtId.Text, out int id))
            {
                DialogResult userConfirmation = MessageBox.Show("Bạn có chắc chắn xóa công ty này?", "Thông báo", MessageBoxButtons.OKCancel);
                if (userConfirmation == DialogResult.OK)
                {
                    try
                    {
                        if (companyDAO.Delete(id, ref errorMessage) > 0)
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
                MessageBox.Show("Mã công ty không hợp lệ");
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
                string name = txtName.Text.Trim();
                string address = txtAddress.Text.Trim();
                string phone = txtPhone.Text.Trim();

                // Validate data
                bool isValidData = !string.IsNullOrEmpty(name);

                if (isValidData)
                {
                    try
                    {
                        if (companyDAO.Insert(new CompanyDTO(0, name, address, phone), ref errorMessage) > 0)
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
                Int32.TryParse(txtId.Text.Trim(), out int company_id);
                string name = txtName.Text.Trim();
                string address = txtAddress.Text.Trim();
                string phone = txtPhone.Text.Trim();

                // Validate data
                bool isValidData = company_id != 0 && 
                                    !string.IsNullOrEmpty(name) &&
                                    !string.IsNullOrEmpty(address) &&
                                    !string.IsNullOrEmpty(phone);

                if (isValidData)
                {
                    try
                    {
                        if (companyDAO.Update(new CompanyDTO(company_id, name, address, phone), ref errorMessage) > 0)
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

        private void dgvCompanies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Prevent click on header
            if (e.RowIndex == -1) return;

            // Get selected row
            int curr = dgvCompanies.CurrentCell.RowIndex;

            // Get data from selected row
            string company_id = dgvCompanies.Rows[curr].Cells[0].Value.ToString();
            string name = dgvCompanies.Rows[curr].Cells[1].Value.ToString();
            string address = dgvCompanies.Rows[curr].Cells[2].Value.ToString();
            string phone = dgvCompanies.Rows[curr].Cells[3].Value.ToString();


            // Fill data in inputs
            txtId.Text = company_id;
            txtName.Text = name;
            txtAddress.Text = address;
            txtPhone.Text = phone;
        }
    }
}
