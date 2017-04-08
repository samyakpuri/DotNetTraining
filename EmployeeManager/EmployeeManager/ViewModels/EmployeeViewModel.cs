using EmployeeManager.Commands;
using EmployeeManager.DataModel;
using EmployeeManager.Mappers;
using EmployeeManager.Models;
using EmployeeManager.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManager.ViewModels
{
    class EmployeeViewModel : BaseViewModel
    {
        private IDialogService _dialogService;
        public DelegateCommand AddEmployeeCommand { get; set; }
        public EmployeeModel Employee { get; set; }

        public EmployeeViewModel(IDialogService dialogService)
        {
            _dialogService = dialogService;
            AddEmployeeCommand = new DelegateCommand(CanExecute, Execute);
        }

        private void Execute(object obj)
        {
            Employee employee = new Employee();
            EmployeeMapper.MapBack(employee, Employee);
        }

        private bool CanExecute(object obj)
        {
            return true;
        }
    }
}
