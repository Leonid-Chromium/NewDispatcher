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
    /// Логика взаимодействия для UnitsUC.xaml
    /// </summary>
    public partial class UnitsUC : UserControl
    {
        DispatcherEntities DataEntities = new DispatcherEntities();

        public UnitsUC()
        {
            InitializeComponent();
        }

        public void Update()
        {
            var query =
            from Units in DataEntities.Units
            orderby Units.ID
            select new { Units.ID, Units.Name };

            UnitsDataGrid.ItemsSource = query.ToList();
        }

        private void UnitsUC_Loaded(object sender, RoutedEventArgs e)
        {
            Update();
        }

        private void Upgrade_Click(object sender, RoutedEventArgs e)
        {
            Update();
        }
    }
}
