using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemotingCommon
{
    [Serializable]
    public class Person : MarshalByRefObject
    {
        int _counter;

        public Person()
        {
            Console.WriteLine("Constructor Called");
        }

        public string Hike()
        {
            _counter++;
            return string.Format("Value of counter is {0}",_counter);
        }
    }
}
