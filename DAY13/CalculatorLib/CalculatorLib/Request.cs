using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CalculatorLib
{
    [DataContract]
    public class Request
    {
        [DataMember]
        public Operator Operation { get; set; }
        [DataMember]
        public decimal Value1 { get; set; }
        [DataMember]
        public decimal Value2 { get; set; }
    }
}
