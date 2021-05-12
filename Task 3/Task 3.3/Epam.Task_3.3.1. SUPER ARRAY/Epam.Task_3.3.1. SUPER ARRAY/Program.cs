using System;

namespace Epam.Task_3._3._1.SUPER_ARRAY
{
    internal static class Program
    { 
        public static int CompareInt(int first, int second)
        {
            if (first > second)
            {
                return 1;
            }

            if (first == second)
            {
                return 0;
            }

            return -1;
        }

        public static int Partition(int[] array, int start, int end, Func<int, int, int> compare)
        {
            int temp;
            int marker = start;
            for (int i = start; i < end; i++)
            {
                if (compare(array[i], array[end]) < 0)
                {
                    temp = array[marker];
                    array[marker] = array[i];
                    array[i] = temp;
                    marker += 1;
                }
            }

            temp = array[marker];
            array[marker] = array[end];
            array[end] = temp;
            return marker;
        }

        public static void Quicksort(int[] array, int start, int end, Func<int, int, int> compare)
        {
            if (compare != null)
            {
                if (start >= end)
                {
                    return;
                }

                int pivot = Partition(array, start, end, compare);
                Quicksort(array, start, pivot - 1, compare);
                Quicksort(array, pivot + 1, end, compare);
            }
        }

        private static void Main()
        {
        }
    }
}
