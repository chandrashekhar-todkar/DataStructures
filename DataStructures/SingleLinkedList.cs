using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class Node<T>
    {
        public Node(T item)
        {
            this.Item = item;
        }

        public T Item { get; set; }
        public Node<T> Next { get; set; }
    }

    public class SingleLinkedList<T>
    {
        public SingleLinkedList()
        {
            this.First = default(Node<T>);
            this.Last = default(Node<T>);
        }

        public Node<T> First { get; set; }
        public Node<T> Last { get; set; }
        

        public void AddItem(T item)
        {
            if (this.First == default(Node<T>))
            {
                this.First = this.Last = new Node<T>(item);
            }
            else
            {
                var newNode = new Node<T>(item);
                this.Last.Next = newNode;
                this.Last = newNode;
            }
        }

        public void RemoveItem(T item)
        {
            if (this.First != default(Node<T>))
            {
                if (this.First.Item.Equals(item))
                {
                    if (this.First.Next == null)
                    {
                        this.Last = null;
                    }

                    this.First = this.First.Next;
                }
                else
                {
                    var next = this.First;
                    var previous = this.First;

                    while (next!= null && !next.Item.Equals(item))
                    {
                        previous = next;
                        next = next.Next;
                    }

                    if (next != null)
                    {
                        next = next.Next;
                        previous.Next = next;
                    }

                    if (previous.Next == null)
                    {
                        this.Last = previous;
                    }
                }
            }
        }


        public void RemoveFirst()
        {
            if (this.First != default(Node<T>))
            {
                if (this.First.Next == null)
                {
                    this.First = null;
                    this.Last = null;
                }
                else
                {
                    this.First = this.First.Next;
                }
            }

        }

        public void RemoveLast()
        {
            if (this.First != default(Node<T>))
            {
                if (this.First.Next != null)
                {
                    var next = this.First;
                    var previous = this.First;

                    while (next != null && next.Next != null)
                    {
                        previous = next;
                        next = next.Next;
                    }

                    if (next != null)
                    {
                        previous.Next = null;
                        this.Last = previous;
                    }
                }
                else
                {
                    this.First = null;
                    this.Last = null;
                }
            }
            
        }

        public void ReadAll()
        {
            if (this.First != default(Node<T>))
            {
                Console.WriteLine(this.First.Item);

                var next = this.First.Next;
                while (next != null)
                {
                    Console.WriteLine(next.Item);
                    next = next.Next;
                }
            }
        }
    }
}
