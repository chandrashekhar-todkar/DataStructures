using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public static class QuickSort
    {
        public static int[] Sort(int[] items, int startIndex, int endIndex)
        {
            if (items != null && startIndex < endIndex)
            {
                var partitionIndex = Partition(items, startIndex, endIndex);
                Sort(items, 0, (partitionIndex - 1));
                Sort(items, (partitionIndex + 1), endIndex);
            }

            return items;
        }

        public static int Partition(int[] items, int startIndex, int endIndex)
        {
            int pivot = items[startIndex];
            int swapperIndex = startIndex;
            for (int counter = startIndex + 1; counter < endIndex; counter++)
            {
                if (items[counter] < pivot)
                {
                    swapperIndex++;
                    Swap(items, swapperIndex, counter);
                }
            }

            Swap(items, startIndex, swapperIndex);
            return swapperIndex;
        }

        public static void Swap(int[] items, int fromIndex, int toIndex)
        {
            var itemsLength = items.Length;
            if (fromIndex > -1 && fromIndex < itemsLength && toIndex > -1 && toIndex < itemsLength)
            {
                int tempValue = items[toIndex];
                items[toIndex] = items[fromIndex];
                items[fromIndex] = tempValue;
            }

            return;
        }
    }
}
