using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomCollections
{
    class CustomCollectionGeneric<T>: IEnumerable
    {
        int _count, _capacity;
        T[] _items;
        EnumeratorType _enumeratorType;

        public int Count 
        { 
            get
            {
                return _count;
            } 
        }
        
        public int Capacity 
        { 
            get
            {
                return _capacity;
            } 
            set
            {
                _capacity = value;
            }
        }

        public CustomCollectionGeneric(int capacity, EnumeratorType type)
        {
            _capacity = capacity;
            _items = new T[_capacity];
            _count = 0;
            _enumeratorType = type;
        }

        public void AddItem(T item)
        {
            if (_count < _capacity)
            {
                _items[_count++] = item;
            }
            else
            {
                _capacity *= 2;
                Resize(_capacity);
                _items[_count++] = item;
                
            }
        }

        private void Resize(int capacity)
        {
            T[] newItems = new T[_capacity];
            Array.Copy(_items, newItems, _count);
            _items = newItems;
        }

        public void PrintArray()
        {
            foreach (var iter in _items)
            {
                Console.Write(iter+" ");
            }
            Console.WriteLine();
        }

        public void Remove(T item)
        {
            RemoveSuper(Find(item));
            _count--;
        }

        private void RemoveSuper(int index,bool all=false)
        {
            #region old
            //int[] temp = new int[_capacity];
            //bool found = false;
            //for (int i = 0; i < _count; i++)
            //{
            //    if (all)
            //    {
            //        _items[i] = 0;
            //    }
            //    else
            //    {
            //        if (_items[i] == item && !found)
            //        {
            //            found = true;
            //        }
            //        if (!found)
            //        {
            //            temp[i] = _items[i];
            //        }
            //        else
            //        {
            //            if (i == _items.Length - 1)
            //            {
            //                temp[i] = 0;
            //            }
            //            else
            //                temp[i] = _items[i + 1];
            //        }
            //    }
            //}
            //_items = temp; 
            #endregion
            if (!all)
            {
                RemoveAt(index);
            }
            else
            {
                for (int i = 0; i <= _count; i++)
                {
                    _items[i] = default(T);
                }
            }
        }

        private void Shift(int index,int type)
        {
            if (type == -1)
            {
                for (int i = index; i < _items.Length; i++)
                {
                    if (i == _items.Length - 1)
                    {
                        _items[i] = default(T);
                    }
                    else
                        _items[i] = _items[i + 1];
                }
            }
            else
            {
                for (int i = _count; i > index-1; i--)
                {

                    if(i == _items.Length-1)
                    {
                        this.AddItem(_items[i]);
                    }
                    else
                    {
                        _items[i + 1] = _items[i];
                    }
                }
            }
        }

        public void RemoveAll()
        {
            RemoveSuper(-1,true );
            _count = 0;
        }

        private int Find(T item)
        {
            for (int i = 0; i < _items.Length; i++)
            {
                if (_items[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }

        public void RemoveAt(int index)
        {
            if(index==-1)
            {
                return;
            }
            Shift(index, -1);
            _count--;
        }

        public void Insert(T item,int index)
        {
            Shift(index, 1);
            _items[index] = item;
            _count++;
        }

        public void InsertRange(T[] item,int index)
        {
            //TODO
        }

        public void Set(T item, int index)
        {
            //TODO
        }

        public void SetRange(T[] item, int index)
        {
            //TODO
        }

        public void RemoveAllOccurece(T item)
        {
            //TODO
        }


        public IEnumerator GetEnumerator()
        {
            if(_enumeratorType == EnumeratorType.EVEN)
                return new CustomEnumeratorGenericEven<T>(_items,_count);
            else
                return new CustomEnumeratorGenericOdd<T>(_items, _count);
        }
    }
}
