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
using System.Windows.Data;
using System.Windows.Forms;

namespace SupermartketManager.GUI
{
    public partial class ControlViewBill : UserControl
    {
        BillDAO billDAO;
        string errorMessage;
        public ControlViewBill()
        {
            InitializeComponent();
            billDAO = new BillDAO();
            errorMessage = "";
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                // Retrieve data from db
                DataTable BillTable = new DataTable();
                BillTable = billDAO.ViewBill(ref errorMessage);

                dgvBill.DataSource = BillTable;

                int width = dgvBill.Width;

                // Styling categories datagridview
                dgvBill.RowHeadersVisible = false;
                dgvBill.Columns[0].Visible = false;
                dgvBill.Columns[1].Width = (int)(width * 0.2); // name
                dgvBill.Columns[1].HeaderText = "Ngày tạo";
                // Retrieve data from db

                // Styling categories datagridview
                dgvBill.Columns[2].Width = (int)(width * 0.2);
                dgvBill.Columns[2].HeaderText = "Nhân Viên";
                dgvBill.Columns[3].Width = (int)(width * 0.2);
                dgvBill.Columns[3].HeaderText = "Số điện thoại khách hàng";
                dgvBill.Columns[4].Width = (int)(width * 0.1);
                dgvBill.Columns[4].HeaderText = "Giảm giá";
                dgvBill.Columns[5].Width = (int)(width * 0.3);
                dgvBill.Columns[5].HeaderText = "Tên sản phẩm";
                dgvBill.Columns[6].Width = (int)(width * 0.1);
                dgvBill.Columns[6].HeaderText = "Số lượng";
                dgvBill.Columns[7].Width = (int)(width * 0.1);
                dgvBill.Columns[7].HeaderText = "Giá tiền";

            }
            catch (Exception ex)
            {
                MessageBox.Show(!string.IsNullOrEmpty(errorMessage) ? errorMessage : ex.Message, "Thông báo!");
            }
        }

        private void dgvBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
