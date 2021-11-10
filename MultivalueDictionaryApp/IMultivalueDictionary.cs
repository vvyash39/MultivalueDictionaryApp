using System;
using System.Collections.Generic;
using System.Text;

namespace MultivalueDictionaryApp
{
    interface IMultivalueDictionary<TKey, TValue>
    {
        void Add(TKey key, TValue value);
        void Keys();
        void Members(TKey key);
        void Remove(TKey key, TValue value);

        void RemoveAll(TKey key);
        void Clear();
        void KeyExists(TKey key);

        void MemberExists(TKey key, TValue value);
        void AllMembers();
        void Items();

    }
}
