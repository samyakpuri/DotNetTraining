using System;
using System.Collections.Generic;
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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            List<Person> persons = new List<Person> 
            {
                new Person {Id=1,Name = "Sam",Age=23,Gender=true,DateOfBirth=DateTime.Now.AddYears(-23).AddDays(2).AddMonths(3)},
                new Person {Id=1,Name = "Samyak",Age=33,Gender=true,DateOfBirth=DateTime.Now.AddYears(-33).AddDays(-2).AddMonths(-3)},
                new Person {Id=1,Name = "Sammy",Age=43,Gender=true,DateOfBirth=DateTime.Now.AddYears(-43).AddDays(6)}
            };

            grdDataOne.ItemsSource = persons;
            grdDataTwo.ItemsSource = persons;
        }
    }
}
