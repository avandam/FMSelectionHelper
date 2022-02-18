using System;
using System.Globalization;
using System.Windows.Data;

namespace FMSelectionHelper
{
    [ValueConversion(typeof(double), typeof(string))]
    public class ScoreConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double score = (double) value;
            if (double.IsNaN(score))
                return string.Empty;
            return score;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
