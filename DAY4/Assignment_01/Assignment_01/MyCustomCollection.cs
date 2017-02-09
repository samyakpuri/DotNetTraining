using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_01
{
    class MyCustomCollection<T>
    {
        readonly int _count;
        readonly T[] _list;

        public MyCustomCollection(T[] items)
        {
            for (int i = 0; i < items.Length; i++)
			{
                _list[i] = items[i];
			}
        }
        public int Count
        {
            get 
            { 
                return _count;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new MyCustomEnumerator<T>(_list,_count) as IEnumerator<T>;
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
