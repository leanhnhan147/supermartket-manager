using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermartketManager.DAO
{
    internal class DataProvider
    {
        public static string ConnectionString;
        public static string Username;
        public static string Password;
        public static SqlConnection Connection;

        public static void OpenConnection()
        {
            if (Connection.State == ConnectionState.Closed)
            {
                Connection.Open();
            }
        }

        public static void CloseConnection()
        {
            if (Connection.State == ConnectionState.Open)
            {
                Connection.Close();
            }
        }

        public static DataTable ExecuteQuery(string query, ref string errorMessage, object[] parameterValues = null)
        {
            ConnectionString = $@"Data Source=.;Initial Catalog=SupermarketManagement; User ID={Username}; Password={Password}";
            DataTable dataTable = new DataTable();
            try
            {
                using (Connection = new SqlConnection(ConnectionString))
                {
                    OpenConnection();
                    SqlCommand command = new SqlCommand(query, Connection);
                    if (parameterValues != null)
                    {
                        string[] parameters = query.Split(' ');
                        int i = 0;
                        foreach (string item in parameters)
                        {
                            if (item.Contains('@'))
                            {
                                command.Parameters.AddWithValue(item, parameterValues[i]);
                                i++;
                            }
                        }
                    }
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
            }
            catch (Exception e) { errorMessage = e.Message; }
            finally { CloseConnection(); }
            return dataTable;
        }

        public static int ExecuteNonQuery(string query, ref string errorMessage, object[] parameterValues = null)
        {
            ConnectionString = $@"Data Source=.;Initial Catalog=SupermarketManagement; User ID={Username}; Password={Password}";
            int rowsAffected = 0;
            try
            {
                using (Connection = new SqlConnection(ConnectionString))
                {
                    OpenConnection();
                    SqlCommand command = new SqlCommand(query, Connection);
                    if (parameterValues != null)
                    {
                        string[] parameters = query.Split(' ');
                        int i = 0;
                        foreach (string item in parameters)
                        {
                            if (item.Contains('@'))
                            {
                                command.Parameters.AddWithValue(item, parameterValues[i]);
                                i++;
                            }
                        }
                    }
                    rowsAffected = command.ExecuteNonQuery();
                }
            }
            catch (Exception e) { errorMessage = e.Message; }
            finally { CloseConnection(); }
            return rowsAffected;
        }

        public static object ExecuteScalar(string query, ref string errorMessage, object[] parameterValues = null)
        {
            ConnectionString = $@"Data Source=.;Initial Catalog=SupermarketManagement; User ID={Username}; Password={Password}";
            object data = null;
            try
            {
                using (Connection = new SqlConnection(ConnectionString))
                {
                    OpenConnection();
                    SqlCommand command = new SqlCommand(query, Connection);
                    if (parameterValues != null)
                    {
                        string[] parameters = query.Split(' ');
                        int i = 0;
                        foreach (string item in parameters)
                        {
                            if (item.Contains('@'))
                            {
                                command.Parameters.AddWithValue(item, parameterValues[i]);
                                i++;
                            }
                        }
                    }
                    data = command.ExecuteScalar();
                }
            }
            catch (Exception e) { errorMessage = e.Message; }
            finally { CloseConnection(); }
            return data;
        }
    }
}
