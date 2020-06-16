using System;
using System.Collections.Generic;
using System.Text;

namespace Test4
{
  public  class MyGeneric<T> where T : class
    {
        private T[] list;
        public int Count { get; set; }
        public MyGeneric()
        {
            list = new T[0];
        }
        public T this[int index]
        {
            get
            {
                if (index >= 0 && index < list.Length)
                {
                    return list[index];
                }
                throw new IndexOutOfRangeException();
            }
            //set
            //{
            //    list[index] = value;
            //}
        }

        public void Add(T item)
        {
            Array.Resize(ref list, list.Length + 1);
            list[list.Length - 1] = item;
            CalculatorCount();

        }
        public void Remove(T item)
        {
            int pos = Find(item);
            if (pos != -1)
            {
                for(int i = pos; i < list.Length - 1; i++)
                {
                    list[i] = list[i + 1];
                }
                Array.Resize(ref list, list.Length - 1);
                CalculatorCount();
            }

        }
        public void RemoveAt(int index)
        {
            if (index >= 0 && index < list.Length)
            {
                for(int i = index; i < list.Length - 1; i++)
                {
                    list[i] = list[i + 1];

                }
                Array.Resize(ref list, list.Length - 1);
                CalculatorCount();
            }
        }

        private int Find(T item)
        {
            for(int i = 0; i < list.Length; i++)
            {
                if (list[i] == item)
                {
                    return i;
                }
            }
            return -1;
        }
        public void Clear()
        {
            list = new T[0];
        }
        private void CalculatorCount()
        {
            Count = list.Length;
        }
    }
}
