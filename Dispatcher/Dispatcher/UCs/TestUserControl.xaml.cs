using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
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
    /// Логика взаимодействия для TestUserControl.xaml
    /// </summary>
    public partial class TestUserControl : UserControl
    {
        public TestUserControl()
        {
            InitializeComponent();
        }

        private void TestButton_Click(object sender, RoutedEventArgs e)
        {
            string[] valueName = { "qwe", "asd" };
            string[] name = { "rty", "fgh" };
            SQLClass.ArrayToValue(valueName, name);
        }

        private void UpdateItems()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Properties.Settings.Default.SqlConnectionString))
                {
                    con.Open();
                    SqlDataAdapter ProjectTableTableAdapter = new SqlDataAdapter("SELECT Decoding FROM Roles", con);
                    DataSet dataSet = new DataSet();
                    ProjectTableTableAdapter.Fill(dataSet, "scrTable");

                    Trace.WriteLine(dataSet.Tables.Count);
                    //Trace.WriteLine(dataSet.Tables["scrTable"].Rows.);

                    TestRoleComboBox.ItemsSource = dataSet.Tables["scrTable"].DefaultView;
                    //TestRoleComboBox.DisplayMemberPath = "ProjectName";
                    //TestRoleComboBox.SelectedValuePath = "RFIDirectory";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            UpdateItems();
        }

        private void QueryButton_Click(object sender, RoutedEventArgs e)
        {
            SQLClass.ReturnSQL(QueryDG, QueryTB.Text);
        }

        private void CButton_Click(object sender, RoutedEventArgs e)
        {
            OutTB.Text = Convert.ToString(SQLClass.GetCollumnCount("Units"));
        }

        public ObservableCollection<Field> Fields { get; set; }

        public class Field
        {
            public string Name { get; set; }
            public int Length { get; set; }
            public bool Required { get; set; }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Fields = new ObservableCollection<Field>();
            Fields.Add(new Field() { Name = "Username", Length = 100, Required = true });
            Fields.Add(new Field() { Name = "Password", Length = 80, Required = true });
            Fields.Add(new Field() { Name = "City", Length = 100, Required = false });
            Fields.Add(new Field() { Name = "State", Length = 40, Required = false });
            Fields.Add(new Field() { Name = "Zipcode", Length = 60, Required = false });

            FieldsListBox.ItemsSource = Fields;
        }
    }

    
}
