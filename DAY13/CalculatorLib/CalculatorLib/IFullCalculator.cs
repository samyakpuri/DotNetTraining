using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace CalculatorLib
{
    [ServiceContract]
    interface IFullCalculator
    {
        [OperationContract]
        Response Operate(Request request);
    }
}
