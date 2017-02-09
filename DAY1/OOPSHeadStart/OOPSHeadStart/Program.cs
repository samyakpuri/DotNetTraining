using ClassLib;
using Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSHeadStart
{
    class Program
    {
        static void Main(string[] args)
        {

            circlee();
            #region AccessMod
            //AccessModifiers temp = new AccessModifiers();
            //temp.k = 10;
            ////temp.l = 10;
            ////temp.m = 10;

            //child temp2 = new child();
            //temp2.k = 10;
            ////temp2.l = 10;
            ////temp2.m = 10; 
            #endregion

            #region MultipleInheritance
            //CurrentAccount account = new CurrentAccount();
            //IAccountDeposit account2 = new CurrentAccount();
            //IAccountDeposit account2_2 = (IAccountDeposit)account;

            //IAccountWithdraw account3 = account as IAccountWithdraw; 
            #endregion
        }

        private static void circlee()
        {
            Console.Write("Please enter Radius: ");
            Single radius = Convert.ToSingle(Console.ReadLine());
            Circle circle = new Circle(radius);
            Console.WriteLine("Area of Circle is {0}", circle.Area());

            Shape shape = new Circle();
            Console.WriteLine(shape.GetShapeType());

            Console.ReadLine();
        }
    }
}
