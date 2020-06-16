using System;
/*
 * Viết chương trình cho phép người dùng nhập tên của mình và hiển thị câu: HowKteam.com xin chào <Tên vừa nhập>.
Viết chương trình nhập vào các thông tin:
Tên
Tuổi
Địa chỉ
Xuất ra màn hình theo định dạng: Bạn tên <Tên>, <Tuổi> tuổi, ở <Địa chỉ>
 * 
 */

namespace Import_Export_ex
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            a = b = (c = 9) + 1; // khởi tạo giá trị: a = 10, b = 10, c = 9
            a += b; // tương đương a = a + b
            b = c++; // thực hiện gán giá trị c cho biến b sau đó thực hiện c = c + 1
            --c; // thực hiện c = c - 1

            Console.WriteLine($" a = {a}, b = {b}, c = {c}");

            Console.ReadKey();
        }
    }
}
