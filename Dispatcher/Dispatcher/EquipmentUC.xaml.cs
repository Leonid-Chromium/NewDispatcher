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
    /// Логика взаимодействия для EquipmentUC.xaml
    /// </summary>
    public partial class EquipmentUC : UserControl
    {
        public EquipmentUC()
        {
            InitializeComponent();
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void EquipmentsUC_Loaded(object sender, RoutedEventArgs e)
        {
            SQLClass.ReturnSQL(DataGrid, "SELECT * FROM Equipments");
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            SQLClass.ReturnSQL(DataGrid, "SELECT * FROM Equipments");
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            string[] valueName = { "InventoryNumber", "Name", "Destiny", "Room", "District", "Status", "Routing", "CertificationPeriod", "Capacity", "Lenght", "Width", "Height", "Weight" };
            string[] value = {"'" + inventoryNumberTB.Text + "'", "'" + nameTB.Text + "'", "'" + destinyTB.Text + "'", "'" + roomTB.Text + "'", "'" + districtTB.Text + "'", "'" + statusTB.Text + "'", "'" + routingTB.Text +"'", "'" + certificationPeriodTB.Text + "'", "'" + capacityTB.Text + "'", "'" + lenghtTB.Text + "'", "'" + widthTB.Text + "'", "'" + heightTB.Text + "'", "'" + weightTB.Text + "'"};

            //string[] value = { keyBatchTB.Text, idDeviceTB.Text, priorityTB.Text, startCountTB.Text, lastCountTB.Text };

            SQLClass.NoReturnSQL(String.Format("INSERT INTO Equipments({0}) VALUES ({1})", String.Join(", ", valueName), String.Join(", ", value)));
            SQLClass.ReturnSQL(DataGrid, "SELECT * FROM Equipments");
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            SQLClass.NoReturnSQL(String.Format("Delete FROM Equipments WHERE IDEquipment=" + idEquipmentTB.Text));
            SQLClass.ReturnSQL(DataGrid, "SELECT * FROM Equipments");
        }

        private void UpgradeButton_Click(object sender, RoutedEventArgs e)
        {
            string[] valueName = { "InventoryNumber", "Name", "Destiny", "Room", "District", "Status", "Routing", "CertificationPeriod", "Capacity", "Lenght", "Width", "Height", "Weight" };
            string[] value = { "'" + inventoryNumberTB.Text + "'", "'" + nameTB.Text + "'", "'" + destinyTB.Text + "'", "'" + roomTB.Text + "'", "'" + districtTB.Text + "'", "'" + statusTB.Text + "'", "'" + routingTB.Text + "'", "'" + certificationPeriodTB.Text + "'", "'" + capacityTB.Text + "'", "'" + lenghtTB.Text + "'", "'" + widthTB.Text + "'", "'" + heightTB.Text + "'", "'" + weightTB.Text + "'" };

            SQLClass.NoReturnSQL(String.Format("UPDATE Equipments SET {0} WHERE IDEquipment={1}", SQLClass.ArrayToValue(valueName, value), idEquipmentTB.Text));
            SQLClass.ReturnSQL(DataGrid, "SELECT * FROM Equipments");
        }

        private void DataGrid_IsMouseCapturedChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            idEquipmentTB.Text = SQLClass.MyGetItemArray(DataGrid, 0);
            inventoryNumberTB.Text = SQLClass.MyGetItemArray(DataGrid, 1);
            nameTB.Text = SQLClass.MyGetItemArray(DataGrid, 2);
            destinyTB.Text = SQLClass.MyGetItemArray(DataGrid, 3);
            roomTB.Text = SQLClass.MyGetItemArray(DataGrid, 4);
            districtTB.Text = SQLClass.MyGetItemArray(DataGrid, 5);
            statusTB.Text = SQLClass.MyGetItemArray(DataGrid, 6);
            routingTB.Text = SQLClass.MyGetItemArray(DataGrid, 7);
            certificationPeriodTB.Text = SQLClass.MyGetItemArray(DataGrid, 8);
            capacityTB.Text = SQLClass.MyGetItemArray(DataGrid, 8);
            lenghtTB.Text = SQLClass.MyGetItemArray(DataGrid, 8); 
            widthTB.Text = SQLClass.MyGetItemArray(DataGrid, 8);
            heightTB.Text = SQLClass.MyGetItemArray(DataGrid, 8);
            weightTB.Text = SQLClass.MyGetItemArray(DataGrid, 8);
        }
    }
}
