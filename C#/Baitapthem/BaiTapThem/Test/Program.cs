using System;
using System.Collections;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arr1 = new ArrayList();
            arr1.Add(new Person("Nguyen Van A",29));
            arr1.Add(new Person("Nguyen Van B", 19));
            arr1.Add(new Person("Nguyen Van C", 50));
            Console.WriteLine("Danh sach ban dau:");
            foreach(Person item in arr1)
            {
                Console.WriteLine(item.ToString());
            }

            arr1.Sort(new SortPerson());
            Console.WriteLine("Danh sach sap xep tang dan:");
            foreach (Person item in arr1)
            {
                Console.WriteLine(item.ToString());
            }
            ArrayList arr2 = new ArrayList(arr1);
            foreach (Person item in arr2)
            {
                Console.WriteLine(item.ToString());
            }
            arr1.Clear();
            Console.WriteLine(arr2.Capacity);
            Console.WriteLine(arr1.Capacity);
            arr2.Insert(3, "Nguyen van A" );
            foreach (Person item in arr2)
            {
                Console.WriteLine(item.ToString());
            }


        }

        public class SortPerson : IComparer
        {
            public int Compare(object x, object y)
            {
                Person p1 = x as Person;
                Person p2 = y as Person;
                if (p1 == null || p2 == null)
                {
                    throw new InvalidOperationException();
                }
                else
                {
                    if (p1.Age < p2.Age)
                    {
                        return -1;
                    }else if (p1 == p2)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
