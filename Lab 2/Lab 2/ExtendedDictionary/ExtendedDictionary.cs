using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2.ExtendedDictionary
{
    public class ExtendedDictionary<T, U, V> : IEnumerable<Tuple<U, V>>
        where T : notnull
    {
        private Dictionary<T, Tuple<U, V>> _dictionary;

        public int Count => _dictionary.Count;

        public ExtendedDictionary()
        {
            _dictionary = new Dictionary<T, Tuple<U, V>>();
        }

        public void Add(T key, U value1, V value2)
        {
            _dictionary.Add(key, new Tuple<U, V>(value1, value2));
        }

        public void Remove(T key)
        {
            _dictionary.Remove(key);
        }

        public Tuple<U, V> this[T key]
        {
            get { return _dictionary[key]; }
        }

        public bool ContainsKey(T key)
        {
            return _dictionary.ContainsKey(key);
        }

        public bool ContainsValues(U value1, V value2)
        {
            return _dictionary.Any(
                x =>
                    (x.Value.Item1?.Equals(value1) ?? false)
                    && (x.Value.Item2?.Equals(value2) ?? false)
            );
        }

        public IEnumerator<Tuple<U, V>> GetEnumerator()
        {
            return _dictionary.Values.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
