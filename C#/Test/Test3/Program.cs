using System;
using System.Collections;
using System.Text;
using System.Collections.Generic;
namespace Test3
{
    class Program
    {
        public static PhoneBook phoneBook = new PhoneBook();
        static void Main(string[] args)
        {
           
            Console.OutputEncoding = Encoding.UTF8;
            CreateMenu();
            Process();


        }
        public static void CreateMenu()
        {
            int option = 0;

            Console.WriteLine("PHONEBOOK MANAGEMENT SYSTEM");
            Console.WriteLine("Please select an option from 1 to 5:");
            Console.WriteLine("1. Insert Phone");
            Console.WriteLine("2. Remove Phone");
            Console.WriteLine("3. Update Phone");
            Console.WriteLine("4. Search Phone");
            Console.WriteLine("5. Sort ");
            Console.WriteLine("6. DisplayPhoneBook ");
            Console.WriteLine("7. Exit");
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

                        InsertPhone();
                        Console.WriteLine("Nhấn phím bất kỳ để về menu");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                case 2:
                    {
                        Console.Clear();

                        RemovePhone();
                        Console.WriteLine("Nhấn phím bất kỳ để về menu");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                case 3:
                    {
                        Console.Clear();
                        UpdatePhone();


                        Console.WriteLine("Nhấn phím bất kỳ để về menu");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                case 4:
                    {
                        Console.Clear();
                        SearchPhone();


                        Console.WriteLine("Nhấn phím bất kỳ để về menu");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                case 5:
                    {
                        Console.Clear();
                        SortPhone();

                        Console.WriteLine("Nhấn phím bất kỳ để về menu");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                case 6:
                    {
                        Console.Clear();
                        DisplayPhonebook();

                        Console.WriteLine("Nhấn phím bất kỳ để về menu");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                case 7:
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


        public static void InsertPhone()
        {
           
            Console.Write("Enter the number of Contacts you want to import:");
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                Console.Write("Name: ");
                var name =Helper.FormatName( Console.ReadLine());
                Console.Write("Phone number: ");
                var phoneNumber = Console.ReadLine();
                phoneBook.InsertPhone(name, phoneNumber);
            }
            Console.Clear();
            phoneBook.Display();
        }
        public static void SearchPhone()
        {
           
            Console.Write("Enter name you want search:");
            var se =Helper.FormatName( Console.ReadLine());
            phoneBook.SearchPhone(se);
           
        }
        public static void UpdatePhone()
        {
           
            phoneBook.Display();
            Console.Write("Enter name you want update PhoneNumber:");
            var up =Helper.FormatName( Console.ReadLine());
            Console.Write("Enter PhoneNumber update:");
            var num = Console.ReadLine();
            phoneBook.UpdatePhone(up, num);
            Console.WriteLine("Phonebook after update:");
            phoneBook.Display();

        }
        public static void SortPhone()
        {
            
            phoneBook.Sort();
            phoneBook.Display();
        }
        public static void DisplayPhonebook()
        {
            
            phoneBook.Display();
        }
        public static void RemovePhone()
        {
            phoneBook.Display();
            Console.Write("Enter your name you want remove: ");
            var pb =Helper.FormatName( Console.ReadLine());
            phoneBook.RemovePhone(pb);
        }




    }
}
