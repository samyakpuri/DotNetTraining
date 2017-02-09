using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpBasics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnForLoop_Click(object sender, EventArgs e)
        {
            int[] iArray = new int[4];
            for(int i=0;i<iArray.Length;i++)
            {
                iArray[i] = i;
            }
            foreach(var i in iArray)
            {
                Console.WriteLine(i);
            }

            int[,] i2D = new int[2, 2];
            for (int i = 0; i < i2D.GetLength(0); i++)
            {
                for (int j = 0; j < i2D.GetLength(1); j++)
                {
                    i2D[i, j] = i + j;
                }   
            }

            foreach (var i in i2D)
            {
                Console.WriteLine(i);
            }
            
            IEnumerator enumerator = iArray.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine("temp: {0}", enumerator.Current);
            }

        }

        private void btnValueVsRef_Click(object sender, EventArgs e)
        {
            int i=10,k;
            Console.WriteLine("Value of i before function call is..." + i);
            Console.WriteLine("After calling the function by passing value type we get");
            valueType(i);   
            k=i;
            Console.WriteLine(k);
            Console.WriteLine("After calling the function by passing reference type we get");
            refType(ref i);
            k = i;
            Console.WriteLine(k);
            A temp = new A();

            Console.WriteLine("llalalalalalal");
            Console.WriteLine("Value of i before function call is..." + temp.i);
            Console.WriteLine("After calling the function by passing value type we get");
            valueTypeRef(temp);
            k = temp.i;
            Console.WriteLine(k);
            Console.WriteLine("After calling the function by passing reference type we get");
            refTypeRef(ref temp);
            k = temp.i;
            Console.WriteLine(k);


        }

        void valueType(int i)
        {
            i = 30;
        }
    
        void refType(ref int i)
        {

            i = 30;
        }    
        class A
        {
            public int i=10;
        }

        void valueTypeRef(A i)
        {
            i.i = 30;
            i = null;
        }

        void refTypeRef(ref A i)
        {

            i.i = 30;
            //i = null;
        }

        private void Temp_Click(object sender, EventArgs e)
        {
            
        }

        private void Pattern_Click(object sender, EventArgs e)
        {
            int n = 5;
            int space = n-1;
            for (int k = 1; k <= n; k++)
            {
                for (int c = 1; c <= space; c++)
                {
                    Console.Write(" ");
                }

                space--;

                for (int c = 1; c <= 2 * k - 1; c++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            space = 1;

            for (int k = 1; k <= n - 1; k++)
            {
                for (int c = 1; c <= space; c++)
                {
                    Console.Write(" ");
                }
              
                space++;

                for (int c = 1; c <= 2 * (n - k) - 1; c++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

        }

        private void Fibonacci_Click(object sender, EventArgs e)
        {
            RecFibonacci(1,2,10);
        }   
 
        void RecFibonacci(int a,int b, int n)
        {
                 
        }
    }
}
