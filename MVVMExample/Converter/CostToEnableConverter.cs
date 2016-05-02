using System;
using System.Globalization;
using System.Windows.Data;

namespace MVVMExample.Converter
{
    public class CostToEnableConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                var balance = int.Parse(values[0].ToString());
                return (balance < (int) values[1]);
            }
            catch (Exception)
            {
                return true;
            }
            
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
