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
using System.Windows.Shapes;

namespace WpfDay2
{
    /// <summary>
    /// Interaction logic for Style.xaml
    /// </summary>
    public partial class Style : Window
    {
        public Style()
        {
            InitializeComponent();
        }

        private void Change_Button_Click(object sender, RoutedEventArgs e)
        {
            SolidColorBrush brush = new SolidColorBrush();
            SolidColorBrush brush2 = new SolidColorBrush();
            brush.Color = Colors.Blue;
            this.Resources["TextBoxBackground"] = brush;
            brush2.Color = Colors.White;
            this.Resources["TextBoxForeground"] = brush2;
        }
    }
}
