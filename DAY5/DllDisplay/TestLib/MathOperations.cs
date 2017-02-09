using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLib
{
    public delegate void CustomAction(int i,int j);

    public class MathOperations
    {
        int _firstNum,_secondNum;
        CustomAction customAction;

        public int Setter 
        { 
            get
            {
                return _firstNum;
            }
            set
            {
                _secondNum=value;
            }
        }
        
        public MathOperations()
        {
            _firstNum = 0;
            _secondNum = 0;
        }

        public int Add(int firstNum, int secondNum)
        {
            return firstNum + secondNum;
        }

        public int Sub(int firstNum, int secondNum)
        {
            return firstNum - secondNum;
        }

    }
}
