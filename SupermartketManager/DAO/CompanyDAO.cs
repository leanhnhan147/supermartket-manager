using SupermartketManager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermartketManager.DAO
{
    internal class CompanyDAO
    {
        string query;

        public CompanyDAO()
        {
        }

        public int Insert(CompanyDTO company, ref string errorMessage)
        {
            query = "EXEC [dbo].[proc_Company_Add] @name , @address , @phone";
            return DataProvider.ExecuteNonQuery(query, ref errorMessage, new object[] { company.name, company.address, company.phone });
        }

        public int Update(CompanyDTO company, ref string errorMessage)
        {
            query = "EXEC [dbo].[proc_Company_Update] @company_id , @name , @address , @phone";
            return DataProvider.ExecuteNonQuery(query, ref errorMessage, new object[] { company.company_id, company.name, company.address, company.phone });
        }

        public int Delete(int companyId, ref string errorMessage)
        {
            query = "EXEC [dbo].[proc_Company_Delete] @company_id";
            return DataProvider.ExecuteNonQuery(query, ref errorMessage, new object[] { companyId });
        }

        public DataTable GetAll(ref string errorMessage)
        {
            query = "SELECT * FROM [dbo].[func_Company_GetAll]()";
            return DataProvider.ExecuteQuery(query, ref errorMessage);
        }

        public DataTable TopCompany(int month, int year, ref string errorMessage)
        {
            query = "SELECT * FROM [dbo].[func_Company_Find_TopSupply]( @month , @year )";
            return DataProvider.ExecuteQuery(query, ref errorMessage, new object[] {month, year});
        }
    }
}
