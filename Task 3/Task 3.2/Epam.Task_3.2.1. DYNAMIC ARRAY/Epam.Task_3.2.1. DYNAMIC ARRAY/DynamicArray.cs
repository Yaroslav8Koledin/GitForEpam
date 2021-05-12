using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Epam.Task_3._2._1.DYNAMIC_ARRAY
{
    public class DynamicArray<T> : IEnumerable, IEnumerable<T>, ICloneable
    {
        private T[] arr;
        private int capacity;
        private int length;

        public DynamicArray()
        {
            capacity = 8;
            arr = new T[capacity];
        }

        public DynamicArray(int capacity)
        {
            if (capacity < 0)
            {
                throw new System.ArgumentException("You cannot create an array from a negative number of elements");
            }

            this.capacity = capacity;
            arr = new T[capacity];
        }

        public DynamicArray(IEnumerable<T> collection)
        {
            if (collection == null)
            {
                throw new System.ArgumentException("You can't create a collection that doesn't exist");
            }

            int count = collection.Count();
            arr = new T[count];
            int k = 0;
            foreach (var i in collection)
            {
                arr[k] = i;
                k++;
            }
        }

        public int Capacity
        {
            get
            {
                return capacity;
            }

            set
            {
                if (value <= Capacity)
                {
                    throw new ArgumentException("The initial size of the list more to reduce the size, remove some elements");
                }

                T[] newItems = new T[value];
                capacity = value;
                if (length > 0)
                {
                    Array.Copy(arr, 0, newItems, 0, length);
                }

                arr = newItems;
            }
        }

        public int Length
        {
            get
            {
                return length;
            }
        }

        public T this[int index]
        {
            get
            {
                if (index >= length)
                {
                    throw new IndexOutOfRangeException("Index out of range");
                }

                if (index < 0)
                {
                    return arr[length + index];
                }

                return arr[index];
            }
            set
            {
                if (index >= length)
                {
                    throw new IndexOutOfRangeException("Index out of range");
                }

                if (index < 0)
                {
                    arr[length + index] = value;
                }
                else
                {
                    arr[index] = value;
                }
            }
        }

        public void Add(T item)
        {
            if (length == Capacity)
            {
                Capacity *= 2;
            }

            arr[length++] = item;
        }

        public void AddRange(IEnumerable<T> ts)
        {
            if (ts == null)
            {
                throw new System.ArgumentException("This collection is not exist");
            }

            int count = ts.Count();
            while (length + count > capacity)
            {
                Capacity *= 2;
            }
            int k = length;
            foreach (var i in ts)
            {
                arr[k] = i;
                k++;
            }
            length += count;
        }

        public void RemoveAt(int index)
        {
            if (index > length)
            {
                throw new System.ArgumentException("The specified index is larger than the list size");
            }
            else if (index >= 0)
            {
                Array.Copy(arr, index + 1, arr, index, length - index);
            }
            else
            {
                Array.Copy(arr, length + index + 1, arr, length + index, -index);
            }

            length--;
        }

        public bool Remove(T item)
        {
            for (int i = 0; i < length; i++)
            {
                if (arr[i].Equals(item))
                {
                    RemoveAt(i);
                    return true;
                }
            }

            return false;
        }

        public bool Insert(T item, int index)
        {
            if (index > length || -index > length)
            {
                throw new ArgumentOutOfRangeException("Choose other index");
            }
            else
            {
                if (length + 1 > Capacity)
                {
                    Capacity *= 2;
                }

                if (index >= 0)
                {
                    for (int i = length; i > index; i--)
                    {
                        arr[i] = arr[i - 1];
                    }

                    arr[index] = item;
                }
                else
                {
                    for (int i = length; i > length + index; i--)
                    {
                        arr[i] = arr[i - 1];
                    }

                    arr[length + index] = item;
                }

                length++;
                return true;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i1 = 0; i1 < length; i1++)
            {
                yield return arr[i1];
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i1 = 0; i1 < length; i1++)
            {
                yield return arr[i1];
            }
        }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public T[] ToArray()
        {
            var newArray = new T[length];
            Array.Copy(arr, 0, newArray, 0, length);
            return newArray;
        }
    }
}
