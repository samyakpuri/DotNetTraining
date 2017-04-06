using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WpfDay3
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {

        }

        public void ChangeTheme(string theme)
        {
            if(theme == "US")
            {
                App.Current.Resources.MergedDictionaries.Clear();
                App.Current.Resources.MergedDictionaries.Add(new ResourceDictionary() { Source = new Uri("Theme2.xaml", UriKind.Relative) });
            }
            else
            {
                App.Current.Resources.MergedDictionaries.Clear();
                App.Current.Resources.MergedDictionaries.Add(new ResourceDictionary() { Source = new Uri("Theme1.xaml", UriKind.Relative) });
            }
        }
    }
}
