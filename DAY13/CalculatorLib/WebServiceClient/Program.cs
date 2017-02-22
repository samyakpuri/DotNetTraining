using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WebServiceClient.Calculator;

namespace WebServiceClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator.CalculatorClient client = new Calculator.CalculatorClient("BasicHttp");
            try
            {
                var response0 = client.Operation(new Calculator.Request() { Operation = Calculator.Operator.Sum, Value1 = 10, Value2 = 20 });
            }
            catch(FaultException<Response> exception)
            {
                Console.WriteLine("Fault");
            }
            catch(Exception e)
            {

            }

            var response = client.Operation(new Calculator.Request() { Operation = Calculator.Operator.Sum, Value1 = 10, Value2 = 20 });
            response.Counter++;
            Console.WriteLine(response.Counter);

            response = client.Operation(new Calculator.Request() { Operation = Calculator.Operator.Sum, Value1 = 10, Value2 = 20 });
            response.Counter++;
            Console.WriteLine(response.Counter);

            response = client.Operation(new Calculator.Request() { Operation = Calculator.Operator.Sum, Value1 = 10, Value2 = 20 });
            response.Counter++;
            Console.WriteLine(response.Counter);

            Console.WriteLine("-----------------------------------------------");

            Calculator.AdvanceCalculatorClient client2 = new Calculator.AdvanceCalculatorClient("BasicHttp_IAdvance");
            var response2 = client2.AdvanceOperations(new Calculator.Request() {Operation = Calculator.Operator.Power, Value1 = 3, Value2 = 3});
            response2.Counter++;
            Console.WriteLine(response2.Counter);

            response2 = client2.AdvanceOperations(new Calculator.Request() { Operation = Calculator.Operator.Power, Value1 = 3, Value2 = 3 });
            response2.Counter++;
            Console.WriteLine(response2.Counter);

            response2 = client2.AdvanceOperations(new Calculator.Request() { Operation = Calculator.Operator.Power, Value1 = 3, Value2 = 3 });
            response2.Counter++;
            Console.WriteLine(response2.Counter);

            Console.WriteLine("-----------------------------------------------");

            FullCalculator.FullCalculatorClient client3 = new FullCalculator.FullCalculatorClient("BasicHttp_Full");
            var response3 = client3.Operate(new FullCalculator.Request() { Operation = FullCalculator.Operator.Power, Value1 = 10, Value2 = 2 });

            Console.ReadLine();
        }
    }
}
