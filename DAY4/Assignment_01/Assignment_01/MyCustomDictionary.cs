using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_01
{
    class MyCustomDictionary<TKey, TValue>: IReadOnlyDictionary<TKey,TValue>
    {
        readonly Dictionary<TKey, TValue> _dictionary;

        public MyCustomDictionary(Dictionary<TKey,TValue> dictionary)
        {
            _dictionary = new Dictionary<TKey, TValue>(dictionary);
        }
        public bool ContainsKey(TKey key)
        {
            return _dictionary.ContainsKey(key);
        }

        public IEnumerable<TKey> Keys
        {
            get { return _dictionary.Keys; }
        }

        public bool TryGetValue(TKey key, out TValue value)
        {
            return _dictionary.TryGetValue(key,out value);
        }

        public IEnumerable<TValue> Values
        {
            get { return _dictionary.Values; }
        }

        public TValue this[TKey key]
        {
            get { return _dictionary[key]; }
        }

        public int Count
        {
            get { return _dictionary.Count; }
        }

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            List<KeyValuePair<TKey, TValue>> list = _dictionary.ToList<KeyValuePair<TKey, TValue>>();
            return list.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return new MyCustomDictionaryEnumerator<TKey,TValue>(_dictionary);
        }
    }
}
