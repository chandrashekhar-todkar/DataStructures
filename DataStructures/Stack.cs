using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class Stack<T>
    {
        SingleLinkedList<T> list = new SingleLinkedList<T>();

        public void Push(T item)
        {
            list.AddItem(item);
        }

        public T Pop()
        {
            if (list.Last != null)
            {
                var item = list.Last.Item;
                list.RemoveLast();
                return item;
            }
            else
            {
                return default(T);
            }
        }

        public void ReadAll()
        {
            list.ReadAll();
        }
    }
}
