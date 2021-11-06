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
using System.Windows.Shapes;

namespace Dispatcher
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        public AuthorizationWindow()
        {
            InitializeComponent();

            //Загружаем тему
            ThemeClass.MyThemeChange(Properties.Settings.Default.ThemeSettings);
        }

        public void OpenMainWindow()
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        public bool PasswordCheck(int Level, string Password)
        {
            switch (Level)
            {
                case 0:
                    return true;

                case 1:
                    return true;

                case 2:
                    if (Password == "1234")
                        return true;
                    else
                        return false;

                case 3:
                    if (Password == "12345678")
                        return true;
                    else
                        return false;

                default:
                    return false;
            }
        }

        // Нужна нормальная проверка пароля

        private void EnterButton_Click(object sender, RoutedEventArgs e)
        {
            ComboBoxItem ComboItem = (ComboBoxItem)RoleComboBox.SelectedItem;
            string Role = Convert.ToString(ComboItem.Tag);
            if (PasswordCheck(Convert.ToInt32(Role), Convert.ToString(PasswordBox.Password)))
            {
                OpenMainWindow();
            }
            else
            {
                MessageBox.Show("Неправильный пароль");
            }
        }
    }
}
