using System;
using System.Text;
using System.Collections;
namespace ManagaPhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            CreateMenu();
            Process();
        }
        public static void CreateMenu()
        {
            int option = 0;

            Console.WriteLine("PRODUCT MANAGEMENT SYSTEM");
            Console.WriteLine("Please select an option from 1 to 5:");
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. Remove Product");
            Console.WriteLine("3. Show Product");
            Console.WriteLine("4. Search Product");
            Console.WriteLine("5. Exit");
            Console.Write("option: ");




            Process();
        }
        public static void Process()
        {
            int option;
            int.TryParse(Console.ReadLine(), out option);


            switch (option)
            {
                case 1:
                    {
                        Console.Clear();

                        
                        Console.WriteLine("Nhấn phím bất kỳ để về menu");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                case 2:
                    {
                        Console.Clear();

                       
                        Console.WriteLine("Nhấn phím bất kỳ để về menu");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                case 3:
                    {
                        Console.Clear();

                  
                        Console.WriteLine("Nhấn phím bất kỳ để về menu");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                case 4:
                    {
                        Console.Clear();

                   
                        Console.WriteLine("Nhấn phím bất kỳ để về menu");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                case 5:
                    {
                        Environment.Exit(Environment.ExitCode);
                        break;

                    }
                default:
                    Console.WriteLine("Bạn đã nhập sai, vui lòng bấm phím bất kỳ để nhập lại");
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }
            CreateMenu();
        }
    }

}
