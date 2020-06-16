using System;
using System.Collections;
using System.Text;
using System.Collections.Generic;
namespace Test5
{
    class Program
    {
        public static PhoneBook phoneBook = new PhoneBook();
        public static PhoneBookList pblist = new PhoneBookList();
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

                        //InsertPhone();
                        InsertPhone1();
                        Console.WriteLine("Nhấn phím bất kỳ để về menu");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                case 2:
                    {
                        Console.Clear();

                        //RemovePhone();
                        RemovePhone1();
                        Console.WriteLine("Nhấn phím bất kỳ để về menu");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                case 3:
                    {
                        Console.Clear();

                        //UpdatePhone();
                        UpdatePhone1();
                        Console.WriteLine("Nhấn phím bất kỳ để về menu");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                case 4:
                    {
                        Console.Clear();
                        //SearchPhone();

                        SearchPhone1();
                        Console.WriteLine("Nhấn phím bất kỳ để về menu");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                case 5:
                    {
                        Console.Clear();

                        //Sort();
                        Sort1();
                        Console.WriteLine("Nhấn phím bất kỳ để về menu");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                case 6:
                    {
                        Console.Clear();

                        //DisplayPhonebook();
                        DisplayPhonebook1();
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

        //public static void InsertPhone()
        //{
        //    Console.Write("Enter the number of Contacts you want to import:");
        //    int number =int.Parse( Console.ReadLine());
        //    for(int i = 0; i < number; i++)
        //    {
        //        Console.Write("Name: ");
        //        var name = Console.ReadLine();
        //        Console.Write("PhoneNumber: ");
        //        var phoneNumber = Console.ReadLine();
        //        phoneBook.InsertPhone(name, phoneNumber);
                
        //    }
        //    Console.Clear();
        //    phoneBook.Display();
        //}
        //public static void RemovePhone()
        //{
        //    phoneBook.Display();
        //    Console.Write("Enter your name you want to delete: ");
        //    var pb = Console.ReadLine();
        //    phoneBook.RemovePhone(pb);
        //    phoneBook.Display();
        //}
        //public static void DisplayPhonebook()
        //{

        //    phoneBook.Display();
        //}
        //public static void UpdatePhone()
        //{
        //    phoneBook.Display();
        //    Console.WriteLine("Enter your name you want update: ");
        //    var name = Console.ReadLine();
        //    Console.WriteLine("Enter your PhoneNumber you want update: ");
        //    var pb = Console.ReadLine();
        //    phoneBook.UpdatePhone(name, pb);
        //    Console.WriteLine("Phonebook after update:");
        //    phoneBook.Display();
        //}
        //public static void SearchPhone()
        //{
        //    Console.WriteLine("Enter your name you want to search: ");
        //    var name = Console.ReadLine();
        //    phoneBook.SearchPhone(name);
        //}
        //public static void Sort()
        //{
        //    phoneBook.Sort();
        //    phoneBook.Display();
        //}

        public static void InsertPhone1()
        {
            Console.Write("Enter the number of Contacts you want to import:");
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                Console.Write("Name: ");
                var name =Helper.FormatName( Console.ReadLine());
                Console.Write("PhoneNumber: ");
                var phoneNumber = Console.ReadLine();
                pblist.InsertPhone(name, phoneNumber);

            }
            Console.Clear();
            pblist.Display();
        }
        public static void RemovePhone1()
        {
            pblist.Display();
            Console.Write("Enter your name you want to delete: ");
            var pb =Helper.FormatName( Console.ReadLine());
            pblist.RemovePhone(pb);
            pblist.Display();
        }
        public static void DisplayPhonebook1()
        {

            pblist.Display();
        }
        public static void UpdatePhone1()
        {
            pblist.Display();
            Console.WriteLine("Enter your name you want update: ");
            var name =Helper.FormatName( Console.ReadLine());
            Console.WriteLine("Enter your PhoneNumber you want update: ");
            var pb = Console.ReadLine();
            pblist.UpdatePhone(name, pb);
            Console.WriteLine("Phonebook after update:");
            pblist.Display();
        }
        public static void SearchPhone1()
        {
            Console.WriteLine("Enter your name you want to search: ");
            var name =Helper.FormatName( Console.ReadLine());
            pblist.SearchPhone(name);
        }
        public static void Sort1()
        {
            pblist.Sort();
            pblist.Display();
        }
    }
}
