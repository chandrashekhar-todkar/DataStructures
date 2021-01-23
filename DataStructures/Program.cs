using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            VerifySingleLinkedList();
            VerifyDoubleLinkedList();
            VerifyStack();
            VerifyQueue();

            VerifyQuickSort();
        }

        private static void VerifyQuickSort()
        {
            int[] items = new int[] { 4, -2, 5, 6, 1, 2, 88 };

            var sortedItems = QuickSort.Sort(items, 0, items.Length);

            for (int cnt = 0; cnt < sortedItems.Length; cnt++)
            {
                Console.WriteLine(sortedItems[cnt]);
            }

            Console.ReadKey();
        }

        private static void VerifyQueue()
        {
            Console.WriteLine("Queue");
            Queue<string> que = new Queue<string>();
            Console.WriteLine("------");
            que.Push("Item1");
            que.Push("Item2");
            que.Push("Item3");

            Console.WriteLine("Pushed Items");
            que.ReadAll();
            Console.WriteLine("------");

            Console.WriteLine("Poped Item");
            var popedItem = que.Pop();
            Console.WriteLine(popedItem);
            Console.WriteLine("------");
            que.ReadAll();
            Console.WriteLine("------");
            Console.WriteLine("Poped Item");
            popedItem = que.Pop();
            Console.WriteLine(popedItem);
            Console.WriteLine("------");
            que.ReadAll();
            Console.WriteLine("------");
            Console.WriteLine("Poped Item");
            popedItem = que.Pop();
            Console.WriteLine(popedItem);
            Console.WriteLine("------");
            que.ReadAll();
            Console.WriteLine("------");
            Console.WriteLine("Poped Item");
            popedItem = que.Pop();
            Console.WriteLine(popedItem);
            que.ReadAll();
            Console.WriteLine("------");


            Console.ReadKey();
        }

        private static void VerifyStack()
        {
            Console.WriteLine("Stack");
            Stack<string> stk = new Stack<string>();
            Console.WriteLine("------");
            stk.Push("Item1");
            stk.Push("Item2");
            stk.Push("Item3");
            Console.WriteLine("Pushed Items");
            stk.ReadAll();
            Console.WriteLine("------");

            var popedItem = stk.Pop();
            Console.WriteLine("Poped Item");
            Console.WriteLine(popedItem);
            Console.WriteLine("------");
            stk.ReadAll();
            Console.WriteLine("------");
            popedItem = stk.Pop();
            Console.WriteLine("Poped Item");
            Console.WriteLine(popedItem);
            Console.WriteLine("------");
            stk.ReadAll();
            Console.WriteLine("------");
            popedItem = stk.Pop();
            Console.WriteLine("Poped Item");
            Console.WriteLine(popedItem);
            Console.WriteLine("------");
            stk.ReadAll();
            Console.WriteLine("------");
            popedItem = stk.Pop();
            Console.WriteLine(popedItem);
            stk.ReadAll();
            Console.WriteLine("------");

            Console.ReadKey();
        }

        private static void VerifySingleLinkedList()
        {
            Console.WriteLine("Single Linked List");

            var singleLinkedList = new SingleLinkedList<int>();
            singleLinkedList.AddItem(5);
            singleLinkedList.AddItem(6);
            singleLinkedList.AddItem(7);
            singleLinkedList.AddItem(8);
            singleLinkedList.AddItem(9);
            singleLinkedList.AddItem(10);

            Console.WriteLine("Added Items");

            singleLinkedList.ReadAll();

            Console.WriteLine("------");

            Console.WriteLine("Remove Item - 7");
            singleLinkedList.RemoveItem(7);
            singleLinkedList.ReadAll();

            Console.WriteLine("------");

            Console.WriteLine("Remove Item - 5");
            singleLinkedList.RemoveItem(5);
            singleLinkedList.ReadAll();

            Console.WriteLine("------");

            Console.WriteLine("Remove Item - 10");
            singleLinkedList.RemoveItem(10);
            singleLinkedList.ReadAll();

            Console.WriteLine("------");

            Console.WriteLine("Try Remove Item - 25");
            singleLinkedList.RemoveItem(25);
            singleLinkedList.ReadAll();

            Console.WriteLine("------");
            Console.ReadKey();
        }

        private static void VerifyDoubleLinkedList()
        {
            Console.WriteLine("Double Linked List");

            var doubleLinkedList = new DoubleLinkedList<int>();
            doubleLinkedList.AddItem(5);
            doubleLinkedList.AddItem(6);
            doubleLinkedList.AddItem(7);
            doubleLinkedList.AddItem(8);
            doubleLinkedList.AddItem(9);
            doubleLinkedList.AddItem(10);

            Console.WriteLine("Added Items");

            doubleLinkedList.ReadAll();

            Console.WriteLine("------");

            Console.WriteLine("Remove Item - 7");
            doubleLinkedList.RemoveItem(7);
            doubleLinkedList.ReadAll();

            Console.WriteLine("------");

            Console.WriteLine("Remove Item - 5");
            doubleLinkedList.RemoveItem(5);
            doubleLinkedList.ReadAll();

            Console.WriteLine("------");

            Console.WriteLine("Remove Item - 10");
            doubleLinkedList.RemoveItem(10);
            doubleLinkedList.ReadAll();

            Console.WriteLine("------");

            Console.WriteLine("Try Remove Item - 25");
            doubleLinkedList.RemoveItem(25);
            doubleLinkedList.ReadAll();

            Console.WriteLine("------");
            Console.ReadKey();
        }
    }
}
