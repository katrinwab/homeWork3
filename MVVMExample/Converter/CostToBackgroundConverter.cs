using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace MVVMExample.Converter
{
    public class CostToBackgroundConverter : DependencyObject, IMultiValueConverter
    {
        public Brush HighlughtBrush { get; set; }
        public Brush DefaultBrush { get; set; }

        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            int balance;
            int.TryParse(values[0].ToString(), out balance);
            if (balance < (int)values[1])
                return HighlughtBrush;
            return DefaultBrush;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
