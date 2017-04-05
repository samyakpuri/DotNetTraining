using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WpfDay2.Converters
{
    class BoolToGenderConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value == null)
                return "Female";

            bool gender = System.Convert.ToBoolean(value);
            return gender ? "Male" : "Female";
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value == null)
                return false;

            string gender = System.Convert.ToString(value);
            return gender == "Male";
        }
    }
}
