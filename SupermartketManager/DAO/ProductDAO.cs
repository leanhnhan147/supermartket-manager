using SupermartketManager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SupermartketManager.DAO
{
    internal class ProductDAO
    {
        string query;

        public ProductDAO()
        {
        }

        public int Insert(ProductDTO product, ref string errorMessage)
        {
            
            query = "EXECUTE [dbo].[proc_Product_Add] @name , @quantity , @price , @mfg_date , @exp_date , @category_id , @warehouse_id";
            return DataProvider.ExecuteNonQuery(query, ref errorMessage, new object[] { product.name, product.quantity, product.price, product.mfg_date, product.exp_date, product.category_id, product.warehouse_id});
        }

        public int Update(ProductDTO product, ref string errorMessage)
        {
            query = "EXEC [dbo].[proc_Product_Update] @product_id , @name , @quantity , @price , @mfg_date , @exp_date , @category_id , @warehouse_id";
            return DataProvider.ExecuteNonQuery(query, ref errorMessage, new object[] { product.product_id, product.name, product.quantity, product.price, product.mfg_date, product.exp_date, product.category_id, product.warehouse_id});
        }

        public int Delete(int product_id, ref string errorMessage)
        {
            query = "EXEC [dbo].[proc_Product_Delete] @product_id";
            return DataProvider.ExecuteNonQuery(query, ref errorMessage, new object[] { product_id });
        }

        public DataTable GetAll(ref string errorMessage)
        {
            query = "SELECT * FROM [dbo].[func_Product_GetAll]()";
            return DataProvider.ExecuteQuery(query, ref errorMessage);
        }

        public DataTable FindByName(string keyword, ref string errorMessage)
        {
            query = "SELECT * FROM [dbo].[func_Product_SearchByKeyword]( @keyword )";
            return DataProvider.ExecuteQuery(query, ref errorMessage, new object[] { keyword });
        }

        public DataTable SoldByMonth(int month, int year, ref string errorMessage)
        {
            query = "SELECT * FROM [dbo].[func_Product_SoldByMonth]( @month , @year )";
            return DataProvider.ExecuteQuery(query, ref errorMessage, new object[] { month, year });
        }
    }
}
