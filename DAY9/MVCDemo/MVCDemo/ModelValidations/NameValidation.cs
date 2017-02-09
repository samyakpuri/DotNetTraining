using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCDemo.ModelValidations
{
    public class NameValidation : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null)
                return false;
            string stringValue = value.ToString();

            if (stringValue.Length < 2)
                return false;
            return true;
        } 
    }
}