using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiniProject
{
    class Student
    {
        string _name, _class;
        ushort _id;
        byte _age;

        public Student(string name,ushort id,byte age,string className)
        {
            _name = name.Clone() as string ;
            _id = id;
            _age = age;
            _class = className.Clone() as string;
         }

        public override string ToString()
        {
            return String.Format("{0}-{1}-{2}-{3}", _id, _name, _age, _class);
        }
    }
}
