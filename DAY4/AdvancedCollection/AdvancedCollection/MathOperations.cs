using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCollection
{
    public class MathOperations
    {
        public delegate int OperationDelegate(int i, int j);
        public int Operation(List<int> list,OperationDelegate func)
        {
            int sum = list[0];
            for (int i = 1; i < list.Count; i++)
          {
                sum = func(sum, list[i]); 
            }
            return sum;
        }
    }
}
