using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class Queue<T>
    {
        DoubleLinkedList<T> list = new DoubleLinkedList<T>();

        public void Push(T item)
        {
            list.AddItem(item);
        }

        public T Pop()
        {
            if (list.First != null)
            {
                var item = list.First.Item;
                list.RemoveFirst();
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
