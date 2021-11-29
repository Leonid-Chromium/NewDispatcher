using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace Dispatcher.UCs
{
    /// <summary>
    /// Логика взаимодействия для UniversalDataGrid.xaml
    /// </summary>
    public partial class UniversalDataGrid : UserControl
    {
        public string sqlTable { get; set; }

        public string[] valueName { get; set; }
        public string[] value { get; set; }

        string idint;

        public UniversalDataGrid()
        {
            InitializeComponent();
        }

        private void dataGrid_IsMouseCapturedChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            Trace.WriteLine("dataGrid_IsMouseCapturedChanged");
        }

        private void dataGrid_BeginningEdit(object sender, DataGridBeginningEditEventArgs e)
        {
            Trace.WriteLine("dataGrid_BeginningEdit");
            idint = SQLClass.MyGetItemArray(dataGrid, 0);
            Trace.WriteLine(idint);
        }

        private void dataGrid_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            Trace.WriteLine("dataGrid_CellEditEnding");
        }

        private void dataGrid_PreparingCellForEdit(object sender, DataGridPreparingCellForEditEventArgs e)
        {
            Trace.WriteLine("dataGrid_PreparingCellForEdit");
        }

        private void dataGrid_RowEditEnding(object sender, DataGridRowEditEndingEventArgs e)
        {
            Trace.WriteLine("dataGrid_RowEditEnding");
            SQLClass.NoReturnSQL(String.Format("INSERT INTO Batchs({0}) VALUES ({1})", String.Join(", ", valueName), String.Join(", ", value)));
        }

        private void dataGrid_Loaded(object sender, RoutedEventArgs e)
        {

            Trace.WriteLine("Сейчас будет боль");
            Trace.WriteLine(sqlTable);

            Trace.WriteLine(String.Format("valueName = ", String.Join(", ", valueName)));

            SQLClass.ReturnSQL(dataGrid, String.Format("SELECT " + String.Join(", ", valueName) + " From " + sqlTable));
        }

        private void dataGrid_AddingNewItem(object sender, AddingNewItemEventArgs e)
        {

            Trace.WriteLine("dataGrid_AddingNewItem");
        }

        private void dataGrid_InitializingNewItem(object sender, InitializingNewItemEventArgs e)
        {

            Trace.WriteLine("dataGrid_InitializingNewItem");
        }
    }
}
