using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Input_Day
{
    class Program
    {
        static void Main(string[] args)
        {
            int day, month, year;
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập vào ngày: ");
            day = int.Parse(Console.ReadLine());
            Console.Write("Nhập vào tháng: ");
            month = int.Parse(Console.ReadLine());
            Console.Write("Nhập vào năm: ");
            year = int.Parse(Console.ReadLine());
            DateTime date = new DateTime(year,month,day);
            Console.WriteLine(date.DayOfWeek);
        }
    }
}
