using System;
using System.Collections.Generic;
using System.Data;
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


namespace KirillBatashevApp
{
    /// <summary>
    /// Логика взаимодействия для EmpEditWindow.xaml
    /// </summary>
    public partial class EmpEditWindow : Window
    {
        public DataRow eresultRow { get; set; }
        public DataTable department { get; set; }
        public EmpEditWindow(DataRow edataRow, DataTable department)
        {
            InitializeComponent();
            eresultRow = edataRow;
            this.department = department;

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            tboxName.Text = eresultRow["eName"].ToString();
            tboxSurname.Text = eresultRow["Surname"].ToString();
            tboxAge.Text = eresultRow["Age"].ToString();
            tboxSalary.Text = eresultRow["Salary"].ToString();
            cboxDepartment.ItemsSource = department.DefaultView;
            
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            eresultRow["eName"] = tboxName.Text;
            eresultRow["Surname"] = tboxSurname.Text;
            eresultRow["Age"] = tboxAge.Text;
            eresultRow["Salary"] = tboxSalary.Text;
            

            this.DialogResult = true;

        }

        private void cboxDepartment_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
        }
    }
}
