﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Dispatcher
{
    class SQLClass
    {
        public static void ReturnSQL(DataGrid dataGrid, String sqlString)
        {
            try
            {
                SqlDataAdapter adapter;
                string connectionString = Properties.Settings.Default.SqlConnectionString;
                string sqlExpression = sqlString;

                Trace.WriteLine("Connection sring = " + connectionString);
                Trace.WriteLine("Query = " + sqlExpression);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);

                    adapter = new SqlDataAdapter(sqlExpression, connectionString);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGrid.ItemsSource = table.DefaultView;
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void NoReturnSQL(String sqlString)
        {
            try
            {
                string connectionString = Properties.Settings.Default.SqlConnectionString;
                string sqlExpression = sqlString;

                Trace.WriteLine("Connection sring = " + connectionString);
                Trace.WriteLine("Query = " + sqlExpression);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    command.ExecuteNonQuery(); //Выполнение запроса без возращения данных
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static object[] MyGetArray(DataGrid dataGrid)
        {
            try
            {
                DataRowView row = dataGrid.SelectedItem as DataRowView;
                return row.Row.ItemArray;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static string MyGetItemArray(DataGrid dataGrid, int i)
        {
            try
            {
                object[] array = MyGetArray(dataGrid);
                return array[i].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static string ArrayToValue(string[] valueName, string[] value)
        {
            List<string> valueСollection = new List<string>();
            for(int i = 0; i<valueName.Length; i++)
                valueСollection.Add(String.Concat(valueName[i], "=", value[i]));
            string resultStr = String.Join(", ", valueСollection);
            Trace.WriteLine(resultStr);
            return resultStr;
        }

        public static int GetCollumnCount(string dataTable)
        {
            string connectionString = Properties.Settings.Default.SqlConnectionString;
            string sqlExpression = String.Format("SELECT COUNT(*) FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{0}'", dataTable);

            Trace.WriteLine("Connection sring = " + connectionString);
            Trace.WriteLine("Query = " + sqlExpression);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader sqlDataReader = command.ExecuteReader();

                string result = "0";

                // Call Read before accessing data.
                while (sqlDataReader.Read())
                {
                    result = sqlDataReader[0].ToString();
                }

                // Call Close when done reading.
                sqlDataReader.Close();
                connection.Close();

                return Convert.ToInt32(result);
            }
        }
    }
}
