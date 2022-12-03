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
    public partial class ControlPosition : UserControl
    {
        PositionDAO positionDAO;
        string errorMessage;
        bool isAddMode;

        public ControlPosition()
        {
            InitializeComponent();
            positionDAO = new PositionDAO();
            errorMessage = "";
            isAddMode = false;
            LoadData();
        }

        private void EnableInput(bool enable)
        {
            txtId.Enabled = enable;
            txtName.Enabled = enable;
            txtSalary.Enabled = enable;
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
                DataTable positionsTable = new DataTable();
                positionsTable = positionDAO.GetAll(ref errorMessage);
                dgvPositions.DataSource = positionsTable;

                // Styling categories datagridview
                dgvPositions.RowHeadersVisible = false;
                int width = dgvPositions.Width;
                dgvPositions.Columns[0].Visible = false; // position_id
                dgvPositions.Columns[1].Width = (int)(width * 0.6); // name
                dgvPositions.Columns[1].HeaderText = "Tên chức vụ";
                dgvPositions.Columns[2].Width = (int)(width * 0.4); // salary
                dgvPositions.Columns[2].HeaderText = "Mức lương";

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
                DialogResult userConfirmation = MessageBox.Show("Bạn có chắc chắn xóa Danh mục này?", "Thông báo", MessageBoxButtons.OKCancel);
                if (userConfirmation == DialogResult.OK)
                {
                    try
                    {
                        if (positionDAO.Delete(id, ref errorMessage) > 0)
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
                Int32.TryParse(txtSalary.Text.Trim(), out int salary);

                // Validate data
                bool isValidData = !string.IsNullOrEmpty(name) && salary > 0;

                if (isValidData)
                {
                    try
                    {
                        if (positionDAO.Insert(new PositionDTO(0, name, salary), ref errorMessage) > 0)
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
                Int32.TryParse(txtId.Text.Trim(), out int position_id);
                string name = txtName.Text.Trim();
                Int32.TryParse(txtSalary.Text.Trim(), out int salary);

                // Validate data
                bool isValidData = position_id >= 0 && !string.IsNullOrEmpty(name) && salary > 0;

                if (isValidData)
                {
                    try
                    {
                        if (positionDAO.Update(new PositionDTO(position_id, name, salary), ref errorMessage) > 0)
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
            if (e.RowIndex == -1) return; // Prevent click on header

            // Get selected row
            int curr = dgvPositions.CurrentCell.RowIndex;

            // Get data from select row
            string category_id = dgvPositions.Rows[curr].Cells[0].Value.ToString();
            string name = dgvPositions.Rows[curr].Cells[1].Value.ToString();
            string salary = dgvPositions.Rows[curr].Cells[2].Value.ToString();

            // Fill data to inputs
            txtId.Text = category_id;
            txtName.Text = name;
            txtSalary.Text = salary;
        }
    }
}
