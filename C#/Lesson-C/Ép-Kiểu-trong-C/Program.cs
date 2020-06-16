using System;

/*Ví dụ: viết chương trình nhập vào 2 số a và b sau đó in ra 
 * tổng, hiệu, tích, thương của 2 số đó
 */

namespace Ép_Kiểu_trong_C
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B;// Biến chứa giá trị 2 số vừa nhập vào (kiểu số)
            int Tong, Hieu, Tich;// Biến chứa kết quả tổng, hiệu, tích
            double Thuong; //Vì phép chia có thể cho ra số thập phân nên dùng biến kiểu double để chứa nó.
            string strA, strB; //Biến chứa giá trị 2 số nhập vào từ bàn phím (kiểu chuỗi)

            Console.WriteLine("         **************************************************");
            Console.WriteLine("         *                                         			       *");
            Console.WriteLine("         *   Chuong trinh tinh tong, hieu, tich, thuong  *");
            Console.WriteLine("         *                                            		       *");
            Console.WriteLine("         **************************************************");

            Console.Write("\n Moi ban nhap so A: ");
            strA = Console.ReadLine();
            Console.Write("\n Moi ban nhap so B: ");
            strB = Console.ReadLine();
            A = int.Parse(strA);// Ép kiểu giá trị nhập vào từ kiễu chuỗi sang kiểu số nguyên, sử dụng phương thức Parse()

            B = int.Parse(strB);
            Tong = A + B;
            Hieu = A - B;
            Tich = A * B;
            Thuong = (double)A / B;// Ép kiểu số A về số thập phân để phép chia cho ra số thập phân

            Console.WriteLine($" Tong = {Tong}" );
            Console.WriteLine($" Hieu = {Hieu} ");
            Console.WriteLine($" Tich = {Tich} ");
            Console.WriteLine($" Thuong = {Thuong} ");
        }
    }
}
