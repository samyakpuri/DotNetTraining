using MvvmDay2.Farmework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmDay2.ViewModels
{
    abstract class BaseViewModel : ObservableObject, IDataErrorInfo
    {
        public string Error { get; private set; }
       
        public virtual string this[string columnName]
        {
            get { return null; }
        }
    }
}
