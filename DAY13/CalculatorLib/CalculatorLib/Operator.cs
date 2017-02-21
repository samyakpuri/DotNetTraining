using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CalculatorLib
{
    [DataContract]
    public enum Operator
    {
        [EnumMember]
        None = -1,
        [EnumMember]
        Sum = 0,
        [EnumMember]
        Subtract = 1,
        [EnumMember]
        Multiply = 2,
        [EnumMember]
        Divide = 3,
        [EnumMember]
        Power = 4,
        [EnumMember]
        Root = 5        
    }
}
