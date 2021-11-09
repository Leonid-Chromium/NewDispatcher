using System;
using System.Collections.Generic;
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
    /// Логика взаимодействия для StuffStatusUC.xaml
    /// </summary>
    public partial class StuffStatusUC : UserControl
    {
        public StuffStatusUC()
        {
            InitializeComponent();
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            SQLClass.ReturnSQL(StuffStatusDataGrid, "SELECT * FROM StuffStatus");
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            SQLClass.ReturnSQL(StuffStatusDataGrid, "SELECT * FROM StuffStatus");
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            string[] valueName = {"Decoding"};
            string[] value = {"'" + decodingTB.Text + "'" };

            SQLClass.NoReturnSQL(String.Format("INSERT INTO StuffStatus({0}) VALUES ({1})", String.Join(", ", valueName), String.Join(", ", value)));
            SQLClass.ReturnSQL(StuffStatusDataGrid, "SELECT * FROM StuffStatus");
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            SQLClass.NoReturnSQL(String.Format("Delete FROM StuffStatus WHERE IDStatus=" + idStatusTB.Text));
            SQLClass.ReturnSQL(StuffStatusDataGrid, "SELECT * FROM StuffStatus");
        }

        private void UpgradeButton_Click(object sender, RoutedEventArgs e)
        {
            string[] valueName = { "Decoding" };
            string[] value = { "'" + decodingTB.Text + "'" };

            SQLClass.NoReturnSQL(String.Format("UPDATE StuffStatus SET {0} WHERE IDStatus={1}", SQLClass.ArrayToValue(valueName, value), idStatusTB.Text));
            SQLClass.ReturnSQL(StuffStatusDataGrid, "SELECT * FROM StuffStatus");
        }

        private void StuffStatusDataGrid_IsMouseCapturedChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            idStatusTB.Text = SQLClass.MyGetItemArray(StuffStatusDataGrid, 0);
            decodingTB.Text = SQLClass.MyGetItemArray(StuffStatusDataGrid, 1);
        }
    }
}
