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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public static int role{get; set;}

        public void SetRole(int newRole)
        {
            role = newRole;
            UseRole();
        }

        private void UseRole()
        {
            if(role < 3)
            {
                TabSpace.TabTest.Visibility = Visibility.Collapsed;

                if(role < 2)
                {
                    TabSpace.TabEditors.Visibility = Visibility.Collapsed;
                    TabSpace.TabStore.Visibility = Visibility.Collapsed;
                    TabSpace.TabDistrict.Visibility = Visibility.Collapsed;
                    TabSpace.TabStuff.Visibility = Visibility.Collapsed;
                    if (role == 0)
                        TabSpace.TabEquipment.Visibility = Visibility.Collapsed;
                    else
                    {
                        TabSpace.TabBatch.Visibility = Visibility.Collapsed;
                        TabSpace.TabControlFirstLevel.SelectedItem = TabSpace.TabEquipment;
                    }
                }
            }
        }

        private void SettingsButton_Click(object sender, RoutedEventArgs e)
        {
            WorkSpace.Visibility = Visibility.Collapsed;
            Settings.Visibility = Visibility.Visible;
        }

        public void SettingBack()
        {
            Settings.Visibility = Visibility.Collapsed;
            WorkSpace.Visibility = Visibility.Visible;
        }
    }
}
