using SupermartketManager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermartketManager.DAO
{
    internal class BillInfoDAO
    {
        string query;

        public BillInfoDAO()
        {
        }

        public int Insert(BillInfoDTO billInfo, ref string errorMessage)
        {
            query = "EXEC [dbo].[proc_BillInfo_Add] @bill_id , @product_id , @quantity , @price";
            return DataProvider.ExecuteNonQuery(query, ref errorMessage, new object[] { billInfo.bill_id, billInfo.product_id, billInfo.quantity, billInfo.price });
        }

        public int Update(BillInfoDTO billInfo, ref string errorMessage)
        {
            // **** Install this feature in the future
            return 0;
        }

        public int Delete(int billInfoId, ref string errorMessage)
        {
            // **** Install this feature in the future
            return 0;
        }

        public DataTable GetAll(ref string errorMessage)
        {
            query = "SELECT * FROM [dbo].[func_BillInfo_GetAll]()";
            return DataProvider.ExecuteQuery(query, ref errorMessage);
        }

        public int CalcTotal(BillInfoDTO billInfo, ref string errorMessage)
        {
            query = "SELECT [dbo].[func_BillInfo_CalcTotal] ( @quantity , @price )";
            return (int)(DataProvider.ExecuteScalar(query, ref errorMessage, new object[] { billInfo.quantity, billInfo.price }));
        }
    }
}
