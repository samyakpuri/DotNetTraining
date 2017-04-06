using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeadStartMvvm.Models;

namespace HeadStartMvvm.ViewModels
{
    class PersonViewModel
    {
        public Person Person { get; set; }

        public PersonViewModel()
        {
            Person = new Person();
        }
    }
}
