using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryDemo
{
    class MyListDictionary<Key, Value>
    {
        (Key, Value)[] items;

        public MyListDictionary()
        {
            items = new (Key, Value)[0];
        }

        public void Add(Key _key, Value _value)
        {
            (Key, Value)[] tempArray = items;
            items = new (Key, Value)[tempArray.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = (_key, _value);
        }

        public int Length
        {
            get { return items.Length; }
        }

        public void Listing() 
        {
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine(items[i]);
            }
        }
        
    }
    
}
