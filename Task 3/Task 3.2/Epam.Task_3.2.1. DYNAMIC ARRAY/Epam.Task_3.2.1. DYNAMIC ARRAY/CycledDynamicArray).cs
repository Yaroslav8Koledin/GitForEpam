using System.Collections.Generic;

namespace Epam.Task_3._2._1.DYNAMIC_ARRAY
{
    internal class CycledDynamicArray<T> : DynamicArray<T>
    {
        private DynamicArray<T> arr;

        public CycledDynamicArray(DynamicArray<T> arr)
        {
            this.arr = arr;
        }

        public new IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; ; i++)
            {
                yield return arr[i % arr.Length];
            }
        }
    }
}
