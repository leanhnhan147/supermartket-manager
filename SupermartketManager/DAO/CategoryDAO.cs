using SupermartketManager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermartketManager.DAO
{
    internal class CategoryDAO
    {
        string query;

        public CategoryDAO()
        {
        }

        public int Insert(CategoryDTO category, ref string errorMessage)
        {
            query = "EXEC [dbo].[proc_Category_Add] @name";
            return DataProvider.ExecuteNonQuery(query, ref errorMessage, new object[] { category.name });
        }

        public int Update(CategoryDTO category, ref string errorMessage)
        {
            query = "EXEC [dbo].[proc_Category_Update] @category_id , @name";
            return DataProvider.ExecuteNonQuery(query, ref errorMessage, new object[] { category.category_id, category.name });
        }

        public int Delete(int categoryId, ref string errorMessage)
        {
            query = "EXEC [dbo].[proc_Category_Delete] @category_id";
            return DataProvider.ExecuteNonQuery(query, ref errorMessage, new object[] { categoryId });
        }

        public DataTable GetAll(ref string errorMessage)
        {
            query = "SELECT * FROM [dbo].[func_Category_GetAll]()";
            return DataProvider.ExecuteQuery(query, ref errorMessage);
        }
    }
}
