using EmployeeManager.DataModel;
using EmployeeManager.Mappers;
using EmployeeManager.Models;
using EmployeeManager.Services;
using EmployeeManager.ViewModels;
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

namespace EmployeeManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        EmployeeManagementEntities db = new EmployeeManagementEntities();
        public List<EmployeeModel> _employees { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            LoadGrid();
            var employeeViewModel = new EmployeeViewModel(new DialogService());
            this.DataContext = employeeViewModel;
        }

        private void LoadGrid()
        {
            _employees = new List<EmployeeModel>();
            var tempEmployees = db.Employees.ToList();
            foreach (var employee in tempEmployees)
            {
                EmployeeModel emp = new EmployeeModel();
                EmployeeMapper.Map(employee, emp);
                _employees.Add(emp);    
            }
            grdEmployee.ItemsSource = _employees;
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            AddPopup.IsOpen = true;
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            AddPopup.IsOpen = false;
        }
    }
}
