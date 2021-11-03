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

        public void Update()
        {
            sqlConnection = new SqlConnection(@"Data Source=DESKTOP-LEONID\SQLEXPRESS;Initial Catalog=Dispatcher;Integrated Security=True");

            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "SELECT * FROM Units";

            adapter = new SqlDataAdapter(sqlCommand.CommandText, sqlConnection);

            DataTable table = new DataTable();

            adapter.Fill(table);
            UnitsDataGrid.ItemsSource = table.DefaultView;
        }

        private void UnitsUC_Loaded(object sender, RoutedEventArgs e)
        {
            Update();
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            Update();
        }
    }
}