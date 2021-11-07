using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        public UnitsUC()
        {
            InitializeComponent();
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void UnitsUC_Loaded(object sender, RoutedEventArgs e)
        {
            SQLClass.UltimateSQLSelect(UnitsDataGrid, "Units");
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            SQLClass.UltimateSQLSelect(UnitsDataGrid, "Units");
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            SQLClass.UltimateSQLInsert("Units", name.Text);
            SQLClass.UltimateSQLSelect(UnitsDataGrid, "Units");
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            SQLClass.UltimateSQLDelite("Units", Convert.ToInt32(id.Text));
            SQLClass.UltimateSQLSelect(UnitsDataGrid, "Units");
        }

        private void UpgradeButton_Click(object sender, RoutedEventArgs e)
        {
            SQLClass.UltimateSQLUpdate("Units", Convert.ToInt32(id.Text), name.Text);
            SQLClass.UltimateSQLSelect(UnitsDataGrid, "Units");
        }

        private void UnitsDataGrid_IsMouseCapturedChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            id.Text = SQLClass.MyGetItemArray(UnitsDataGrid, 0);
            name.Text = SQLClass.MyGetItemArray(UnitsDataGrid, 1);
        }
    }
}