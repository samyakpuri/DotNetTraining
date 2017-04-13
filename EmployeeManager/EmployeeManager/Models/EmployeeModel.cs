using EmployeeManager.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManager.Models
{
    public class EmployeeModel : ObservableObject, IDataErrorInfo
    {
        #region PrivateMembers
        private int _employeeId;
        private string _name;
        private string _contactNo;
        //private string _address;
        private string _email;
        //private string _designation;
        private string _gender;
        private System.DateTime _dOB;
        //private String _project;
        //private String _department;
        private string _salary;
        //private System.DateTime _createDate;
        //private System.DateTime _lastUpdated; 
        #endregion


        #region PublicProperties
        public int EmployeeId
        {
            get { return _employeeId; }
            set
            {
                _employeeId = value;
                OnPropertyChanged();
            }
        }
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }
        public string ContactNo
        {
            get { return _contactNo; }
            set
            {
                _contactNo = value;
                OnPropertyChanged();
            }
        }
        //public string Address 
        //{ 
        //    get { return _address; } 
        //    set 
        //    { 
        //        _address = value;
        //        OnPropertyChanged(); 
        //    }
        //}
        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                OnPropertyChanged();
            }
        }
        //public string Designation 
        //{ 
        //    get { return _designation; } 
        //    set 
        //    { 
        //        _designation = value;
        //        OnPropertyChanged(); 
        //    }
        //}
        public string Gender
        {
            get { return _gender; }
            set
            {
                _gender = value;
                OnPropertyChanged();
            }
        }
        public System.DateTime DOB
        {
            get { return _dOB; }
            set
            {
                _dOB = value;
                OnPropertyChanged();
            }
        }
        //public String Project 
        //{ 
        //    get { return _project; } 
        //    set 
        //    { 
        //        _project = value;
        //        OnPropertyChanged(); 
        //    }
        //}
        //public String Department 
        //{ 
        //    get { return _department; } 
        //    set 
        //    { 
        //        _department = value;
        //        OnPropertyChanged(); 
        //    }
        //}
        public string Salary
        {
            get { return _salary; }
            set
            {
                _salary = value;
                OnPropertyChanged();
            }
        }
        //public System.DateTime CreateDate 
        //{ 
        //    get { return _createDate; } 
        //    set 
        //    { 
        //        _createDate = value;
        //        OnPropertyChanged(); 
        //    }
        //}
        //public System.DateTime LastUpdated 
        //{ 
        //    get { return _lastUpdated; } 
        //    set 
        //    { 
        //        _lastUpdated = value;
        //        OnPropertyChanged(); 
        //    }
        //} 
        #endregion

        public string Error
        {
            get;
            private set;
        }

        public string this[string columnName]
        {
            get
            {
                switch (columnName)
                {
                    case "Name":
                        if (String.IsNullOrEmpty(Name))
                            return "Field is Mandatory";
                        break;
                    case "ContactNo":
                        if (String.IsNullOrEmpty(ContactNo))
                            return "Field is Mandatory";
                        break;
                    case "Email":
                        if (String.IsNullOrEmpty(Email))
                            return "Field is Mandatory";
                        break;
                    case "Gender":
                        if (String.IsNullOrEmpty(Gender))
                            return "Field is Mandatory";
                        break;
                    case "Salary":
                        if (String.IsNullOrEmpty(Salary))
                            return "Field is Mandatory";
                        break;
                    default: return null;
                }
                return String.Empty;
                
            }
        }
    }
}
