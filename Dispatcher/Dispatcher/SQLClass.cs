using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Dispatcher
{
    class SQLClass
    {
        public static void UltimateSQLSelect(DataGrid dataGrid, String sqlTable)
        {
            SqlDataAdapter adapter = null;
            string connectionString = Properties.Settings.Default.SqlConnectionString;
            string sqlExpression = String.Format("SELECT * FROM {0}", sqlTable);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);

                adapter = new SqlDataAdapter(sqlExpression, connectionString);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGrid.ItemsSource = table.DefaultView;
            }
        }

        public static void UltimateSQLInsert(String sqlTable, string name)
        {
            string connectionString = Properties.Settings.Default.SqlConnectionString;
            string sqlExpression = String.Format("INSERT INTO {0} (Name) VALUES ('{1}')", sqlTable, name);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.ExecuteNonQuery(); //Выполнение запроса без возращения данных
            }
        }

        public static void UltimateSQLDelite(String sqlTable, int id)
        {
            string connectionString = Properties.Settings.Default.SqlConnectionString;
            string sqlExpression = String.Format("DELETE FROM {0} WHERE ID={1}", sqlTable, id);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.ExecuteNonQuery(); //Выполнение запроса без возращения данных
            }
        }

        public static void UltimateSQLUpdate(String sqlTable, int id, string name)
        {
            string connectionString = Properties.Settings.Default.SqlConnectionString;
            string sqlExpression = String.Format("UPDATE {0} SET Name='{1}' WHERE ID={2}", sqlTable, name, id);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.ExecuteNonQuery(); //Выполнение запроса без возращения данных
            }
        }
    }
}
