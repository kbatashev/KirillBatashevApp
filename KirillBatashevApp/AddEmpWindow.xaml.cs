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
    /// Логика взаимодействия для AddEmpWindow.xaml
    /// </summary>
    public partial class AddEmpWindow : Window
    {
        public DataTable employeeAdd { get; set; }
        public DataTable departmentSelect { get; set; }
        public AddEmpWindow(DataTable employeeAdd, DataTable departmentSelect)
        {
            InitializeComponent();
            this.employeeAdd = employeeAdd;
            this.departmentSelect = departmentSelect;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cboxDepartment.ItemsSource = departmentSelect.DefaultView;
            
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            
            DataRow employeeRow = employeeAdd.NewRow();
            employeeRow["ID"] = (int)employeeAdd.Rows.Count + 1;
            employeeRow["eName"] = tboxName.Text;
            employeeRow["Surname"] = tboxSurname.Text;
            employeeRow["Age"] = tboxAge.Text;
            employeeRow["Salary"]=  tboxSalary.Text;
            employeeRow["DepartmentID"] = cboxDepartment.SelectedIndex + 1;
            employeeAdd.Rows.Add(employeeRow);

            this.DialogResult = true;
        }
    }
}
