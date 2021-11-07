using System;
using System.Collections.Generic;
using System.Data;
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
    /// Логика взаимодействия для StuffsUC.xaml
    /// </summary>
    public partial class StuffsUC : UserControl
    {
        public StuffsUC()
        {
            InitializeComponent();
        }
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void StuffsUC_Loaded(object sender, RoutedEventArgs e)
        {
            SQLClass.ReturnSQL(StuffsDataGrid, "SELECT IDStuff ,IDDistrict, FirstName, MiddleName, LastName, PersonnelNumber, Birthday, Education, ResidenceAddress, WorkPhoneNumber, PersonalPhoneNumber, Status, Note FROM Stuffs");
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            SQLClass.ReturnSQL(StuffsDataGrid, "SELECT IDStuff ,IDDistrict, FirstName, MiddleName, LastName, PersonnelNumber, Birthday, Education, ResidenceAddress, WorkPhoneNumber, PersonalPhoneNumber, Status, Note FROM Stuffs");
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            string[] valueName = { "IDDistrict", "FirstName", "MiddleName", "LastName", "PersonnelNumber", "Birthday", "Education", "ResidenceAddress", "WorkPhoneNumber", "PersonalPhoneNumber", "Status", "Note" };
            string[] value = { IDDistrictTB.Text, "'" + FirstNameTB.Text + "'", "'" + MiddleNameTB.Text + "'", "'" + LastNameTB.Text + "'", PersonnelNumberTB.Text, "'" + BirthdayDP.Text + "'", "'" + EducationTB.Text + "'", "'" + ResidenceAddressTB.Text + "'", WorkPhoneNumberTB.Text, PersonalPhoneNumberTB.Text, statusTB.Text, "'" + NoteTB.Text + "'" };
            SQLClass.NoReturnSQL(String.Format("INSERT INTO Stuffs SET {0}", SQLClass.ArrayToValue(valueName, value)));
            SQLClass.ReturnSQL(StuffsDataGrid, "SELECT IDStuff ,IDDistrict, FirstName, MiddleName, LastName, PersonnelNumber, Birthday, Education, ResidenceAddress, WorkPhoneNumber, PersonalPhoneNumber, Status, Note FROM Stuffs");
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            //SQLClass.ReturnSQL(StuffsDataGrid, "SELECT IDStuff ,IDDistrict, FirstName, MiddleName, LastName, PersonnelNumber, Birthday, Education, ResidenceAddress, WorkPhoneNumber, PersonalPhoneNumber, Status, Note FROM Stuffs");
        }

        private void UpgradeButton_Click(object sender, RoutedEventArgs e)
        {
            //SQLClass.ReturnSQL(StuffsDataGrid, "SELECT IDStuff ,IDDistrict, FirstName, MiddleName, LastName, PersonnelNumber, Birthday, Education, ResidenceAddress, WorkPhoneNumber, PersonalPhoneNumber, Status, Note FROM Stuffs");
        }

        private void UnitsDataGrid_IsMouseCapturedChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            idStuffTB.Text = SQLClass.MyGetItemArray(StuffsDataGrid, 0);
            IDDistrictTB.Text = SQLClass.MyGetItemArray(StuffsDataGrid, 1);
            FirstNameTB.Text = SQLClass.MyGetItemArray(StuffsDataGrid, 2);
            MiddleNameTB.Text = SQLClass.MyGetItemArray(StuffsDataGrid, 3);
            LastNameTB.Text = SQLClass.MyGetItemArray(StuffsDataGrid, 4);
            PersonnelNumberTB.Text = SQLClass.MyGetItemArray(StuffsDataGrid, 5);
            BirthdayDP.Text = SQLClass.MyGetItemArray(StuffsDataGrid, 6);
            EducationTB.Text = SQLClass.MyGetItemArray(StuffsDataGrid, 7);
            ResidenceAddressTB.Text = SQLClass.MyGetItemArray(StuffsDataGrid, 8);
            WorkPhoneNumberTB.Text = SQLClass.MyGetItemArray(StuffsDataGrid, 9);
            PersonalPhoneNumberTB.Text = SQLClass.MyGetItemArray(StuffsDataGrid, 10);
            statusTB.Text = SQLClass.MyGetItemArray(StuffsDataGrid, 11);
            NoteTB.Text = SQLClass.MyGetItemArray(StuffsDataGrid, 12);
        }
    }
}
