using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmDay2.Models;
using MvvmDay2.Commands;
using System.Windows;
using MvvmDay2.Services;

namespace MvvmDay2.ViewModels
{
    class MainViewModel : BaseViewModel, IMainViewModel
    {
        private IDialogService _dialogService;
        public Header Header { get; set; }
        public Person Person { get; set; }
        public DelegateCommand AddPersonCommand { get; set; }

        public MainViewModel(IDialogService dialogService)
        {
            _dialogService = dialogService;
            Header = new Header() { Title = "Hello World", Url = new Uri("../Images/logo.png",UriKind.Relative) };
            Person = new Person() { Name = "Samyak Puri", Gender = true, Id = 1, DateOfBirth = DateTime.Now.AddYears(-23)};
            AddPersonCommand = new DelegateCommand(CanExecute,Execute);
        }

        private void Execute(object obj)
        {
            Person.Name = _dialogService.ShowDialog();
            _dialogService.Show("Saved");
        }

        private bool CanExecute(object obj)
        {
            return true;
        }
    }
}
