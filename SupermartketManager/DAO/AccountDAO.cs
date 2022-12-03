using SupermartketManager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace SupermartketManager.DAO
{
    internal class AccountDAO
    {
        string query;

        public AccountDAO()
        {
        }

        public int Insert(AccountDTO account, ref string errorMessage)
        {
            query = "EXEC [dbo].[proc_Account_Add] @username , @password , @employee_id";
            return DataProvider.ExecuteNonQuery(query, ref errorMessage, account.ToArray());
        }

        public int Update(AccountDTO account, ref string errorMessage)
        {
            query = "EXEC [dbo].[proc_Account_Update] @username , @password";
            return DataProvider.ExecuteNonQuery(query, ref errorMessage, account.ToArray());
        }

        public int Delete(string username, ref string errorMessage)
        {
            query = "EXEC [dbo].[proc_Account_Delete] @username";
            return DataProvider.ExecuteNonQuery(query, ref errorMessage, new object[] { username });
        }

        public DataTable GetAll(ref string errorMessage)
        {
            query = "SELECT * FROM [dbo].[func_Account_GetAll]()";
            return DataProvider.ExecuteQuery(query, ref errorMessage);
        }

        public DataTable GetAccount(string username, ref string errorMessage)
        {
            query = "SELECT * FROM [dbo].[func_Account_GetAccount]( @username )";
            return DataProvider.ExecuteQuery(query, ref errorMessage, new object[] { username });
        }
    }
}
