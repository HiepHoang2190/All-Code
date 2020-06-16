using System;

namespace Swapa_b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\n Enter a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("\n Enter b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Before swap");
            Console.WriteLine($"a= {a}, b= {b}");
            Swap(ref a, ref b);
            Console.WriteLine("After swap");
            Console.WriteLine($"a= {a}, b= {b}");

            int x;
            GetValue(out  x);
            Console.WriteLine(x);

            Console.ReadKey();


        }

        public static void Swap(ref int a, ref int b)
        {
            int tmp;
            tmp = a;
            a = b;
            b = tmp;
        }
        public static void GetValue(out int x)
        {
            x = 5;
        }


    }
}
