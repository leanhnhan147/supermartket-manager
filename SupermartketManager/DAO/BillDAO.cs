using SupermartketManager.DTO;
using System;
using System.Data;

namespace SupermartketManager.DAO
{
    internal class BillDAO
    {
        string query;

        public BillDAO()
        {
        }

        public int Insert(BillDTO bill, ref string errorMessage)
        {
            query = "EXEC [dbo].[proc_Bill_Add] @employee_id , @customer_phone , @discount";
            return DataProvider.ExecuteNonQuery(query, ref errorMessage, new object[] { bill.employee_id, bill.customer_phone, bill.discount });
        }

        public int Update(BillDTO bill, ref string errorMessage)
        {
            query = "EXEC [dbo].[proc_Bill_Update] @bill_id , @name";
            return DataProvider.ExecuteNonQuery(query, ref errorMessage, new object[] { bill.bill_id, bill.employee_id });
        }

        public int Delete(int billId, ref string errorMessage)
        {
            query = "EXEC [dbo].[proc_Bill_Delete] @bill_id";
            return DataProvider.ExecuteNonQuery(query, ref errorMessage, new object[] { billId });
        }

        public DataTable GetAll(ref string errorMessage)
        {
            query = "SELECT * FROM [dbo].[func_Bill_GetAll]()";
            return DataProvider.ExecuteQuery(query, ref errorMessage);
        }

        public int GetNewestBillId(ref string errorMessage)
        {
            query = "SELECT [dbo].[func_Bill_GetNewestBillId] ()";
            return (int)(DataProvider.ExecuteScalar(query, ref errorMessage));
        }

        public int RoundTotal(int bill_id, ref string errorMessage)
        {
            query = "EXEC [dbo].[proc_Bill_RoundTotal] @bill_id";
            return DataProvider.ExecuteNonQuery(query, ref errorMessage, new object[] { bill_id });
        }
        public DataTable getBillByDate(int date, int month, int year, ref String errorMessage)
        {
            query = "SELECT * from [func_Bill_Find_ByDateMonthYear]( @Date , @Month , @Year )";
            return DataProvider.ExecuteQuery(query, ref errorMessage, new object[] { date, month, year });
        }
        public DataTable StatisticByMontḥ(ref String errorMessage)
        {
            query = "SELECT * from [dbo].[func_Statistic_Sale_ByMonth]()";
            return DataProvider.ExecuteQuery(query, ref errorMessage);
        }
        public DataTable StatisticByYear(ref String errorMessage)
        {
            query = "SELECT * from [dbo].[func_Statistic_Sale_ByYear]()";
            return DataProvider.ExecuteQuery(query, ref errorMessage);
        }

        public DataTable ViewBill(ref String errorMessage)
        {
            query = "SELECT * from [dbo].[view_BILL_BILLINFO]";
            return DataProvider.ExecuteQuery(query, ref errorMessage);
        }
        public DataTable StatisticByDMY(int date, int month, int year, ref string errorMessage)
        {
            query = "SELECT * FROM [dbo].[func_Statistic_Sale_ByDate] ( @Date , @Month , @Year )";
            return DataProvider.ExecuteQuery(query, ref errorMessage, new object[] { date, month, year });
        }
    }
}
