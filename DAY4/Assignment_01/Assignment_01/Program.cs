using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01
{
    class Program
    {
        static void Main(string[] args)
        {
            DemoIReadOnlyCollection();
            DemoIReadOnlyDictionary();
        }

        private static void DemoIReadOnlyDictionary()
        {
            MyCustomDictionary<int, string> dictionary = new MyCustomDictionary<int, string>();
        }

        private static void DemoIReadOnlyCollection()
        {
            var list = Enumerable.Range(1, 10) as int[];
            MyCustomCollection<int> collection = new MyCustomCollection<int>(list);
        }
    }
}
