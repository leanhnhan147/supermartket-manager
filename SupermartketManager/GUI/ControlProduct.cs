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
    public partial class ControlProduct : UserControl
    {
        ProductDAO productDAO;
        String errorMessage;
        bool isAddMode;
        List<ComboboxItem> categoriesItem;
        List<ComboboxItem> warehousesItem;

        public ControlProduct()
        {
            InitializeComponent();
            productDAO = new ProductDAO();
            errorMessage = "";
            isAddMode = false;
            categoriesItem = new List<ComboboxItem>();
            warehousesItem = new List<ComboboxItem>();
            LoadData();
        }

        private void EnableInput(bool enable)
        {
            txtName.Enabled = enable;
            txtPrice.Enabled = enable;
            txtQuantity.Enabled = enable;
            cbCategory.Enabled = enable;
            cbWarehouse.Enabled = enable;
            dtpMfg.Enabled = enable;
            dtpExp.Enabled = enable;
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
            txtPrice.ResetText();
            txtQuantity.ResetText();
            cbCategory.ResetText();
            cbWarehouse.ResetText();
            dtpMfg.ResetText();
            dtpExp.ResetText();
        }

        private void LoadData()
        {
            try
            {
                // Load data for combobox
                // Category combobox
                CategoryDAO categoryDAO = new CategoryDAO();
                DataTable categoriesTable = new DataTable();
                categoriesTable = categoryDAO.GetAll(ref errorMessage);
                categoriesItem.Clear();
                foreach (DataRow row in categoriesTable.Rows)
                {
                    categoriesItem.Add(new ComboboxItem(row["name"].ToString(), row["category_id"].ToString()));
                }
                cbCategory.DisplayMember = "Text";
                cbCategory.ValueMember = "Value";
                cbCategory.DataSource = null;
                cbCategory.DataSource = categoriesItem;

                // Warehouse combobox
                WarehouseDAO warehouseDAO = new WarehouseDAO();
                DataTable warehousesTable = new DataTable();
                warehousesTable = warehouseDAO.GetAll(ref errorMessage);
                warehousesItem.Clear();
                foreach (DataRow row in warehousesTable.Rows)
                {
                    warehousesItem.Add(new ComboboxItem(row["name"].ToString(), row["warehouse_id"].ToString()));
                }
                cbWarehouse.DisplayMember = "Text";
                cbWarehouse.ValueMember = "Value";
                cbWarehouse.DataSource = null;
                cbWarehouse.DataSource = warehousesItem;
                // End load data for combobox    --------

                // Load data for datagridview
                DataTable employeesTable = new DataTable();
                employeesTable = productDAO.GetAll(ref errorMessage);
                dgvProducts.DataSource = employeesTable;

                // Styling categories datagridview
                dgvProducts.RowHeadersVisible = false;
                dgvProducts.Columns[0].Visible = false;
                int width = dgvProducts.Width;
                dgvProducts.Columns[1].Width = (int)(width * 0.2); // name
                dgvProducts.Columns[1].HeaderText = "Tên Hàng";
                dgvProducts.Columns[2].Width = (int)(width * 0.1); // quantity
                dgvProducts.Columns[2].HeaderText = "SL";
                dgvProducts.Columns[3].Width = (int)(width * 0.1); // price
                dgvProducts.Columns[3].HeaderText = "Giá";
                dgvProducts.Columns[4].Width = (int)(width * 0.15); // mfg
                dgvProducts.Columns[4].HeaderText = "NSX";
                dgvProducts.Columns[5].Width = (int)(width * 0.15); // exp
                dgvProducts.Columns[5].HeaderText = "HSD";
                dgvProducts.Columns[6].Visible = false; // category id
                dgvProducts.Columns[7].Width = (int)(width * 0.15); // category
                dgvProducts.Columns[7].HeaderText = "Danh mục";
                dgvProducts.Columns[8].Visible = false; // warehouse id 
                dgvProducts.Columns[9].Width = (int)(width * 0.15); // warehouse
                dgvProducts.Columns[9].HeaderText = "Kho";

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
                DialogResult userConfirmation = MessageBox.Show("Bạn có chắc chắn xóa Mặt hàng này?", "Thông báo", MessageBoxButtons.OKCancel);
                if (userConfirmation == DialogResult.OK)
                {
                    try
                    {
                        if (productDAO.Delete(employee_id, ref errorMessage) > 0)
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
                MessageBox.Show("Mã Hàng không hợp lệ");
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
                Int32.TryParse(txtPrice.Text.Trim().ToString(), out int price);
                Int32.TryParse(txtQuantity.Text.Trim().ToString(), out int quantity);
                Int32.TryParse(cbCategory.SelectedValue.ToString(), out int category_id);
                Int32.TryParse(cbWarehouse.SelectedValue.ToString(), out int warehouse_id);
                string mfg_date = dtpMfg.Text.Trim();
                string exp_date = dtpExp.Text.Trim();

                // Validate data
                bool isValidData = !string.IsNullOrEmpty(name) &&
                                    price != 0 &&
                                    quantity != 0 &&
                                    category_id != 0 &&
                                    warehouse_id != 0 &&
                                    !string.IsNullOrEmpty(mfg_date) &&
                                    !string.IsNullOrEmpty(exp_date);

                if (isValidData)
                {
                    try
                    {
                        if (productDAO.Insert(new ProductDTO(0, name, quantity, price, mfg_date, exp_date, category_id, warehouse_id), ref errorMessage) > 0)
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
                Int32.TryParse(txtId.Text.Trim(), out int product_id);
                string name = txtName.Text.Trim();
                Int32.TryParse(txtPrice.Text.Trim().ToString(), out int price);
                Int32.TryParse(txtQuantity.Text.Trim().ToString(), out int quantity);
                Int32.TryParse(cbCategory.SelectedValue.ToString(), out int category_id);
                Int32.TryParse(cbWarehouse.SelectedValue.ToString(), out int warehouse_id);
                string mfg_date = dtpMfg.Text.Trim();
                string exp_date = dtpExp.Text.Trim();

                // Validate data
                bool isValidData = product_id != 0 &&
                                    !string.IsNullOrEmpty(name) &&
                                    price != 0 &&
                                    quantity != 0 &&
                                    category_id != 0 &&
                                    warehouse_id != 0 &&
                                    !string.IsNullOrEmpty(mfg_date) &&
                                    !string.IsNullOrEmpty(exp_date);

                if (isValidData)
                {
                    try
                    {
                        if (productDAO.Update(new ProductDTO(product_id, name, quantity, price, mfg_date, exp_date, category_id, warehouse_id), ref errorMessage) > 0)
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

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Prevent click on header
            if (e.RowIndex == -1) return;

            // Get selected row
            int curr = dgvProducts.CurrentCell.RowIndex;

            // Get data from selected row
            string product_id = dgvProducts.Rows[curr].Cells[0].Value.ToString();
            string name = dgvProducts.Rows[curr].Cells[1].Value.ToString();
            string quantity = dgvProducts.Rows[curr].Cells[2].Value.ToString();
            string price = dgvProducts.Rows[curr].Cells[3].Value.ToString();
            string mfg_date = dgvProducts.Rows[curr].Cells[4].Value.ToString();
            string exp_date = dgvProducts.Rows[curr].Cells[5].Value.ToString();
            string category_id = dgvProducts.Rows[curr].Cells[6].Value.ToString();
            string warehouse_id = dgvProducts.Rows[curr].Cells[8].Value.ToString();

            // Fill data in inputs
            txtId.Text = product_id;
            txtName.Text = name;
            txtQuantity.Text = quantity;
            txtPrice.Text = price;
            dtpMfg.Text = mfg_date;
            dtpExp.Text = exp_date;
            cbCategory.SelectedItem = categoriesItem.Find(item => item.Value == category_id);
            cbWarehouse.SelectedItem = warehousesItem.Find(item => item.Value == warehouse_id);
        }
    }
}
