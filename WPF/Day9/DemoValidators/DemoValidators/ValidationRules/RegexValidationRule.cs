using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace DemoValidators.ValidationRules
{
    public class RegexValidationRule : ValidationRule
    {
        public string Pattern { get; set; }

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if (!String.IsNullOrWhiteSpace(Pattern))
            {
                if (Regex.IsMatch(value.ToString(), Pattern))
                {
                    return new ValidationResult(true, null);
                }
                else
                {
                    return new ValidationResult(false, "IMEI is no correct");
                }
            }
            return new ValidationResult(false, "Pattern is empty");
        }
    }
}
