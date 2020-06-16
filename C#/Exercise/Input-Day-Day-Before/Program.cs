using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Input_Day_Day_Before
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào ngày tháng năm");
            Console.Write("\nDay: ");
            int day = int.Parse(Console.ReadLine());
            Console.Write("\nMonth: ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("\nYear: ");
            int year = int.Parse(Console.ReadLine());

            DateTime date = new DateTime(year, month, day);

            //Console.WriteLine("Ngày trước đó là {0}", date.AddDays(-1));
            string datestr = date.AddDays(-1).ToString("dd/MM/yyyy");
            Console.WriteLine("ngày hôm trươc là {0}", datestr);
            Console.ReadKey();
        }
    }
}
