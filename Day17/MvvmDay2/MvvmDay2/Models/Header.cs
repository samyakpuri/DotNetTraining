using MvvmDay2.Farmework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmDay2.Models
{
    class Header : ObservableObject
    {
        private Uri _url;
        private String _title;

        public Uri Url 
        {
            get { return _url; }
            set 
            { 
                _url = value;
                OnPropertyChanged();
            }
        }

        public String Title 
        {
            get { return _title; }
            set 
            { 
                _title = value;
                OnPropertyChanged();
            }
        }
    }
}
