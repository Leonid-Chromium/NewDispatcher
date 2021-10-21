using System;
using System.Collections.Generic;
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
    /// Логика взаимодействия для TestDataGridUC.xaml
    /// </summary>
    public partial class TestDataGridUC : UserControl
    {
        public TestDataGridUC()
        {
            InitializeComponent();
        }


        public class TestingItem
        {
            public string qwe { get; set; }
            public string rty { get; set; }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TestDG.Items.Add(new TestingItem { qwe = "erwtye", rty = "fgh" });
            TestDG.Items.Add(new TestingItem { qwe = "Название", rty = "Значение" });
        }
    }
}
