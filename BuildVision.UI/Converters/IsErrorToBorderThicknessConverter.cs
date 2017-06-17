using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace BuildVision.UI.Converters
{
    [ValueConversion(typeof(bool), typeof(Thickness))]
    public class IsErrorToBorderThicknessConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var isError = (bool)value;
            return isError ? new Thickness(1) : new Thickness(0);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}