using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MultivalueDictionaryApp
{
    public class MultivalueDictionary<TKey, TValue> : IMultivalueDictionary<TKey, TValue>
    {
        private Dictionary<TKey, List<TValue>> _multiValueDictionary { get;  set; }

        public MultivalueDictionary()
        {
            _multiValueDictionary = new Dictionary<TKey, List<TValue>>();
        }

        public void Add(TKey key, TValue value)
        {
            if (!_multiValueDictionary.ContainsKey(key))
            {
                _multiValueDictionary.Add(key, new List<TValue>() { value });
                Console.WriteLine("Added");
            }
            else
            {
                if (_multiValueDictionary[key].Any() && _multiValueDictionary[key].Contains(value))
                {
                    Console.WriteLine("Error member already exists for the key");
                }
                else
                {
                    _multiValueDictionary[key].Add(value);
                    Console.WriteLine("Added");
                }
            }
        }
        public void Keys()
        {
            if (_multiValueDictionary.Count > 0)
            {
                var keys = _multiValueDictionary.Select(x => x.Key);
                foreach (var k in keys)
                {
                    Console.WriteLine(k);
                }
            }
            else
            {
                Console.WriteLine("Empty set");
            }
        }


        public void Members(TKey key)
        {
            if (_multiValueDictionary.Count > 0)
            {
                if (!CheckNullOrEmpty(key))
                {
                    if (_multiValueDictionary.ContainsKey(key))
                    {
                        var values = _multiValueDictionary[key];
                        if (values != null && values.Any())
                        {
                            foreach (var v in values)
                            {
                                Console.WriteLine(v);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error key does not exist");
                    }
                }
                else
                {
                    Console.WriteLine("Enter a key");
                }
            }
            else
            {
                Console.WriteLine("Dictionary is empty");
            }
        }

        public void Remove(TKey key, TValue value)
        {
            if (_multiValueDictionary.ContainsKey(key))
            {
                if (_multiValueDictionary[key].Any())
                {
                    var isRemoved = _multiValueDictionary[key].Remove(value);
                    {
                        if (isRemoved)
                        {
                            Console.WriteLine("Removed");
                        }
                        else
                        {
                            Console.WriteLine("Error Member does not exist");
                        }
                    }
                    if (!_multiValueDictionary[key].Any())
                    {
                        _multiValueDictionary.Remove(key);
                    }
                }
            }
            else
            {
                Console.WriteLine("Error key does not exist");
            }

        }

        public void RemoveAll(TKey key)
        {
            if (_multiValueDictionary.ContainsKey(key))
            {
                _multiValueDictionary.Remove(key);
                Console.WriteLine("Removed");
            }
            else
            {
                Console.WriteLine("Error key does not exist");
            }
        }

        public void Clear()
        {
            _multiValueDictionary = new Dictionary<TKey, List<TValue>>();
            Console.WriteLine("Cleared");
        }


        public void KeyExists(TKey key)
        {
            if (_multiValueDictionary.ContainsKey(key))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }


        public void MemberExists(TKey key, TValue value)
        {
            if (_multiValueDictionary[key].Contains(value))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }

        public void AllMembers()
        {
            if (!_multiValueDictionary.Any())
            {
                Console.WriteLine("Empty Set");
            }
            else
            {
                var allValues = _multiValueDictionary.SelectMany(x => x.Value);
                if (allValues != null && allValues.Count() > 0)
                {
                    foreach (var v in allValues)
                    {
                        Console.WriteLine(v);
                    }
                }
            }
        }

        public void Items()
        {
            if (!_multiValueDictionary.Any())
            {
                Console.WriteLine("Empty Set");
            }
            else
            {
                foreach (var keyvaluepair in _multiValueDictionary)
                {
                    var k = keyvaluepair.Key;
                    var valueList = keyvaluepair.Value;
                    if (valueList != null && valueList.Count > 0)
                    {
                        foreach (var v in valueList)
                        {
                            Console.WriteLine(k + ":" + v);
                        }
                    }
                }
            }
        }

        public bool CheckNullOrEmpty<T>(T value)
        {
            if (typeof(T) == typeof(string))
                return string.IsNullOrEmpty(value as string);

            return value == null || value.Equals(default(T));
        }
    }
}
