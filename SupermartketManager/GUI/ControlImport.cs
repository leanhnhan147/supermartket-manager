using SupermartketManager.DAO;
using SupermartketManager.DTO;
using SupermartketManager.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace SupermartketManager.GUI
{
    public partial class ControlImport : UserControl
    {
        ImportDAO importDAO;
        string errorMessage;
        bool isAddMode;
        List<ComboboxItem> productItems;
        List<ComboboxItem> companyItems;

        public ControlImport()
        {
            InitializeComponent();
            importDAO = new ImportDAO();
            errorMessage = "";
            isAddMode = false;
            productItems = new List<ComboboxItem>();
            companyItems = new List<ComboboxItem>();
            LoadData();
        }

        private void EnableInput(bool enable)
        {
            cbProduct.Enabled = enable;
            cbCompany.Enabled = enable;
            txtQuantity.Enabled = enable;
            txtPrice.Enabled = enable;
            dtpImport.Enabled = enable;
        }

        private void ResetButton()
        {
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
            btnCancel.Enabled = false;
            btnSave.Enabled = false;
        }

        private void ResetInput()
        {
            cbProduct.ResetText();
            cbCompany.ResetText();
            txtQuantity.ResetText();
            txtPrice.ResetText();
            dtpImport.ResetText();
        }

        private void LoadData()
        {
            try
            {
                // Load data for combobox
                // Product combobox
                ProductDAO productDAO = new ProductDAO();
                DataTable productsTable = new DataTable();
                productsTable = productDAO.GetAll(ref errorMessage);
                productItems.Clear();
                foreach (DataRow row in productsTable.Rows)
                {
                    productItems.Add(new ComboboxItem(row["name"].ToString(), row["product_id"].ToString()));
                }
                cbProduct.DisplayMember = "Text";
                cbProduct.ValueMember = "Value";
                cbProduct.DataSource = null;
                cbProduct.DataSource = productItems;

                // Company combobox
                CompanyDAO companyDAO = new CompanyDAO();
                DataTable companiesTable = new DataTable();
                companiesTable = companyDAO.GetAll(ref errorMessage);
                companyItems.Clear();
                foreach (DataRow row in companiesTable.Rows)
                {
                    companyItems.Add(new ComboboxItem(row["name"].ToString(), row["company_id"].ToString()));
                }
                cbCompany.DisplayMember = "Text";
                cbCompany.ValueMember = "Value";
                cbCompany.DataSource = null;
                cbCompany.DataSource = companyItems;
                // End load data for combobox  --------

                // Load data for datagridview
                DataTable employeesTable = new DataTable();
                employeesTable = importDAO.GetAll(ref errorMessage);
                dgvImports.DataSource = employeesTable;

                // Styling categories datagridview
                dgvImports.RowHeadersVisible = false;
                int width = dgvImports.Width;
                dgvImports.Columns[0].Visible = false; // import_id
                dgvImports.Columns[1].Width = (int)(width * 0.2); // import_date
                dgvImports.Columns[1].HeaderText = "Ngày nhập";
                dgvImports.Columns[2].Visible = false; // product_id
                dgvImports.Columns[3].Width = (int)(width * 0.2); // product_name
                dgvImports.Columns[3].HeaderText = "Tên Hàng";
                dgvImports.Columns[4].Visible = false; // company_id
                dgvImports.Columns[5].Width = (int)(width * 0.2); // company_name
                dgvImports.Columns[5].HeaderText = "Tên CTy";
                dgvImports.Columns[6].Width = (int)(width * 0.2); // quantity
                dgvImports.Columns[6].HeaderText = "SL";
                dgvImports.Columns[7].Width = (int)(width * 0.2); // price
                dgvImports.Columns[7].HeaderText = "Giá nhập";

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
            cbProduct.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            isAddMode = false;
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnCancel.Enabled = true;
            btnSave.Enabled = true;

            EnableInput(true);
            cbProduct.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(txtId.Text.Trim(), out int import_id))
            {
                DialogResult userConfirmation = MessageBox.Show("Bạn có chắc chắn xóa lịch sử Nhập hàng này không?", "Thông báo", MessageBoxButtons.OKCancel);
                if (userConfirmation == DialogResult.OK)
                {
                    try
                    {
                        if (importDAO.Delete(import_id, ref errorMessage) > 0)
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
                MessageBox.Show("Thông tin yêu cầu không hợp lệ");
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
                Int32.TryParse(cbCompany.SelectedValue.ToString().Trim(), out int company_id);
                Int32.TryParse(cbProduct.SelectedValue.ToString().Trim(), out int product_id);
                Int32.TryParse(txtPrice.Text.Trim(), out int price);
                Int32.TryParse(txtQuantity.Text.Trim(), out int quantity);
                string import_date = dtpImport.Text.Trim();

                // Validate data
                bool isValidData = !string.IsNullOrEmpty(import_date) &&
                                    company_id != 0 &&
                                    product_id != 0 &&
                                    price >= 0 &&
                                    quantity > 0;

                if (isValidData)
                {
                    try
                    {
                        if (importDAO.Insert(new ImportDTO(0, company_id, product_id, import_date, quantity, price), ref errorMessage) > 0)
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
                // *** Install this edit feature here
            }
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Prevent click on header
            if (e.RowIndex == -1) return;

            // Get selected row
            int curr = dgvImports.CurrentCell.RowIndex;

            // Get data from selected row
            string import_id = dgvImports.Rows[curr].Cells[0].Value.ToString();
            string import_date = dgvImports.Rows[curr].Cells[1].Value.ToString();
            string product_id = dgvImports.Rows[curr].Cells[2].Value.ToString();
            string company_id = dgvImports.Rows[curr].Cells[4].Value.ToString();
            string quantity = dgvImports.Rows[curr].Cells[6].Value.ToString();
            string price = dgvImports.Rows[curr].Cells[7].Value.ToString();

            // Fill data in inputs
            txtId.Text = import_id;
            dtpImport.Text = import_date;
            cbProduct.SelectedItem = productItems.Find(item => item.Value == product_id);
            cbCompany.SelectedItem = productItems.Find(item => item.Value == company_id);
            txtQuantity.Text = quantity;
            txtPrice.Text = price;
        }
    }
}
