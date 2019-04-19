using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WpfCoinMidterm.ViewModels
{
    [ValueConversion(typeof(double), typeof(string))]
    public class SimpleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double returnedValue;

            if(double.TryParse((string)value, out returnedValue))
            {
                return returnedValue;
            }

            throw new Exception("This text is not a number");
        }
    }
}
