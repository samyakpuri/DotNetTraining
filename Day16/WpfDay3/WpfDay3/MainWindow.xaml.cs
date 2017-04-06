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

namespace WpfDay3
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
            ResourceDictionary dictionary = new ResourceDictionary(){ Source = new Uri("Theme1.xaml", UriKind.Relative) };
            if(App.Current.Resources.MergedDictionaries.Contains(dictionary))
            {
                (App.Current as App).ChangeTheme("US");
            }
            else
            {
                (App.Current as App).ChangeTheme("Other");
            }
        }

        //private void EventSetter_OnHandler(object sender, TextChangedEventArgs e)
        //{
        //    MessageBox.Show(sender.ToString());
        //}
    }
}
