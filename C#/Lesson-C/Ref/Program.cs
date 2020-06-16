using System;

namespace Ref
{
    class Program
    {

        //Trước khi thêm REF
        //static void Main(string[] args)
        //{
        //    int value = 5;
        //    Console.WriteLine("Value before Increase: " + value);

        //    IncreaseValue(value);
        //    Console.WriteLine("Value after Increase: " + value);
        //    Console.ReadKey();

        //}

        //public static void IncreaseValue(int value)
        //{
        //    value++;
        //}


        //Sau khi them ref
        static void Main(string[] args)
        {
            int value = 5;
            Console.WriteLine("Value before Increase: " + value);

            IncreaseValue(ref value);
            Console.WriteLine("Value after Increase: " + value);
            Console.ReadKey();

        }

        public static void IncreaseValue(ref int value)
        {
            value++;
        }

    }
}
