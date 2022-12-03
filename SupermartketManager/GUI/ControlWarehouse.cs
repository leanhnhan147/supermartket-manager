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
    public partial class ControlWarehouse : UserControl
    {
        WarehouseDAO warehouseDAO;
        string errorMessage;
        bool isAddMode;

        public ControlWarehouse()
        {
            InitializeComponent();
            warehouseDAO = new WarehouseDAO();
            errorMessage = "";
            isAddMode = false;
            LoadData();
        }

        private void EnableInput(bool enable)
        {
            txtName.Enabled = enable;
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
        }

        private void LoadData()
        {
            try
            {
                // Retrieve data from db
                DataTable warehousesTable = new DataTable();
                warehousesTable = warehouseDAO.GetAll(ref errorMessage);
                dgvWarehouses.DataSource = warehousesTable;

                // Styling categories datagridview
                dgvWarehouses.RowHeadersVisible = false;
                int width = dgvWarehouses.Width;
                dgvWarehouses.Columns[0].Visible = false; // warehouse_id
                dgvWarehouses.Columns[1].Width = (int)(width * 0.4); // name
                dgvWarehouses.Columns[1].HeaderText = "Tên kho";
                dgvWarehouses.Columns[2].Width = (int)(width * 0.6); // address
                dgvWarehouses.Columns[2].HeaderText = "Địa chỉ";

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
            if (Int32.TryParse(txtId.Text, out int warehouse_id))
            {
                DialogResult userConfirmation = MessageBox.Show("Bạn có chắc chắn xóa kho này?", "Thông báo", MessageBoxButtons.OKCancel);
                if (userConfirmation == DialogResult.OK)
                {
                    try
                    {
                        if (warehouseDAO.Delete(warehouse_id, ref errorMessage) > 0)
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
                MessageBox.Show("Mã kho không hợp lệ");
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

                // Validate data
                bool isValidData = !string.IsNullOrEmpty(name) &&
                                    !string.IsNullOrEmpty(address);

                if (isValidData)
                {
                    try
                    {
                        if (warehouseDAO.Insert(new WarehouseDTO(0, name, address), ref errorMessage) > 0)
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
                Int32.TryParse(txtId.Text.Trim(), out int warehouse_id);
                string name = txtName.Text.Trim();
                string address = txtAddress.Text.Trim();

                // Validate data
                bool isValidData = warehouse_id != 0 && 
                                    !string.IsNullOrEmpty(name) &&
                                    !string.IsNullOrEmpty(address);

                if (isValidData)
                {
                    try
                    {
                        if (warehouseDAO.Update(new WarehouseDTO(warehouse_id, name, address), ref errorMessage) > 0)
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

        private void dgvWarehouses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Prevent click on header
            if (e.RowIndex == -1) return; 

            // Get selected row
            int curr = dgvWarehouses.CurrentCell.RowIndex;

            // Get data from selected row
            string warehouse_id = dgvWarehouses.Rows[curr].Cells[0].Value.ToString();
            string name = dgvWarehouses.Rows[curr].Cells[1].Value.ToString();
            string address = dgvWarehouses.Rows[curr].Cells[2].Value.ToString();

            // Fill data in inputs
            txtId.Text = warehouse_id;
            txtName.Text = name;
            txtAddress.Text = address;
        }
    }
}
