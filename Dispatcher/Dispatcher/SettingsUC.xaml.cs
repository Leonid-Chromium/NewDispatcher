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

        Grid ActualSettingsSpace;

        private void SettingsSpaceControle(Grid grid)
        {
            if(grid == ActualSettingsSpace && ActualSettingsSpace.Visibility != Visibility.Collapsed)
            {
                grid.Visibility = Visibility.Collapsed;
            }
            else
            {
                if(ActualSettingsSpace != null)
                    ActualSettingsSpace.Visibility = Visibility.Collapsed;
                grid.Visibility = Visibility.Visible;
            }
            ActualSettingsSpace = grid;
        }

        private void ThemeButton_Click(object sender, RoutedEventArgs e)
        {
            SettingsSpaceControle(Themes);
        }

        private void StyleButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SetBusiness_Click(object sender, RoutedEventArgs e)
        {
            ThemeClass.MyThemeChange("Business");
        }

        private void SetAzalea_Click(object sender, RoutedEventArgs e)
        {
            ThemeClass.MyThemeChange("Azalea");
        }

        private void SetBananaGrape_Click(object sender, RoutedEventArgs e)
        {
            ThemeClass.MyThemeChange("BananaGrape");
        }

        private void SetHotLava_Click(object sender, RoutedEventArgs e)
        {
            ThemeClass.MyThemeChange("HotLava");
        }

        private void SetInvigoratingCoffee_Click(object sender, RoutedEventArgs e)
        {
            ThemeClass.MyThemeChange("InvigoratingCoffee");
        }

        private void SetLawn_Click(object sender, RoutedEventArgs e)
        {
            ThemeClass.MyThemeChange("Lawn");
        }

        private void SetSeaBreeze_Click(object sender, RoutedEventArgs e)
        {
            ThemeClass.MyThemeChange("SeaBreeze");
        }

        private void SetStarSky_Click(object sender, RoutedEventArgs e)
        {
            ThemeClass.MyThemeChange("StarSky");
        }

        private void SetSunnyBeach_Click(object sender, RoutedEventArgs e)
        {
            ThemeClass.MyThemeChange("SunnyBeach");
        }
    }
}
