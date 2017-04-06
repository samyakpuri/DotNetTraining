using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfDay2.Model;

namespace WpfDay2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Person> _persons;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _persons = new ObservableCollection<Person>
            {
                new Person {Id=1,FirstName = "Poonam",LastName = "Siwach",Age=23,Gender=false,DateOfBirth=DateTime.Now.AddYears(-23).AddDays(2).AddMonths(3)},
                new Person {Id=1,FirstName = "Samyak",LastName = "Puri",Age=33,Gender=true,DateOfBirth=DateTime.Now.AddYears(-33).AddDays(-2).AddMonths(-3)},
                new Person {Id=1,FirstName = "Jatin",LastName = "Katoch",Age=43,Gender=true,DateOfBirth=DateTime.Now.AddYears(-43).AddDays(6)},
                new Person {Id=1,FirstName = "Deepti",LastName = "Divya",Age=23,Gender=false,DateOfBirth=DateTime.Now.AddYears(-23).AddDays(6).AddMonths(2)}
            };

            grdDataOne.ItemsSource = _persons;
            grdDataTwo.ItemsSource = _persons;
        }

        //private void btnChange_Click(object sender, RoutedEventArgs e)
        //{
        //    if(_persons.FirstOrDefault().Name == "Changed Name")
        //    {
        //        _persons.FirstOrDefault().Name = "Sam";
        //        _persons.RemoveAt(3);
        //    }
        //    else
        //    {
        //        _persons.FirstOrDefault().Name = "Changed Name";
        //        _persons.Add(new Person { Id = 4, Name = "Samm", Age = 53, Gender = true, DateOfBirth = DateTime.Now.AddYears(-53).AddDays(55).AddMonths(-6) });
        //    }
        //}
    }
}
