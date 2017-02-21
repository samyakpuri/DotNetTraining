using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace DynamicClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ChannelFactory<CalculatorLib.ICalculator> channelFactory = new ChannelFactory<CalculatorLib.ICalculator>(new BasicHttpBinding(), "http://localhost:33333/basic");
            CalculatorLib.ICalculator client = channelFactory.CreateChannel();
            var response = client.Operation(new CalculatorLib.Request() {Operation = CalculatorLib.Operator.Sum, Value1 = 2, Value2 = 3 });

            Console.WriteLine(response.Result);
            Console.ReadLine();
        }
    }
}
