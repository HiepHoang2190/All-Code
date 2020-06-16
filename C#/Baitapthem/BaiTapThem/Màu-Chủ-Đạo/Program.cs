using System;

namespace Màu_Chủ_Đạo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Mau chu dao cua hom nay: {MauSac.MauChuDao}");
         
           
        }
    }
    class MauSac
    {
        public static string MauChuDao;
        static MauSac()
        {
            DateTime now = DateTime.Now;
            switch (now.DayOfWeek)
            {
                case DayOfWeek.Friday:
                    MauChuDao = "Black";
                    break;
                case DayOfWeek.Monday:
                    MauChuDao = "Blue";
                    break;
                case DayOfWeek.Saturday:
                    MauChuDao = "Green";
                    break;
                case DayOfWeek.Sunday:
                    MauChuDao = "Yellow";
                    break;
                case DayOfWeek.Thursday:
                    MauChuDao = "Pink";
                    break;
                case DayOfWeek.Tuesday:
                    MauChuDao = "Red";
                    break;
                case DayOfWeek.Wednesday:
                    MauChuDao = "Purple";
                    break;
            }
        }
    }
}
