using MVCDemo.ModelValidations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCDemo.DataModels
{
    [MetadataType(typeof(PersonMetadata))]
    public partial class Person //: IValidatableObject
    {
        //public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        //{
        //    if (Name == null)
        //        yield return new ValidationResult("Name Cannot be Empty");
        //    if (Age == null)
        //        yield return new ValidationResult("Age cannot be Empty");
        //}
    }

    public class PersonMetadata
    {
        [NameValidation]
        public string Name { get; set; }
        //[Required]
        //public Nullable<int> Age { get; set; }
    }
}