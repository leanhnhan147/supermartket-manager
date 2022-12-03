using SupermartketManager.DAO;
using SupermartketManager.DTO;
using SupermartketManager.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermartketManager.GUI
{
    public partial class FormPayment : Form
    {
        BillDAO billDAO = new BillDAO();
        string errorMessage;
        List<BillInfoDTO> billInfos;
        DataTable productsTable;

        public FormPayment(string employeeId, string employeeName, string positionName)
        {
            InitializeComponent();
            billDAO = new BillDAO();
            errorMessage = "";
            billInfos = new List<BillInfoDTO>();
            LoadData();
            txtEId.Text = employeeId;
            lbAccountInfo.Text = $"Nhân viên: {employeeName} [{positionName}]";
        }
        private void ResetInput()
        {
            txtId.ResetText();
            txtName.ResetText();
            txtPrice.ResetText();
            txtQuantity.ResetText();
            txtCName.ResetText();
            lbCPoint.ResetText();
            txtCPhone.ResetText();
        }

        private void UpdateFinalPrice()
        {
            Int32.TryParse(lbTotal.Text.ToString(), out int total);
            Int32.TryParse(txtDiscount.Text.ToString(), out int discount);
            Int32.TryParse(lbCPoint.Text.ToString(), out int avalablePoint);
            if (total >= discount && discount <= avalablePoint)
            {
                int finalTotal = total - discount;
                int remainder = finalTotal % 1000;
                if (remainder != 0)
                {
                    int addition = remainder >= 500 ? 1000 : 0;
                    finalTotal = finalTotal - remainder + addition;
                }
               
                lbFinalTotal.Text = finalTotal.ToString(); 
            }
            else
            {
                MessageBox.Show("Giảm giá không được lớn hơn tổng giá trị hóa đơn!", "Thông báo");
                txtDiscount.Text = "0";
            }
        }

        private void LoadData()
        {
            try
            {
                // Load data for products datagridview
                ProductDAO productDAO = new ProductDAO();
                productsTable = new DataTable();
                productsTable = productDAO.GetAll(ref errorMessage);
                dgvProducts.DataSource = null;
                dgvProducts.DataSource = productsTable;

                // Styling products datagridview
                dgvProducts.RowHeadersVisible = false;
                int width = dgvProducts.Width;
                dgvProducts.Columns[0].Visible = false; // product_id
                dgvProducts.Columns[1].Width = (int)(width * 0.4); // name
                dgvProducts.Columns[1].HeaderText = "Ngày nhập";
                dgvProducts.Columns[2].Width = (int)(width * 0.3); // quantity
                dgvProducts.Columns[2].HeaderText = "SL còn";
                dgvProducts.Columns[3].Width = (int)(width * 0.3); // price
                dgvProducts.Columns[3].HeaderText = "Đơn giá";
                // Just aboves, hide the orthers
                dgvProducts.Columns[4].Visible = false;
                dgvProducts.Columns[5].Visible = false;
                dgvProducts.Columns[6].Visible = false;
                dgvProducts.Columns[7].Visible = false;
                dgvProducts.Columns[8].Visible = false;
                dgvProducts.Columns[9].Visible = false;
                // ------------------------------

                btnDeleteBillInfo.Enabled = false;
                ResetInput();
            }
            catch (Exception ex)
            {
                MessageBox.Show(!string.IsNullOrEmpty(errorMessage) ? errorMessage : ex.Message, "Thông báo!");
            }
        }

        private void LoadBillInfosData()
        {
            DataTable billInfosTable = new DataTable();
            billInfosTable.Columns.Clear();
            billInfosTable.Columns.Add("product_id", typeof(string));
            billInfosTable.Columns.Add("product_name", typeof(string));
            billInfosTable.Columns.Add("price", typeof(string));
            billInfosTable.Columns.Add("quantity", typeof(string));
            foreach (BillInfoDTO billInfo in billInfos)
            {
                string name = productsTable.AsEnumerable().SingleOrDefault(r => r.Field<int>("product_id") == billInfo.product_id)["name"].ToString();
                DataRow row = billInfosTable.NewRow();
                row["product_id"] = billInfo.product_id;
                row["product_name"] = name;
                row["price"] = billInfo.price;
                row["quantity"] = billInfo.quantity;
                billInfosTable.Rows.Add(row);
            }

            dgvBillInfos.DataSource = null;
            dgvBillInfos.DataSource = billInfosTable;
            dgvBillInfos.RowHeadersVisible = false;
            int width = dgvBillInfos.Width;
            dgvBillInfos.Columns[0].Visible = false;
            dgvBillInfos.Columns[1].Width = (int)(width * 0.4); // name
            dgvBillInfos.Columns[1].HeaderText = "Mặt hàng";
            dgvBillInfos.Columns[2].Width = (int)(width * 0.3); // price
            dgvBillInfos.Columns[2].HeaderText = "Đơn giá";
            dgvBillInfos.Columns[3].Width = (int)(width * 0.3); // quantity
            dgvBillInfos.Columns[3].HeaderText = "Số lượng";

            // Update total and final total
            try
            {
                int total = 0;
                BillInfoDAO billInfoDAO = new BillInfoDAO();
                foreach (BillInfoDTO billInfo in billInfos)
                {
                    total += billInfoDAO.CalcTotal(billInfo, ref errorMessage);
                }
                lbTotal.Text = total.ToString();
                UpdateFinalPrice();
            }
            catch
            {

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Get keyword from input
            string keyword = txtSearch.Text.Trim();
            
            // Validate keyword
            if (!string.IsNullOrEmpty(keyword))
            {
                ProductDAO productDAO = new ProductDAO();
                DataTable resultTable = productDAO.FindByName(keyword, ref errorMessage);
                dgvProducts.DataSource = resultTable;
            }
        }

        private void btnCustomerSearch_Click(object sender, EventArgs e)
        {
            string customer_phone = txtCPhone.Text.Trim();
            if (!string.IsNullOrEmpty(customer_phone))
            {
                try
                {
                    CustomerDAO customerDAO = new CustomerDAO();
                    DataTable customerTable = customerDAO.FindByPhone(customer_phone, ref errorMessage);
                    int numberOfRecords = customerTable.Rows.Count;
                    if (numberOfRecords == 0)
                    {
                        txtCName.ResetText();
                        lbCPoint.Text = "0";
                    }
                    else
                    {
                        string customer_name = customerTable.Rows[0]["name"].ToString();
                        string point = customerTable.Rows[0]["point"].ToString();
                        txtCName.Text = customer_name;
                        lbCPoint.Text = point;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(!string.IsNullOrEmpty(errorMessage) ? errorMessage : ex.Message, "Thông báo!");
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Int32.TryParse(txtId.Text.Trim(), out int product_id);
            string name = txtName.Text.Trim();
            Int32.TryParse(txtPrice.Text.Trim(), out int price);
            bool isValid = product_id != 0 && !string.IsNullOrEmpty(name) && price >= 0;
            if (isValid)
            {
                Int32.TryParse(productsTable.AsEnumerable().SingleOrDefault(r => r.Field<int>("product_id") == product_id)["quantity"].ToString(), out int availableQuantity);
                Int32.TryParse(txtQuantity.Text, out int quantity);
                if (quantity > 0 && quantity <= availableQuantity)
                {
                    int index = billInfos.FindIndex(b => b.product_id == product_id);
                    if (index == -1) // item doesn't exist in list, create a new one 
                    {
                        BillInfoDTO billInfo = new BillInfoDTO(0, product_id, quantity, price);
                        billInfos.Add(billInfo);
                    }
                    else // already exist, change the quantity 
                    {
                        billInfos[index].quantity = quantity;
                    }
                    LoadBillInfosData();
                    ResetInput();
                }
                else
                {
                    MessageBox.Show("Số lượng không hợp lệ, vui lòng kiểm tra lại");
                    txtQuantity.ResetText();
                    txtQuantity.Focus();
                }
            }
            else
            {
                MessageBox.Show("Thông tin sản phẩm không hợp lệ, vui lòng thử lại!");
            }
        }

        private void btnCancelBillInfo_Click(object sender, EventArgs e)
        {
            Int32.TryParse(txtId.Text.Trim(), out int product_id);
            if (product_id != 0)
            {
                DialogResult userConfirmation = MessageBox.Show("Bạn có chắc chắn xóa mặt hàng này khỏi hóa đơn này?", "Thông báo", MessageBoxButtons.OKCancel);
                if (userConfirmation == DialogResult.OK)
                {
                    billInfos.RemoveAll(b => b.product_id == product_id);
                }
                LoadBillInfosData();
                ResetInput();
            }
            else
            {
                MessageBox.Show("Mã hàng không hợp lệ");
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
            string price = dgvProducts.Rows[curr].Cells[3].Value.ToString();

            // Fill data in inputs
            txtId.Text = product_id;
            txtName.Text = name;
            txtPrice.Text = price;
            btnDeleteBillInfo.Enabled = false;
            txtQuantity.Focus();
        }

        private void dgvBillInfos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Prevent click on header
            if (e.RowIndex == -1) return;

            // Get selected row
            int curr = dgvBillInfos.CurrentCell.RowIndex;
            // Get data from selected row
            string product_id = dgvBillInfos.Rows[curr].Cells[0].Value.ToString();
            string name = dgvBillInfos.Rows[curr].Cells[1].Value.ToString();
            string price = dgvBillInfos.Rows[curr].Cells[2].Value.ToString();
            string quantity = dgvBillInfos.Rows[curr].Cells[3].Value.ToString();

            // Fill data in inputs
            txtId.Text = product_id;
            txtName.Text = name;
            txtPrice.Text = price;
            txtQuantity.Text = quantity;
            btnDeleteBillInfo.Enabled = true;
            txtQuantity.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            billInfos.Clear();
            LoadBillInfosData();
            LoadData();
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            UpdateFinalPrice();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            Int32.TryParse(txtEId.Text, out int employee_id);
            if (billInfos.Count > 0 && employee_id > 0)
            {
                DialogResult userConfirmation = MessageBox.Show("Bạn có chắc chắn tạo hóa đơn này? Sẽ không thể thay đổi trong tương lai.", "Thông báo", MessageBoxButtons.OKCancel);
                if (userConfirmation == DialogResult.OK)
                {
                    string customer_phone = txtCPhone.Text;
                    Int32.TryParse(txtDiscount.Text.Trim(), out int discount);
                    try
                    {
                        BillDAO billDAO = new BillDAO();
                        BillDTO bill = new BillDTO(0, employee_id, customer_phone, "", discount, 0, 0);
                        if (billDAO.Insert(bill, ref errorMessage) > 0)
                        {
                            int bill_id = billDAO.GetNewestBillId(ref errorMessage);

                            foreach (BillInfoDTO billInfo in billInfos)
                            {
                                billInfo.bill_id = bill_id;
                                BillInfoDAO billInfoDAO = new BillInfoDAO();
                                billInfoDAO.Insert(billInfo, ref errorMessage);
                            }
                            billDAO.RoundTotal(bill_id, ref errorMessage);

                            if (!string.IsNullOrEmpty(customer_phone))
                            {
                                billDAO.RoundTotal(bill_id, ref errorMessage);
                                
                                CustomerDAO customerDAO = new CustomerDAO();
                                if (customerDAO.AccumulatePoints(customer_phone, bill_id, ref errorMessage) > 0)
                                {
                                    MessageBox.Show("Tích điểm thành công");
                                }
                            }
                        }
                        else
                        {
                            errorMessage = "Đã xảy ra lỗi";
                            throw new Exception();
                        }

                        txtDiscount.ResetText();
                        billInfos.Clear();
                        LoadData();
                        LoadBillInfosData();
                    }
                    catch
                    {
                        MessageBox.Show(errorMessage);
                    }
                }
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            txtSearch.ResetText();
            LoadData();
        }
    }
}
