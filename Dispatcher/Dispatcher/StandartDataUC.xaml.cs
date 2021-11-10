using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Логика взаимодействия для StandartDataUC.xaml
    /// </summary>
    public partial class StandartDataUC : UserControl
    {
        public StandartDataUC()
        {
            InitializeComponent();
        }

        public string DataTable { get; set; }

        public string valueName { get; set; }
        public string value { get; set; }
        //надо сделать обработку массива 

        public ObservableCollection<Field> Fields { get; set; }
        public class Field
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        //public static void AddFiuld()
        //{
        //    Fields = new ObservableCollection<Field>();
        //    for(int i = 0; i>SQLClass.GetCollumnCount("Units"); i++)
        //    {
        //        Fields.Add(new Field() { name = "Имя" });
        //    }
        //    FieldsListBox.ItemsSource = Fields;
        //}

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Fields = new ObservableCollection<Field>();
            for (int i = 0; i < SQLClass.GetCollumnCount("Units"); i++)
            {
                Fields.Add(new Field() { name = String.Format("Поле №" + (i+1)), value = "25"});
            }

            FieldsListBox.ItemsSource = Fields;
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void PostUC_Loaded(object sender, RoutedEventArgs e)
        {
            SQLClass.ReturnSQL(DataGrid, String.Format("SELECT * FROM {0}", DataTable));
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            SQLClass.ReturnSQL(DataGrid, String.Format("SELECT * FROM {0}", DataTable));
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            string[] valueName = { "Name" };
            string[] value = { "'" + SecondTB.Text + "'" };

            SQLClass.NoReturnSQL(String.Format("INSERT INTO {0}({1}) VALUES ({2})", DataTable, String.Join(", ", valueName), String.Join(", ", value)));
            SQLClass.ReturnSQL(DataGrid, String.Format("SELECT * FROM {0}", DataTable));
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            SQLClass.NoReturnSQL(String.Format("Delete FROM {0} WHERE IDPost={1}",DataTable ,FirstTB.Text));
            SQLClass.ReturnSQL(DataGrid, String.Format("SELECT * FROM {0}", DataTable));
        }

        private void UpgradeButton_Click(object sender, RoutedEventArgs e)
        {
            string[] valueName = { "Name" };
            string[] value = { "'" + FirstTB.Text + "'" };

            SQLClass.NoReturnSQL(String.Format("UPDATE {0} SET {1} WHERE IDPost={2}", DataTable, SQLClass.ArrayToValue(valueName, value), FirstTB.Text));
            SQLClass.ReturnSQL(DataGrid, String.Format("SELECT * FROM {0}", DataTable));
        }

        private void DataGrid_IsMouseCapturedChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            FirstTB.Text = SQLClass.MyGetItemArray(DataGrid, 0);
            SecondTB.Text = SQLClass.MyGetItemArray(DataGrid, 1);
        }
    }
}
