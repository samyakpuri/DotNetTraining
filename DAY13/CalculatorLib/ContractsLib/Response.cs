using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CalculatorLib
{
    [DataContract]
    public class Response
    {
        [DataMember]
        public Status Status { get; set; }
        [DataMember]
        public double Result { get; set; }
    }
}
