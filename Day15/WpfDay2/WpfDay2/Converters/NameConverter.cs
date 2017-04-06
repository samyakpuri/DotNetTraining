using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace WpfDay2.Converters
{
    class NameConverter: IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (values.Any(v => v == null || v == DependencyProperty.UnsetValue || String.IsNullOrEmpty(v.ToString())))
                return null;

            if(parameter != null)
            {
                if (parameter.ToString().Equals("US"))
                {
                    return values.Select(v => v.ToString()).Aggregate((a, b) => b + "," + a);
                }
            }

            return values.Select(v => v.ToString()).Aggregate((a, b) => a + " " + b);
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value == null)
                return null;

            List<String> stringResult = new List<String>();
            String stringValue = value.ToString();
            stringResult = stringValue.Split(null).ToList();
            if (stringResult.Count == 1)
                stringResult.Add(" ");
            object[] objectResult = stringResult.Cast<object>().ToArray();
            return objectResult;
        }
    }
}
