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
    /// Логика взаимодействия для SettingsUC.xaml
    /// </summary>
    public partial class SettingsUC : UserControl
    {
        public SettingsUC()
        {
            InitializeComponent();

            // загрузка темы
            ThemeClass.MyThemeChange(Properties.Settings.Default.ThemeSettings);
        }

        private void SetDarkSide_Click(object sender, RoutedEventArgs e)
        {
            ThemeClass.MyThemeChange("Dark");
        }

        private void SetLightSide_Click(object sender, RoutedEventArgs e)
        {
            ThemeClass.MyThemeChange("Light");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow win = (MainWindow)Window.GetWindow(this);
            win.SettingBack();
        }
    }
}
