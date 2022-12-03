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

namespace SupermartketManager.GUI
{
    public partial class ControlRevenue : UserControl
    {
        BillDAO billDAO;
        String errorMessage;
        public ControlRevenue()
        {
            InitializeComponent();
            billDAO = new BillDAO();
            errorMessage = "";
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            int date = -1;
            int month = -1;
            int year = -1;
            if ((Int32.TryParse(txtDate.Text, out date) | Int32.TryParse(txtMonth.Text, out month) | Int32.TryParse(txtYear.Text, out year)) == false)
            {
                MessageBox.Show("Nhập khống đúng ngày, tháng hoặc năm", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (date > 0 && date <= 31 && month >= 1 && month <= 12 && year >= 0)
            {
                LoadDataDMY(date, month, year);
                txtYear.ResetText();
                txtDate.ResetText();
                txtMonth.ResetText();
            }
            else
            {
                MessageBox.Show("Nhập khống đúng ngày, tháng hoặc năm", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
        public void LoadDataDMY(int date, int month, int year)
        {
            try
            {
                // Retrieve data from db
                DataTable statisticsByMonthDb = new DataTable();
                statisticsByMonthDb = billDAO.StatisticByDMY(date, month, year, ref errorMessage);
                dgvStatistic.DataSource = statisticsByMonthDb;

                int width = dgvStatistic.Width;
                // Styling categories datagridview
                dgvStatistic.Columns[0].Width = (int)(width * 0.2);
                dgvStatistic.Columns[0].HeaderText = "Ngày";
                dgvStatistic.Columns[1].Width = (int)(width * 0.2);
                dgvStatistic.Columns[1].HeaderText = "Tháng";
                dgvStatistic.Columns[2].Width = (int)(width * 0.2);
                dgvStatistic.Columns[2].HeaderText = "Năm";
                dgvStatistic.Columns[3].Width = (int)(width * 0.2);
                dgvStatistic.Columns[3].HeaderText = "Doanh thu";
                dgvStatistic.Columns[4].Width = (int)(width * 0.2);
                dgvStatistic.Columns[4].HeaderText = "Tổng số đơn";
            }
            catch (Exception e)
            {
                MessageBox.Show(!string.IsNullOrEmpty(errorMessage) ? errorMessage : e.Message, "Thông báo!");
            }
        }
        private void btnStatisticM_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve data from db
                DataTable statisticsByMonth = new DataTable();
                statisticsByMonth = billDAO.StatisticByMontḥ(ref errorMessage);
                dgvStatistic.DataSource = statisticsByMonth;

                int width = dgvStatistic.Width;
                // Styling categories datagridview
                dgvStatistic.Columns[0].Width = (int)(width * 0.2);
                dgvStatistic.Columns[0].HeaderText = "Tháng";
                dgvStatistic.Columns[1].Width = (int)(width * 0.2);
                dgvStatistic.Columns[1].HeaderText = "Năm";
                dgvStatistic.Columns[2].Width = (int)(width * 0.6);
                dgvStatistic.Columns[2].HeaderText = "Doanh thu";
            }
            catch (Exception ex)
            {
                MessageBox.Show(!string.IsNullOrEmpty(errorMessage) ? errorMessage : ex.Message, "Thông báo!");
            }

        }
        private void btnStatisticY_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve data from db
                DataTable statisticsByYear = new DataTable();
                statisticsByYear = billDAO.StatisticByYear(ref errorMessage);
                dgvStatistic.DataSource = statisticsByYear;

                int width = dgvStatistic.Width;
                // Styling categories datagridview
                dgvStatistic.Columns[0].Width = (int)(width * 0.5);
                dgvStatistic.Columns[0].HeaderText = "Năm";
                dgvStatistic.Columns[1].Width = (int)(width * 0.5);
                dgvStatistic.Columns[1].HeaderText = "Doanh thu";
            }
            catch (Exception ex)
            {
                MessageBox.Show(!string.IsNullOrEmpty(errorMessage) ? errorMessage : ex.Message, "Thông báo!");
            }
        }
        private void btnGetBill_Click(object sender, EventArgs e)
        {
            int date = -1;
            int month = -1;
            int year = -1;
            if ((Int32.TryParse(txtDate.Text, out date) | Int32.TryParse(txtMonth.Text, out month) | Int32.TryParse(txtYear.Text, out year)) == false)
            {
                MessageBox.Show("Nhập khống đúng ngày, tháng hoặc năm", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (date > 0 && date <= 31 && month >= 1 && month <= 12 && year >= 0)
            {
                LoadBillByDate(date, month, year);
                txtYear.ResetText();
                txtDate.ResetText();
                txtMonth.ResetText();
            }
            else
            {
                MessageBox.Show("Nhập khống đúng ngày, tháng hoặc năm", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
        private void LoadBillByDate(int date, int month, int year)
        {
            try
            {
                // Retrieve data from db
                DataTable dbGetBill = new DataTable();
                dbGetBill = billDAO.getBillByDate(date, month, year, ref errorMessage);
                dgvStatistic.DataSource = dbGetBill;

                int width = dgvStatistic.Width;
                // Styling categories datagridview
                dgvStatistic.Columns[0].Width = (int)(width * 0.1);
                dgvStatistic.Columns[0].HeaderText = "Mã HD";
                dgvStatistic.Columns[1].Width = (int)(width * 0.2);
                dgvStatistic.Columns[1].HeaderText = "Tên NV";
                dgvStatistic.Columns[2].Width = (int)(width * 0.1);
                dgvStatistic.Columns[2].HeaderText = "SĐT KH";
                dgvStatistic.Columns[3].Width = (int)(width * 0.2);
                dgvStatistic.Columns[3].HeaderText = "Ngày tạo";
                dgvStatistic.Columns[4].Width = (int)(width * 0.2);
                dgvStatistic.Columns[4].HeaderText = "Giảm giá";
                dgvStatistic.Columns[5].Width = (int)(width * 0.2);
                dgvStatistic.Columns[5].HeaderText = "Tổng tiền";
            }
            catch (Exception ex)
            {
                MessageBox.Show(!string.IsNullOrEmpty(errorMessage) ? errorMessage : ex.Message, "Thông báo!");
            }
        }
    }
}
