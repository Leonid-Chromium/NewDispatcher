using System;
using System.Collections.Generic;
using System.Data;
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
    /// Логика взаимодействия для StuffsUC.xaml
    /// </summary>
    public partial class StuffsUC : UserControl
    {
        public StuffsUC()
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
            SQLClass.UltimateSQLSelect(StuffsDataGrid, "Stuffs");
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            SQLClass.UltimateSQLSelect(StuffsDataGrid, "Stuffs");
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            SQLClass.UltimateSQLInsert("Stuffs", string.Join(", ", IDDistrict.Text, FirstName.Text));
            SQLClass.UltimateSQLSelect(StuffsDataGrid, "Units");
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            SQLClass.UltimateSQLDelite("Stuffs", Convert.ToInt32(id.Text));
            SQLClass.UltimateSQLSelect(StuffsDataGrid, "Units");
        }

        private void UpgradeButton_Click(object sender, RoutedEventArgs e)
        {
            SQLClass.UltimateSQLUpdate("Stuffs", Convert.ToInt32(id.Text), FirstName.Text);
            SQLClass.UltimateSQLSelect(StuffsDataGrid, "Stuffs");
        }

        private object[] MyGetArray(DataGrid dataGrid)
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

        private string MyGetItemArray(int i)
        {
            try
            {
                object[] array = MyGetArray(StuffsDataGrid);
                return array[i].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private void UnitsDataGrid_IsMouseCapturedChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            id.Text = MyGetItemArray(0);
            FirstName.Text = MyGetItemArray(1);
        }
    }
}
