using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmDay2.Models;

namespace MvvmDay2.ViewModels
{
    class MainViewModel
    {
        public Header Header { get; set; }
        public Person Person { get; set; }

        public MainViewModel()
        {
            Header = new Header() { Title = "Hello World", Url = new Uri("../Images/logo.png",UriKind.Relative) };
            Person = new Person() { Name = "Samyak Puri", Gender = true, Id = 1};
        }
    }
}
