using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Controls;

namespace MVVMExample
{
    class BalanceValidateRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            var regex = new Regex("^[0-9]+$"); 
            if (!regex.IsMatch((string)value))
                return new ValidationResult(false, "Баланс должен быть неотрицательным");
            return new ValidationResult(true, null);
        }
    }
}
