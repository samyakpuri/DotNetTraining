using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSHeadStart
{
    class OverloadingBasics
    {
        public long Add(int num1,int num2)
        {
            return num1 + num2;
        }

        public long Add(int num1, int num2, int num3)
        {
            return num1 + num2;
        }
    }

    class BaseClassTester
    {
        public void Test()
        {
            OverloadingBasics test = new OverloadingBasics();
            long sum = test.Add(1, 2);
            sum = test.Add(1, 2, 3);
        }
    }
}
