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
    /// Логика взаимодействия для BatchUC.xaml
    /// </summary>
    public partial class BatchUC : UserControl
    {
        public BatchUC()
        {
            InitializeComponent();
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void BatchUC_Loaded(object sender, RoutedEventArgs e)
        {
            SQLClass.ReturnSQL(DataGrid, "SELECT * FROM Batchs");
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            SQLClass.ReturnSQL(DataGrid, "SELECT * FROM Batchs");
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            string[] valueName = { "KeyBatch", "IDDevice", "Priority", "StartCount", "lastCount" };
            string[] value = {"'" + keyBatchTB.Text + "'", "'" + idDeviceTB.Text + "'", "'" + priorityTB.Text + "'", "'" + startCountTB.Text + "'", "'" + lastCountTB.Text + "'" };

            //string[] value = { keyBatchTB.Text, idDeviceTB.Text, priorityTB.Text, startCountTB.Text, lastCountTB.Text };

            SQLClass.NoReturnSQL(String.Format("INSERT INTO Batchs({0}) VALUES ({1})", String.Join(", ", valueName), String.Join(", ", value)));
            SQLClass.ReturnSQL(DataGrid, "SELECT * FROM Batchs");
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            SQLClass.NoReturnSQL(String.Format("Delete FROM Batchs WHERE IDBatch=" + idBatch.Text));
            SQLClass.ReturnSQL(DataGrid, "SELECT * FROM Batchs");
        }

        private void UpgradeButton_Click(object sender, RoutedEventArgs e)
        {
            string[] valueName = { "KeyBatch", "IDDevice", "Priority", "StartCount", "lastCount" };
            string[] value = {  keyBatchTB.Text, idDeviceTB.Text, priorityTB.Text, startCountTB.Text, lastCountTB.Text };

            SQLClass.NoReturnSQL(String.Format("UPDATE Batchs SET {0} WHERE IDBatch={1}", SQLClass.ArrayToValue(valueName, value), idBatch.Text));
            SQLClass.ReturnSQL(DataGrid, "SELECT * FROM Batchs");
        }

        private void DataGrid_IsMouseCapturedChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            idBatch.Text = SQLClass.MyGetItemArray(DataGrid, 0);
            keyBatchTB.Text = SQLClass.MyGetItemArray(DataGrid, 1);
            idDeviceTB.Text = SQLClass.MyGetItemArray(DataGrid, 2);
            priorityTB.Text = SQLClass.MyGetItemArray(DataGrid, 3);
            startCountTB.Text = SQLClass.MyGetItemArray(DataGrid, 4);
            lastCountTB.Text = SQLClass.MyGetItemArray(DataGrid, 5);
        }
    }
}
