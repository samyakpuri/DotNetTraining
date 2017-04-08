using EmployeeManager.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManager.ViewModels
{
    class BaseViewModel : ObservableObject, IDataErrorInfo
    {
        public string Error { get; private set; }

        public string this[string columnName]
        {
            get { return null; }
        }
    }
}
