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
    public partial class ControlEmployee : UserControl
    {
        EmployeeDAO employeeDAO;
        string errorMessage;
        bool isAddMode;
        List<ComboboxItem> positionItems;

        public ControlEmployee()
        {
            InitializeComponent();
            employeeDAO = new EmployeeDAO();
            errorMessage = "";
            isAddMode = false;
            positionItems = new List<ComboboxItem>();
            LoadData();
        }

        private void EnableInput(bool enable)
        {
            txtId.Enabled = enable;
            txtName.Enabled = enable;
            txtPhone.Enabled = enable;
            cbPosition.Enabled = enable;
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
            txtPhone.ResetText();
        }

        private void LoadData()
        {
            try
            {
                // Load data for position combobox
                PositionDAO positionDAO = new PositionDAO();
                DataTable positionsTable = new DataTable();
                positionsTable = positionDAO.GetAll(ref errorMessage);
                positionItems.Clear();
                foreach (DataRow row in positionsTable.Rows)
                {
                    positionItems.Add(new ComboboxItem(row["name"].ToString(), row["position_id"].ToString()));
                }
                cbPosition.DisplayMember = "Text";
                cbPosition.ValueMember = "Value";
                cbPosition.DataSource = null;
                cbPosition.DataSource = positionItems;

                // Load data for datagridview
                DataTable employeesTable = new DataTable();
                employeesTable.Clear();

                // Retrieve data from db
                employeesTable = employeeDAO.GetAll(ref errorMessage);
                dgvEmployees.DataSource = employeesTable;

                // Styling categories datagridview
                dgvEmployees.RowHeadersVisible = false;
                dgvEmployees.Columns[0].Visible = false;
                int width = dgvEmployees.Width;
                dgvEmployees.Columns[1].Width = (int)(width * 0.4); // name
                dgvEmployees.Columns[1].HeaderText = "Họ tên";
                dgvEmployees.Columns[2].Width = (int)(width * 0.3); // phone
                dgvEmployees.Columns[2].HeaderText = "Số điện thoại";
                dgvEmployees.Columns[3].Visible = false; // position_id
                dgvEmployees.Columns[4].Width = (int)(width * 0.3); // position_name
                dgvEmployees.Columns[4].HeaderText = "Chức vụ";

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
            if (Int32.TryParse(txtId.Text, out int employee_id))
            {
                DialogResult userConfirmation = MessageBox.Show("Bạn có chắc chắn xóa Danh mục này?", "Thông báo", MessageBoxButtons.OKCancel);
                if (userConfirmation == DialogResult.OK)
                {
                    try
                    {
                        if (employeeDAO.Delete(employee_id, ref errorMessage) > 0)
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
                MessageBox.Show("Mã Danh mục không hợp lệ");
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
                string phone = txtPhone.Text.Trim();
                Int32.TryParse(cbPosition.SelectedValue.ToString(), out int position_id);

                // Validate data
                bool isValidData = !string.IsNullOrEmpty(name) &&
                                    !string.IsNullOrEmpty(phone) && 
                                    position_id > 0;

                if (isValidData)
                {
                    try
                    {
                        if (employeeDAO.Insert(new EmployeeDTO(0, name, phone, position_id), ref errorMessage) > 0)
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
                Int32.TryParse(txtId.Text.Trim(), out int employee_id);
                string name = txtName.Text.Trim();
                string phone = txtPhone.Text.Trim();
                Int32.TryParse(cbPosition.SelectedValue.ToString(), out int position_id);

                // Validate data
                bool isValidData = employee_id > 0 &&
                                    !string.IsNullOrEmpty(name) &&
                                    !string.IsNullOrEmpty(phone) &&
                                    position_id > 0;

                if (isValidData)
                {
                    try
                    {
                        if (employeeDAO.Update(new EmployeeDTO(employee_id, name, phone, position_id), ref errorMessage) > 0)
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

        private void dgvPositions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Prevent click on header
            if (e.RowIndex == -1) return;

            // Get selected row
            int curr = dgvEmployees.CurrentCell.RowIndex;

            // Get data from selected row
            string employee_id = dgvEmployees.Rows[curr].Cells[0].Value.ToString();
            string name = dgvEmployees.Rows[curr].Cells[1].Value.ToString();
            string phone = dgvEmployees.Rows[curr].Cells[2].Value.ToString();
            string position_id = dgvEmployees.Rows[curr].Cells[3].Value.ToString();

            // Fill data in inputs
            txtId.Text = employee_id;
            txtName.Text = name;
            txtPhone.Text = phone;
            cbPosition.SelectedItem = positionItems.Find(item => item.Value == position_id);
        }
    }
}
