using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace CalculatorLib
{
    [ServiceContract]
    interface IAdvanceCalculator
    {
        [OperationContract]
        Response AdvanceOperations(Request request);
    }
}
