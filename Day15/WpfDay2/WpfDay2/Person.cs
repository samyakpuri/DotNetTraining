

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfDay2.Model
{
    class Person : INotifyPropertyChanged
    {
        private int _id;
        private String _firstName;
        private byte _age;
        private bool _gender;
        private DateTime _dateOfBirth;
        private String _lastName;

        public int Id 
        { 
            get {return _id;} 
            set 
            {
                _id = value;
                OnPropertyChanged();
            }
        }
        public String FirstName 
        { 
            get {return _firstName;} 
            set 
            {
                _firstName = value;
                OnPropertyChanged();
            }
        }
        public String LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value;
                OnPropertyChanged();
            }
        }
        public byte Age 
        { 
            get {return _age;} 
            set 
            {
                _age = value;
                OnPropertyChanged();
            }
        }
        public bool Gender 
        { 
            get {return _gender;} 
            set 
            {
                _gender=value;
                OnPropertyChanged();
            }
        }
        public DateTime DateOfBirth 
        { 
            get {return _dateOfBirth;} 
            set 
            {
                _dateOfBirth=value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
