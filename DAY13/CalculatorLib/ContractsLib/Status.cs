using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CalculatorLib
{
    [DataContract]
    public enum Status
    {
        [EnumMember]
        Success = 0,
        [EnumMember]
        Failiure = 1
    }
}
