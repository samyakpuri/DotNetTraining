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
            Calculator.CalculatorClient client = new Calculator.CalculatorClient();
            var response = client.Operation(new Calculator.Request() {Operation = Calculator.Operator.Sum, Value1 = 10, Value2 = 20 });
            Calculator.AdvanceCalculatorClient client2 = new Calculator.AdvanceCalculatorClient();
        }
    }
}
