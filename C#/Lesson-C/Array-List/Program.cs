using System;
using System.Collections;
namespace Array_List
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrPersons = new ArrayList();

            arrPersons.Add(new Person("Nguyen Van A", 18));
            arrPersons.Add(new Person("Nguyen Van B", 25));
            arrPersons.Add(new Person("Nguyen Van C", 20));

            Console.WriteLine("Danh sach Person ban dau: ");
            foreach (Person item in arrPersons)
            {
                Console.WriteLine(item.ToString());
            }
            arrPersons.Sort(new SortPersons());
            Console.WriteLine();
            Console.WriteLine("Danh sach Person da duoc sap xep theo tuoi tang dan: ");
            foreach (Person item in arrPersons)
            {
                Console.WriteLine(item.ToString());
            }

        }
    }
    public class SortPersons : IComparer
    {
        public int Compare(object x, object y)
        {
            Person p1 = x as Person;
            Person p2 = y as Person;
            if (p1 == null || p2 == null)
            {
                throw new InvalidCastException();
            }
            else
            {
                if (p1.Age < p2.Age)
                {
                    return -1;
                }
                else if (p1.Age == p2.Age)
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
