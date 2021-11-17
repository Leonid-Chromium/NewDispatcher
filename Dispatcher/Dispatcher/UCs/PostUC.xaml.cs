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
    /// Логика взаимодействия для PostUC.xaml
    /// </summary>
    public partial class PostUC : UserControl
    {
        public PostUC()
        {
            InitializeComponent();
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void PostUC_Loaded(object sender, RoutedEventArgs e)
        {
            SQLClass.ReturnSQL(PostDataGrid, "SELECT * FROM Post");
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            SQLClass.ReturnSQL(PostDataGrid, "SELECT * FROM Post");
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            string[] valueName = { "Name" };
            string[] value = { "'" + nameTB.Text + "'" };

            SQLClass.NoReturnSQL(String.Format("INSERT INTO Post({0}) VALUES ({1})", String.Join(", ", valueName), String.Join(", ", value)));
            SQLClass.ReturnSQL(PostDataGrid, "SELECT * FROM Post");
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            SQLClass.NoReturnSQL(String.Format("Delete FROM Post WHERE IDPost=" + idPostTB.Text));
            SQLClass.ReturnSQL(PostDataGrid, "SELECT * FROM Post");
        }

        private void UpgradeButton_Click(object sender, RoutedEventArgs e)
        {
            string[] valueName = { "Name" };
            string[] value = { "'" + nameTB.Text + "'" };

            SQLClass.NoReturnSQL(String.Format("UPDATE Post SET {0} WHERE IDPost={1}", SQLClass.ArrayToValue(valueName, value), idPostTB.Text));
            SQLClass.ReturnSQL(PostDataGrid, "SELECT * FROM Post");
        }

        private void PostDataGrid_IsMouseCapturedChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            idPostTB.Text = SQLClass.MyGetItemArray(PostDataGrid, 0);
            nameTB.Text = SQLClass.MyGetItemArray(PostDataGrid, 1);
        }
    }
}
