using SupermartketManager.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SupermartketManager.DTO;

namespace SupermartketManager.GUI
{
    public partial class ControlCategory : UserControl
    {
        CategoryDAO categoryDAO;
        string errorMessage;
        bool isAddMode;

        public ControlCategory()
        {
            InitializeComponent();
            categoryDAO = new CategoryDAO();
            errorMessage = "";
            isAddMode = false;
            LoadData();
        }

        private void EnableInput(bool enable)
        {
            txtName.Enabled = enable;
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
        }

        private void LoadData()
        {
            try
            {
                // Retrieve data from db
                DataTable categoriesTable = new DataTable();
                categoriesTable = categoryDAO.GetAll(ref errorMessage);
                dgvCategories.DataSource = categoriesTable;

                // Styling categories datagridview
                dgvCategories.RowHeadersVisible = false;
                dgvCategories.Columns[0].Visible = false;
                dgvCategories.Columns[1].Width = dgvCategories.Width; // name
                dgvCategories.Columns[1].HeaderText = "Tên danh mục";

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
                DialogResult userConfirmation = MessageBox.Show("Bạn có chắc chắn xóa danh mục này?", "Thông báo", MessageBoxButtons.OKCancel);
                if (userConfirmation == DialogResult.OK)
                {
                    try
                    {
                        if (categoryDAO.Delete(id, ref errorMessage) > 0)
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
                MessageBox.Show("Mã danh mục không hợp lệ");
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

                // Validate data
                bool isValidData = !string.IsNullOrEmpty(name);

                if (isValidData)
                {
                    try
                    {
                        if (categoryDAO.Insert(new CategoryDTO(0, name), ref errorMessage) > 0)
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
                Int32.TryParse(txtId.Text.Trim(), out int category_id);
                string name = txtName.Text.Trim();

                // Validate data
                bool isValidData = category_id != 0 && !string.IsNullOrEmpty(name);

                if (isValidData)
                {
                    try
                    {
                        if (categoryDAO.Update(new CategoryDTO(category_id, name), ref errorMessage) > 0)
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

        private void dgvCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Prevent click on header
            if (e.RowIndex == -1) return;

            // Get selected row
            int curr = dgvCategories.CurrentCell.RowIndex;

            // Get data from selected row
            string category_id = dgvCategories.Rows[curr].Cells[0].Value.ToString();
            string name = dgvCategories.Rows[curr].Cells[1].Value.ToString();

            // Fill data in inputs
            txtId.Text = category_id;
            txtName.Text = name;
        }
    }
}
