using SupermartketManager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermartketManager.DAO
{
    internal class ImportDAO
    {
        string query;

        public ImportDAO()
        {
        }

        public int Insert(ImportDTO import, ref string errorMessage)
        {
            query = "EXECUTE [dbo].[proc_Import_Add] @company_id , @product_id , @import_date , @quantity , @price";
            return DataProvider.ExecuteNonQuery(query, ref errorMessage, new object[] { import.company_id, import.product_id, import.import_date, import.quantity, import.price });
        }

        public int Update(ImportDTO import, ref string errorMessage)
        {
            // *** Update this feature in the future
            return 0; 
        }

        public int Delete(int import_id, ref string errorMessage)
        {
            query = "EXEC [dbo].[proc_Import_Delete] @import_id";
            return DataProvider.ExecuteNonQuery(query, ref errorMessage, new object[] { import_id });
        }

        public DataTable GetAll(ref string errorMessage)
        {
            query = "SELECT * FROM [dbo].[func_Import_GetAll]()";
            return DataProvider.ExecuteQuery(query, ref errorMessage);
        }
    }
}
