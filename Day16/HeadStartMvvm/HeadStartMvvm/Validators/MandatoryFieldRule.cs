using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace HeadStartMvvm.Validators
{
    class MandatoryFieldRule : ValidationRule
    {
        public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureInfo)
        {
            if (value.ToString() == "")
                return new ValidationResult(false, "Field is Mandatory");
            return new ValidationResult(true,null);
        }
    }
}
