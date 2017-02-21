using RemotingCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemotingClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press enter when server is ready");
            Console.ReadLine();
            var proxy = Activator.GetObject(typeof(Person),"http://localhost:12345/test") as Person;
            var response=proxy.Hike();
            Console.WriteLine("Server response is {0}",response);
            response = proxy.Hike();
            Console.WriteLine("Server response is {0}", response);
            Console.ReadLine();
        }
    }
}
