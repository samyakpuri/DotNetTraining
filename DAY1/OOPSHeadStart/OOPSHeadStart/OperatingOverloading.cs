using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSHeadStart
{
    class Complex
    {
        int _real, _imaginary;

        public Complex(int real,int imaginary)
        {
            _real = real;
            _imaginary = imaginary;
        }

        public override string ToString()
        {
            return string.Format("{0} +i{1}", _real, _imaginary);
        }

        public override Complex operator +(Complex c1, Complex c2)
        {
            return Complex(c1._real + c2._real, c2._imaginary + c1._imaginary);
        }
    }

    class Test
    {
        void Test()
        {
            Complex c1 = new Complex(1, 2);
            Complex c2 = new Complex(1, 2);
            Complex c3 = c1 + c2;
            Console.WriteLine(c3);
            Console.ReadLine();
        }
    }
}
