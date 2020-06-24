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
    /// Логика взаимодействия для AddDepWindow.xaml
    /// </summary>
    public partial class AddDepWindow : Window
    {
        public DataRow adResultRow { get; set; }
        public AddDepWindow(DataRow adDataRow)
        {
            InitializeComponent();
            adResultRow = adDataRow;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            tboxNewDep.Text = adResultRow["dName"].ToString();
        }

        /// <summary>Обработчик нажатия кнопки "сохранить"</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSaveDep_Click(object sender, RoutedEventArgs e)
        {
            adResultRow["dName"] = tboxNewDep.Text;
            this.DialogResult = true;
        }
    }
}
