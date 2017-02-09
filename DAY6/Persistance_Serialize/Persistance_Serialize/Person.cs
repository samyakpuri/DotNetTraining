using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Persistance_Serialize
{
    [Serializable]
    public class Person : ISerializable
    {
        private double _salary;

        public int Id { get; set; }
        public String Name { get; set; }
        public short Age { get; set; }

        public Person()
        {

        }

        public Person(SerializationInfo info, StreamingContext context)
        {
            Id = info.GetInt32("Id");
            Name = info.GetString("Name");
        }


        public Person(double sal)
        {
            _salary = sal;
        }

        public override string ToString()
        {
            return "Id: " + Id + Environment.NewLine + "Name: " + Name + Environment.NewLine + "Age: " + Age + Environment.NewLine + "Salary: " + _salary + Environment.NewLine;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Name",Name);
            info.AddValue("Id", Id);
        }
    }
}
