using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//lập danh sách quản lý hàng hóa trong siêu thị với thông tin: Mã hàng hóa,
//tên hàng hóa, số lượng, đơn giá.Sau đó in ra màn hình danh sách các loại hàng hóa có
// số lượng nhỏ hơn 5 để nhập hàng về
namespace hanghoa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            int n;
            Console.WriteLine("Nhập số lượng loại hàng hóa: ");
            n = int.Parse(Console.ReadLine());
            hanghoa[] arr = new hanghoa[100];
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Nhập thông tin cho loại hàng thứ {i}");
                arr[i] = new hanghoa();
                arr[i].nhap();
            }
            Console.WriteLine("\n\nSTT     MÃ HÀNG HÓA         TÊN HÀNG HÓA          ĐƠN GIÁ     SỐ LƯỢNG");
            for(int i = 1; i <= n; i++)
            {
                Console.Write($"{i}\t");
                arr[i].xuat();
            }
            Console.WriteLine("\n\n DANH SÁCH HÀNG HÓA CẦN NHẬP VỀ LÀ: \n");
            for(int i = 1; i <= n; i++)
            {
                Console.Write($"{i}\t");
                arr[i].nhaphang();

            }
        }
    }
    class hanghoa
    {
        public string mahanghoa, ten;
        public float dongia;
        public int soluong;
        public void nhap()
        {
            Console.Write("Nhập mã hàng hóa: ");
            mahanghoa = Console.ReadLine();
            Console.Write("Nhập tên hàng hóa: ");
            ten = Console.ReadLine();
            Console.Write("Nhập giá hàng hóa: ");
            dongia = float.Parse(Console.ReadLine());
            Console.Write("Nhập số lượng hàng hóa: ");
            soluong = int.Parse(Console.ReadLine());

        }

        public void xuat()
        {
            Console.WriteLine($"{mahanghoa}\t{ten}\t{dongia}\t{soluong}");
        }
        public void nhaphang()
        {
            if (soluong < 5)
            {
                Console.WriteLine($"STT\t{ mahanghoa}\t{ten}\t{dongia}\t{soluong}");
            }
            else
            {
                Console.WriteLine("Không có hàng hóa cần nhập thêm");
            }
        }
    }
}
