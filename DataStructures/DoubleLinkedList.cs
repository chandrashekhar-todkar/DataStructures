using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class DNode<T>
    {
        public DNode(T item)
        {
            this.Item = item;
        }

        public T Item { get; set; }
        public DNode<T> Next { get; set; }
        public DNode<T> Previous { get; set; }
    }

    public class DoubleLinkedList<T>
    {
        public DoubleLinkedList()
        {
            this.First = default(DNode<T>);
            this.Last = default(DNode<T>);
        }

        public DNode<T> First { get; set; }
        public DNode<T> Last { get; set; }


        public void AddItem(T item)
        {
            if (this.First == default(DNode<T>))
            {
                this.First = this.Last = new DNode<T>(item);
            }
            else
            {
                var newNode = new DNode<T>(item);
                newNode.Previous = this.Last;
                this.Last.Next = newNode;
                this.Last = newNode;
            }
        }

        public void RemoveItem(T item)
        {
            if (this.First != default(DNode<T>))
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
                    
                    while (next != null && !next.Item.Equals(item))
                    {
                        next = next.Next;
                    }

                    if (next != null)
                    {
                        var current = next.Next;
                        var previous = next.Previous;
                        if (current != null)
                        {
                            current.Previous = previous;
                            if (current.Next == null)
                            {
                                this.Last = current;
                            }

                            if (current.Previous == null)
                            {
                                this.First = current;
                            }
                            else
                            {
                                current.Previous.Next = current;
                            }
                        }
                        else if (previous != null)
                        {
                            previous.Next = null;
                            this.Last = previous;
                        }
                        else
                        {
                            this.First = null;
                            this.Last = null;
                        }
                    }                    
                }
            }
        }


        public void RemoveFirst()
        {
            if (this.First != default(DNode<T>))
            {
                if (this.First.Next == null)
                {
                    this.First = null;
                    this.Last = null;
                }
                else
                {
                    this.First = this.First.Next;
                    this.First.Previous = null;
                }
            }

        }

        public void RemoveLast()
        {
            if (this.Last != default(DNode<T>))
            {
                this.Last = this.Last.Previous;
                this.Last.Next = null;
            }
        }

        public void ReadAll()
        {
            if (this.First != default(DNode<T>))
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