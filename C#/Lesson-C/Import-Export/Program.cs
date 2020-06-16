using System;

namespace Import_Export
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("K team");
            Console.Write("Moi ban nhap ten cua minh: ");
          
            Console.WriteLine("Ten cua ban la: "  + Console.ReadLine());
            Console.WriteLine("==========================");
            Console.Write("Moi ban nhap ngay sinh: ");
            Console.WriteLine("Ngay sinh cua ban la: " + Console.ReadLine());
            Console.WriteLine("==========================");

            Console.Write("Moi ban nhap que quan: ");
            Console.WriteLine(" Que quan: " + Console.ReadLine());

            Console.ReadKey();
        }
    }
}
