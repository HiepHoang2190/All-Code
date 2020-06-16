using System;
/*
 * Ví dụ 2: Kết hợp các phép toán để viết chương trình kiểm tra số nhập vào là số chẵn số lẻ
 * 
 */

namespace Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            string strSoNguyen;
            int SoNguyen;
            string KetQua;

            strSoNguyen = Console.ReadLine();
            SoNguyen = Int32.Parse(strSoNguyen);
            KetQua = (SoNguyen % 2 == 0) ? "so chan  " : "so le";

            Console.WriteLine($"{SoNguyen} là {KetQua}");

        }
    }
}
