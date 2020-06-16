using System;

namespace Out
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 5;
            Console.WriteLine("Value before Increase: " + value);

            IncreaseValue(out value);
            Console.WriteLine("Value after Increase: " + value);
            Console.ReadKey();

        }

        public static void IncreaseValue(out int value)
        {
            value = 0;
            value++;
        }
    }
}
