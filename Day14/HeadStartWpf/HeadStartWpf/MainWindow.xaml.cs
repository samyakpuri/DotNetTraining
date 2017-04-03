using HeadStartWpf.Model;
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

namespace HeadStartWpf
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(txtTest.Text);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //List<int> source = new List<int> { 1, 2, 3, 4 };
            //lstTest.ItemsSource = source;
            //cmbTest.ItemsSource = source;

            List<Person> persons = new List<Person> 
            {
                new Person {Id=1,Name = "Sam",Age=23,Gender=true,DateOfBirth=DateTime.Now.AddYears(-23).AddDays(2).AddMonths(3)},
                new Person {Id=1,Name = "Samyak",Age=33,Gender=true,DateOfBirth=DateTime.Now.AddYears(-33).AddDays(-2).AddMonths(-3)},
                new Person {Id=1,Name = "Sammy",Age=43,Gender=true,DateOfBirth=DateTime.Now.AddYears(-43).AddDays(6)}
            };

            lstTest.DisplayMemberPath = "Name";
            lstTest.ItemsSource = persons;
            grdData.ItemsSource = persons;
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            String message = "None";
            if(rdbFemale.IsChecked == true)
            {
                message = rdbFemale.Content.ToString();
            }
            else if(rdbMale.IsChecked == true)
            {
                message = rdbMale.Content.ToString();
            }
            MessageBox.Show(message);
        }
    }
}
