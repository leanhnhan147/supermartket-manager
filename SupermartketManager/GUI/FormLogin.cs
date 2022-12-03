using SupermartketManager.DAO;
using SupermartketManager.DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace SupermartketManager.GUI
{
    public partial class FormLogin : Form
    {
        private DataTable userTable;
        private AccountDAO accountDAO;
        private string errorMessage;
        public FormLogin()
        {
            InitializeComponent();
            userTable = new DataTable();
            accountDAO = new AccountDAO();
            errorMessage = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string enteredPassword = txtPassword.Text.Trim();
            
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(enteredPassword))
            {
                DataProvider.Username = username;
                DataProvider.Password = enteredPassword;

                userTable = accountDAO.GetAccount(username, ref errorMessage);
                try
                {
                    if (userTable.Rows.Count > 0)
                    {
                        DataRow row = userTable.Rows[0];
                        string employee_id = row["employee_id"].ToString();
                        string employee_name = row["name"].ToString();
                        string position_name = row["position_name"].ToString();
                        string password = row["password"].ToString();
                        if (enteredPassword.Equals(password))
                        {
                            if (position_name.Equals("Giám đốc"))
                            {
                                FormMain formMain1 = new FormMain(employee_id, employee_name, position_name);
                                formMain1.ShowDialog();
                            }
                            else if (position_name.Equals("Quản lý"))
                            {
                                FormManager formManager = new FormManager(employee_id, employee_name, position_name);
                                formManager.ShowDialog();
                            }
                            else if (position_name.Equals("Thu ngân"))
                            {
                                FormCashier formCashier = new FormCashier(employee_id, employee_name, position_name);
                                formCashier.ShowDialog();
                            }
                            else
                            {
                                FormWarehouseKeeper formWarehouseKeeper = new FormWarehouseKeeper(employee_id, employee_name, position_name);
                                formWarehouseKeeper.ShowDialog();
                            }
                            txtUsername.ResetText();
                            txtPassword.ResetText();
                            txtUsername.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Mật khẩu chưa chính xác!");
                            txtPassword.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập không thành công!");
                        txtPassword.Focus();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(this, new EventArgs());
            }
        }
    }
}
