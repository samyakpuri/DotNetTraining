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
        public int Counter { get; set; }
        [DataMember]
        public Status Status { get; set; }
        [DataMember]
        public double Result { get; set; }
        [DataMember]
        public String StatusMessage { get; set; }
        
    }
}
