using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.CustomHtmlHelper
{
    public static class CustomHtmlHelper
    {
        public static MvcHtmlString CreateCustomGrid<T>(this HtmlHelper helper, IEnumerable<T> source)
        {
            String result = "<table>";
            var type = typeof(T);
            var properties = type.GetProperties().ToList();
            result += "<tr>";
            foreach (var property in properties)
            {
                result += "<th>" + property.Name + "</th>";

            }
            foreach (var item in source)
            {
                result += "<tr>";
                foreach (var property in properties)
                {
                    result += "<td>" + property.GetValue(item) + "</td>";
                }
                result += "<tr>";
            }
            result += "</table>";
            return MvcHtmlString.Create(result);
        }
    }
}