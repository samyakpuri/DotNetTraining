using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            MyCustomCollection arr = new MyCustomCollection(5,EnumeratorType.EVEN);
            for (int i = 0; i < 10; i++)
            {
                arr.AddItem(i);
            }
            arr.PrintArray();
            Console.ReadLine();


            Console.WriteLine("Item removed value 8");
            arr.Remove(8);
            arr.PrintArray();
            Console.ReadLine();

            Console.WriteLine("Item removed at index 2");
            arr.RemoveAt(2);
            arr.PrintArray();
            Console.ReadLine();

            Console.WriteLine("Item Inserted at index 3");
            arr.Insert(5, 3);
            arr.PrintArray();
            Console.ReadLine();

            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.ReadLine();

            MyCustomCollection odd = new MyCustomCollection(4, EnumeratorType.ODD);
            for (int i = 0; i < 5; i++)
            {
                odd.AddItem(i);
            }
            odd.PrintArray();
            Console.ReadLine();
            
            foreach (var item in odd)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();          
            Console.ReadLine();

            //int[] tar = { 1, 2, 3, 4 };
            //arr.PrintArray();
            //arr.InsertRange(tar, 3);
            //arr.PrintArray();
            //Console.ReadLine();

            Console.WriteLine(arr.Count);
            Console.WriteLine(arr.Capacity);
            Console.ReadLine();

            CustomCollectionGeneric<int> temp = new CustomCollectionGeneric<int>(1,EnumeratorType.EVEN);
        }
    }
}
