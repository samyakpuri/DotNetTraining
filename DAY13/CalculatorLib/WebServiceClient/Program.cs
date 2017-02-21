using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServiceClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator.CalculatorClient client = new Calculator.CalculatorClient("BasicHttp");
            var response = client.Operation(new Calculator.Request() {Operation = Calculator.Operator.Sum, Value1 = 10, Value2 = 20 });
            Calculator.AdvanceCalculatorClient client2 = new Calculator.AdvanceCalculatorClient("BasicHttp_IAdvance");
            var response2 = client2.AdvanceOperations(new Calculator.Request() {Operation = Calculator.Operator.Power, Value1 = 3, Value2 = 3});

            FullCalculator.FullCalculatorClient client3 = new FullCalculator.FullCalculatorClient("BasicHttp_Full");
            var response3 = client3.Operate(new FullCalculator.Request() { Operation = FullCalculator.Operator.Power, Value1 = 10, Value2 = 2 });
        }
    }
}
