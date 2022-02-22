using System;
using System.Globalization;
using System.Windows.Data;

namespace FMSelectionHelper
{
    [ValueConversion(typeof(int), typeof(string))]
    public class AbilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int score = (int) value;
            if (score == -1)
                return string.Empty;
            return score;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
