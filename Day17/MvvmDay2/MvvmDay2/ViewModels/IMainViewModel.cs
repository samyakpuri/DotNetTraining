using MvvmDay2.Commands;
using MvvmDay2.Models;
using System;
namespace MvvmDay2.ViewModels
{
    interface IMainViewModel
    {
        DelegateCommand AddPersonCommand { get; set; }
        Header Header { get; set; }
        Person Person { get; set; }
    }
}
