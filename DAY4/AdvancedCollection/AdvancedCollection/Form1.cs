using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AdvancedCollection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnArrayList_Click(object sender, EventArgs e)
        {
            Console.WriteLine("====================List<>======================");
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add(2);
            list.AddRange(new int[] { 3, 4, 5, 6 });
            Print(list);

            if (list.Count < list.Capacity)
                list.TrimToSize();

            var copyList = list.Clone() as ArrayList;

            Print(copyList);

            int[] copyList2 = new int[list.Count];
            list.CopyTo(copyList2);
            foreach (var item in copyList2)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            var index = list.BinarySearch(2);
            Console.WriteLine("index=" + index);
            copyList.Clear();
            list.Insert(2, 57);
            Print(list);
            list.InsertRange(1, new int[] { 2, 6, 5, 4 });
            Print(list);
            list.Sort();
            Print(list);

        }

        /// <summary>
        /// Printing ArrayLists
        /// </summary>
        /// <param name="list">void Print(ArrayList list)</param>
        private static void Print(ArrayList list)
        {
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        
        private static void Print<T>(List<T> list)
        {
            list.ForEach(obj => Console.Write(obj + " "));
            Console.WriteLine();
        }

        private void btnListGeneric_Click(object sender, EventArgs e)
        {

            Console.WriteLine("====================List<>======================");
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.AddRange(new int[] { 3, 4, 5, 6 });
            Print(list);

            if (list.Count < list.Capacity)
                list.TrimExcess();

            var copyList = list.ConvertAll(input => ToString());

            Print(copyList);

            var index = list.BinarySearch(2);
            Console.WriteLine("index=" + index);
            copyList.Clear();

            list.Insert(2, 57);
            Print(list);

            list.InsertRange(1, new int[] { 2, 6, 5, 4 });
            Print(list);

            list.Sort();
            Print(list);

            bool exist = list.Exists(obj => obj % 3 == 0);
            Console.WriteLine("Exists: " + exist);

            Print(list);
            var found = list.Find(obj => obj % 2 == 0);
            Console.WriteLine("Found=" + found);

            list.ForEach(obj => Console.Write(obj + " "));
            Console.WriteLine();


            Console.WriteLine("Aggregate: "+list.Aggregate((obj1, obj2) => obj1 + obj2));

            list.Print();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hashtable hashTable = new Hashtable();
            hashTable.Add(1, "One");
            hashTable.Add(2, "Two");
            hashTable.Add(3, "Three");

            List<int> keys = hashTable.Keys as List<int>;
            keys.Print();
        }
    }

    static class ExtendList
    {
        public static void Print(this List<int> list)
        {
            list.ForEach(obj => Console.Write(obj + " "));
            Console.WriteLine();
        }
    }
}