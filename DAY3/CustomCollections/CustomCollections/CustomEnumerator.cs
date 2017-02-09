using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomCollections
{
    class CustomEnumeratorEven : IEnumerator
    {
        readonly int[] _item;
        readonly int _count;
        int _currentIndex = -2;
        public CustomEnumeratorEven(int[] item, int count)
        {
            _item = item;
            _count = count;
        }
        public object Current
        {
            get { return _item[_currentIndex]; }
        }

        public bool MoveNext()
        {
            if (_currentIndex < _count - 1)
            {
                _currentIndex +=2 ;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            _currentIndex = -2;
        }
    }

    class CustomEnumeratorOdd : IEnumerator
    {
        readonly int[] _item;
        readonly int _count;
        int _currentIndex = -1;
        public CustomEnumeratorOdd(int[] item, int count)
        {
            _item = item;
            _count = count;
        }
        public object Current
        {
            get { return _item[_currentIndex]; }
        }

        public bool MoveNext()
        {
            if (_currentIndex + 2< _count - 1)
            {
                _currentIndex += 2;
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
