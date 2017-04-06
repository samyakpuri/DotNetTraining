using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeadStartMvvm.Models;
using HeadStartMvvm.Commands;

namespace HeadStartMvvm.ViewModels
{
    class PersonViewModel
    {
        public Person Person { get; set; }
        public AddPersonCommand AddPersonCommand { get; set; }

        public PersonViewModel()
        {
            Person = new Person();
            AddPersonCommand = new AddPersonCommand();
        }
    }
}
