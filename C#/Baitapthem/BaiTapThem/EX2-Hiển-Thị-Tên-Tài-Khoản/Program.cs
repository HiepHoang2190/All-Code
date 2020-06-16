using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Hiển thị lên màn hình tài khoản gồm các thông tin sau:
//  Chủ tài khoản/ Số tài khoản/ Số dư
namespace EX2_Hiển_Thị_Tên_Tài_Khoản
{
    class Program
    {
        static void Main(string[] args)
        {   Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            int n;
            thuebao[] arr = new thuebao[100];
            Console.WriteLine("DANH SÁCH TÀI KHOẢN NGÂN HÀNG CÔNG THƯƠNG VN");
            Console.Write("Nhập số tài khoản trong danh sách: ");
            n = int.Parse(Console.ReadLine());
            for(int f = 1; f <= n; f++)
            {
                arr[f] = new thuebao();
                arr[f].nhap();
            }
            Console.WriteLine("CHỦ TÀI KHOẢN \t SỐ TÀI KHOẢN \t SỐ DƯ");
            for(int f = 1; f <= n; f++)
            {
                arr[f].xuat();
            }
            Console.ReadLine();
        }
    }

    class thuebao
    {
        string chutaikhoan;
        double sotaikhoan, sodu;
        public void nhap()
        {
            Console.WriteLine("Hãy nhập chủ tài khoản: ");
            chutaikhoan = Console.ReadLine();
            Console.WriteLine("Hãy nhập số tài khoản: ");
            sotaikhoan = double.Parse(Console.ReadLine());
            Console.WriteLine("Hãy nhập số dư tài khoản: ");
            sodu = double.Parse(Console.ReadLine());
        }
        public void xuat()
        {
            Console.WriteLine($"{chutaikhoan}\t{sotaikhoan}\t {sodu}\t");
        }
    }
}
