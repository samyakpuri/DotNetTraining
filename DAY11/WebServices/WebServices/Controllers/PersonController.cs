using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebServices.Controllers
{
    public class PersonController : ApiController
    {
        private static List<Person> _persons;

        static PersonController()
        {
            _persons = new List<Person>();
            _persons.Add(new Person() { Id = 1, Age = 20, Name = "Test1" });
            _persons.Add(new Person() { Id = 2, Age = 25, Name = "Test2" });

        }

        public IEnumerable<Person> Get()
        {
            return _persons;
        }

        [HttpPost]
        public void Insert(Person person)
        {
            _persons.Add(person);
        }
    }
}
