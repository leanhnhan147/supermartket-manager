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
    public partial class ControlCustomer : UserControl
    {
        CustomerDAO customerDAO;
        string errorMessage;
        bool isAddMode;
        List<ComboboxItem> genderItems;
        public ControlCustomer()
        {
            InitializeComponent();
            customerDAO = new CustomerDAO();
            errorMessage = "";
            isAddMode = false;
            genderItems = new List<ComboboxItem>();
            LoadData();
        }

        private void EnableInput(bool enable)
        {
            txtName.Enabled = enable;
            txtPhone.Enabled = enable;
            dtpBirthday.Enabled = enable;
            cbGender.Enabled = enable;
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
            txtName.ResetText();
            txtPhone.ResetText();
            dtpBirthday.ResetText();
            txtPhone.ResetText();
            txtPoint.Text = "0";
        }

        private void LoadData()
        {
            try
            {
                //Load data in combobox
                genderItems.Clear();
                genderItems.Add(new ComboboxItem("Nam", "Nam"));
                genderItems.Add(new ComboboxItem("Nữ", "Nữ"));
                cbGender.DisplayMember = "Text";
                cbGender.ValueMember = "Value";
                cbGender.DataSource = null;
                cbGender.DataSource = genderItems;
                // Load data in customertable
                DataTable customersTable = customerDAO.GetAll(ref errorMessage);

                dgvCustomers.DataSource = customersTable;

                // Styling categories datagridview
                dgvCustomers.RowHeadersVisible = false;
                int width = dgvCustomers.Width;
                dgvCustomers.Columns[0].Width = (int)(width * 0.2); // username
                dgvCustomers.Columns[0].HeaderText = "Số điện thoại";
                dgvCustomers.Columns[1].Width = (int)(width * 0.3); // username
                dgvCustomers.Columns[1].HeaderText = "Tên khách hàng";
                dgvCustomers.Columns[2].Width = (int)(width * 0.2); // username
                dgvCustomers.Columns[2].HeaderText = "Ngày sinh";
                dgvCustomers.Columns[3].Width = (int)(width * 0.1); // username
                dgvCustomers.Columns[3].HeaderText = "Giới tính";
                dgvCustomers.Columns[4].Width = (int)(width * 0.2); // username
                dgvCustomers.Columns[4].HeaderText = "Điểm tích lũy";

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

            txtPhone.Enabled = true;
            txtPhone.Focus();

            txtName.Enabled = true;
            dtpBirthday.Enabled = true;
            cbGender.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string customer_phone = txtPhone.Text;
            if (!string.IsNullOrEmpty(customer_phone))
            {
                DialogResult userConfirmation = MessageBox.Show("Bạn có chắc chắn xóa khách hàng này?", "Thông báo", MessageBoxButtons.OKCancel);
                if (userConfirmation == DialogResult.OK)
                {
                    try
                    {
                        if (customerDAO.Delete(customer_phone, ref errorMessage) > 0)
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
                MessageBox.Show("Số điện thoại không hợp lệ");
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
                //Get data from inputs

                string customer_phone = txtPhone.Text.Trim();
                string name = txtName.Text.Trim();
                string birthday = dtpBirthday.Text.Trim();
                string gender = cbGender.Text.Trim();

                // Validate data
                bool isValidData = !string.IsNullOrEmpty(customer_phone) &&
                                    !string.IsNullOrEmpty(name) &&
                                    !string.IsNullOrEmpty(birthday) &&
                                    !string.IsNullOrEmpty(gender);

                if (isValidData)
                {
                    try
                    {
                        if (customerDAO.Insert(new CustomerDTO(customer_phone, name, birthday, gender, 0), ref errorMessage) > 0)
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
                string customer_phone = txtPhone.Text.Trim();
                string name = txtName.Text.Trim();
                string birthday = dtpBirthday.Text.Trim();
                string gender = cbGender.Text.Trim();
                int point = -1;
                Int32.TryParse(txtPoint.Text, out point);

                // Validate data
                // Validate data
                bool isValidData = !string.IsNullOrEmpty(customer_phone) &&
                                    !string.IsNullOrEmpty(name) &&
                                    !string.IsNullOrEmpty(birthday) &&
                                    !string.IsNullOrEmpty(gender) &&
                                    point >= 0;

                if (isValidData)
                {
                    try
                    {
                        if (customerDAO.Update(new CustomerDTO(customer_phone, name, birthday, gender, point), ref errorMessage) > 0)
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
            int curr = dgvCustomers.CurrentCell.RowIndex;

            // Get data from selected row
            string customer_phone = dgvCustomers.Rows[curr].Cells[0].Value.ToString();
            string name = dgvCustomers.Rows[curr].Cells[1].Value.ToString();
            string birthday = dgvCustomers.Rows[curr].Cells[2].Value.ToString();
            string gender = dgvCustomers.Rows[curr].Cells[3].Value.ToString();
            string point = dgvCustomers.Rows[curr].Cells[4].Value.ToString();

            // Fill data in inputs
            txtPhone.Text = customer_phone;
            txtName.Text = name;
            txtPoint.Text = point;
            dtpBirthday.Text = birthday;
            cbGender.SelectedItem = genderItems.Find(item => item.Value == gender);
        }
    }
}
