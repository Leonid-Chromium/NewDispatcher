using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Dispatcher
{
    /// <summary>
    /// Логика взаимодействия для UnitsUC.xaml
    /// </summary>
    public partial class UnitsUC : UserControl
    {
        private SqlConnection sqlConnection = null;

        private SqlDataAdapter adapter = null;

        public UnitsUC()
        {
            InitializeComponent();
        }

        private void UltimateSQLSelect()
        {
            string connectionString = Properties.Settings.Default.SqlConnectionString;
            string sqlExpression = "SELECT * FROM Units";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);

                adapter = new SqlDataAdapter(sqlExpression, connectionString);
                DataTable table = new DataTable();
                adapter.Fill(table);
                UnitsDataGrid.ItemsSource = table.DefaultView;
            }
        }

        private void UltimateSQLInsert(string name)
        {
            string connectionString = Properties.Settings.Default.SqlConnectionString;
            string sqlExpression = String.Format("INSERT INTO Units (Name) VALUES ('{0}')", name);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.ExecuteNonQuery(); //Выполнение запроса без возращения данных
            }
        }

        private void UltimateSQLDelite(int id)
        {
            string connectionString = Properties.Settings.Default.SqlConnectionString;
            string sqlExpression = String.Format("DELETE FROM Units WHERE ID={0}", id);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.ExecuteNonQuery(); //Выполнение запроса без возращения данных
            }
        }

        private void UltimateSQLUpdate(int id, string name)
        {
            string connectionString = Properties.Settings.Default.SqlConnectionString;
            string sqlExpression = String.Format("UPDATE Units SET Name='{0}' WHERE ID={1}", name, id);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.ExecuteNonQuery(); //Выполнение запроса без возращения данных
            }
        }

       

        private void UnitsUC_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            UltimateSQLSelect();
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            UltimateSQLInsert(name.Text);
            UltimateSQLSelect();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            UltimateSQLDelite(Convert.ToInt32(id.Text));
            UltimateSQLSelect();
        }

        private void UpgradeButton_Click(object sender, RoutedEventArgs e)
        {
            UltimateSQLUpdate(Convert.ToInt32(id.Text), name.Text);
            UltimateSQLSelect();
        }
    }
}