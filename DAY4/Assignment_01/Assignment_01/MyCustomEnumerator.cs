using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_01
{
    class MyCustomEnumerator<T>: IEnumerator
    {
        readonly int _count;
        readonly T[] _lists;
        int _currentIndex=-1;

        public MyCustomEnumerator(T[] item, int count)
        {
            _lists = item;
            _count = count;
        }

        public object Current
        {
            get 
            {
                return _lists[_currentIndex];
            }
        }

        public bool MoveNext()
        {
            if (_currentIndex < _count - 1)
            {
                _currentIndex++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            _currentIndex = -1;
        }
    }
}
