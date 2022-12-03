using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SupermartketManager.DAO;

namespace SupermartketManager.GUI
{
    public partial class ControlProductSoldByMonth : UserControl
    {
        private string errorMessage;
        private ProductDAO productDAO;
        public ControlProductSoldByMonth()
        {
            InitializeComponent();
            productDAO = new ProductDAO();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            int month = -1;
            int year = -1;
            if ((Int32.TryParse(txtMonth.Text, out month) | Int32.TryParse(txtYear.Text, out year)) == false)
            {
                MessageBox.Show("Nhập không đúng tháng hoặc năm", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (month >= 1 && month <= 12 && year >= 0)
            {
                ProductSoldByMonth(month, year);
            }
        }

        private void ProductSoldByMonth(int month, int year)
        {
            try
            {
                // Load data 
                DataTable productTable = new DataTable();
                productTable = productDAO.SoldByMonth(month, year, ref errorMessage);

                dgvProduct.DataSource = productTable;

                // Styling categories datagridview
                dgvProduct.RowHeadersVisible = false;

                int width = dgvProduct.Width;
                dgvProduct.Columns[0].Visible = false; // product_id
                dgvProduct.Columns[1].Width = (int)(width * 0.53); // name
                dgvProduct.Columns[1].HeaderText = "Tên Mặt Hàng";
                dgvProduct.Columns[2].Width = (int)(width * 0.47); // quantity
                dgvProduct.Columns[2].HeaderText = "Tổng số lượng";
            }
            catch (Exception ex)
            {
                MessageBox.Show(!string.IsNullOrEmpty(errorMessage) ? errorMessage : ex.Message, "Thông báo!");
            }
        }
    }
}
