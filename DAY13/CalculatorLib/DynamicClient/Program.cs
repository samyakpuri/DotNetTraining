using CalculatorLib;
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
            //ChannelFactory<CalculatorLib.ICalculator> channelFactory = new ChannelFactory<CalculatorLib.ICalculator>(new BasicHttpBinding(), "http://localhost:33333/basic");
            //CalculatorLib.ICalculator client = channelFactory.CreateChannel();
            CustomProxy client = new CustomProxy();
            var response = client.Operation(new Request() {Operation = Operator.Sum, Value1 = 2, Value2 = 3 });
            Console.WriteLine(response.Counter);
            response = client.Operation(new Request() { Operation = Operator.Sum, Value1 = 2, Value2 = 3 });
            Console.WriteLine(response.Counter);
            response = client.Operation(new Request() { Operation = Operator.Sum, Value1 = 2, Value2 = 3 });
            Console.WriteLine(response.Counter);
            response = client.Operation(new Request() { Operation = Operator.Sum, Value1 = 2, Value2 = 3 });
            Console.WriteLine(response.Counter);
            Console.WriteLine("---------------------------------------------------------------");

            CustomProxy client2 = new CustomProxy();
            var response2 = client2.Operation(new Request() { Operation = Operator.Sum, Value1 = 2, Value2 = 3 });
            Console.WriteLine(response2.Counter);
            response2 = client2.Operation(new Request() { Operation = Operator.Sum, Value1 = 2, Value2 = 3 });
            Console.WriteLine(response2.Counter);
            response2 = client2.Operation(new Request() { Operation = Operator.Sum, Value1 = 2, Value2 = 3 });
            Console.WriteLine(response2.Counter);
            response2 = client2.Operation(new Request() { Operation = Operator.Sum, Value1 = 2, Value2 = 3 });
            Console.WriteLine(response2.Counter);

            Console.ReadLine();
        }
    }

    class CustomProxy : ClientBase<ICalculator>, ICalculator
    {
        public CustomProxy() : base(new BasicHttpBinding(), new EndpointAddress("http://localhost:33333/basic"))
        {

        }

        public Response Operation(Request request)
        {
            return base.Channel.Operation(request);
        }
    }
}
