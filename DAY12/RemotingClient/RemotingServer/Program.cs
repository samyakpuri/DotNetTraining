using RemotingCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using System.Text;
using System.Threading.Tasks;

namespace RemotingServer
{
    class Program
    {
        static void Main(string[] args)
        {
            var channel = new HttpChannel(12345);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(Person),"test",WellKnownObjectMode.Singleton);
            ChannelServices.RegisterChannel(channel,false);
            Console.WriteLine("Server is ready");
            Console.WriteLine("Enter to exit");
            Console.ReadLine();
        }
    }
}
