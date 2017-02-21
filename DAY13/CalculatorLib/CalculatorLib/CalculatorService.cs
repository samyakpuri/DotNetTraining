using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLib
{
    [DataContract]
    public class CalculatorService : ICalculator, IAdvanceCalculator
    {

        public Response Operation(Request request)
        {
            Response response = new Response { Status = Status.Success };
            switch(request.Operation)
            {
                case Operator.None:
                    response.Status = Status.Failiure;
                    break;
                case Operator.Sum:
                    response.Result = (double)(request.Value1 + request.Value2);
                    break;
                case Operator.Subtract:
                    response.Result = (double)(request.Value1 - request.Value2);
                    break;
                case Operator.Multiply:
                    response.Result = (double)(request.Value1 * request.Value2);
                    break;
                case Operator.Divide:
                    if (request.Value2 != 0)
                        response.Result = (double)(request.Value1 / request.Value2);
                    else
                        response.Status = Status.Failiure;
                    break;
                default:
                    response.Status = Status.Failiure;
                    break;
            }
            return response;
        }

        public Response AdvanceOperations(Request request)
        {
            Response response = new Response { Status = Status.Success };
            switch (request.Operation)
            {
                case Operator.None:
                    response.Status = Status.Failiure;
                    break;
                case Operator.Power:
                    response.Result = (double)Math.Pow((double)request.Value1, (double)request.Value2);
                    break;
                case Operator.Root:
                    response.Result = (double)Math.Pow((double)request.Value1, (1.0 / (double)request.Value2));
                    break;
                default:
                    response.Status = Status.Failiure;
                    break;
            }
            return response;
        }
    }

    
}
