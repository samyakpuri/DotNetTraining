using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_01
{
    class MyCustomDictionaryEnumerator<TKey, TValue>: IEnumerator<KeyValuePair<TKey,TValue>>
    {
        readonly Dictionary<TKey, TValue> _dict;
        //readonly int _count;
        readonly IEnumerable<TKey> keys;
   

        public MyCustomDictionaryEnumerator(Dictionary<TKey,TValue> dict)
        {
            _dict = new Dictionary<TKey, TValue>(dict);
            keys = dict.Keys;
        }

        public KeyValuePair<TKey, TValue> Current
        {
            get { throw new NotImplementedException(); }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        object System.Collections.IEnumerator.Current
        {
            get { throw new NotImplementedException(); }
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
