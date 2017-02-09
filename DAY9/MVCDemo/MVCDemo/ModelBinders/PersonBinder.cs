using MVCDemo.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.ModelBinders
{
    public class PersonBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            Person person= new Person();
            var collection = controllerContext.HttpContext.Request.Form;
            {
                person.Id = Convert.ToInt32(controllerContext.HttpContext.Request.QueryString[3]);
            }
            person.Age = Convert.ToInt32(collection["Age"]);
            person.Salary = Convert.ToDecimal(collection["Salary"]);
            person.Name = collection["Name"];
            person.DateofBirth = Convert.ToDateTime(collection["DateofBirth"]);
            return person;
        }
    }
}