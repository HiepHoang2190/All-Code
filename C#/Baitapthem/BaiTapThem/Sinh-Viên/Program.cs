using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Lập danh sách sinh viên thi môn lập trình hướng đối tượng với thông tin sau:
// STT  Họ và tên  MSV  Điểm thành phần  Điểm thi  Điểm kết thúc
namespace Sinh_Viên
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            int n;
            Console.WriteLine("Nhập số sinh viên trong lớp: ");
            n = int.Parse(Console.ReadLine());
            sinhvien h = new sinhvien();
            sinhvien[] a = new sinhvien[100];
            sinhvien[] b = new sinhvien[100];
            for(int i = 1; i <= n; i++)
            {
                Console.Write($"Nhập thông tin cho sinh viên thứ {i}\n");
                a[i] = new sinhvien();
                a[i].thongtin();
                Console.Write("------------------------\n");
            }
            Console.WriteLine($"\n\nSTT     HỌ TÊN            MÃSV         ĐIỂMTP  ĐIỂMTHI  ĐIỂMKT");
            for(int i = 1; i <= n; i++)
            {
                Console.Write($"{i}\t");
                a[i].chitiet();
            }
            Console.WriteLine("\n\n\n DANH SÁCH SINH VIÊN PHẢI HỌC LẠI: ");
            Console.WriteLine($"\n\nSTT     HỌ TÊN            MÃSV         ĐIỂMTP  ĐIỂMTHI  ĐIỂMKT");
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"{i}\t");
                a[i].thilai();
            }

            Console.ReadLine();
        }
    }
  public  class sinhvien
    {
        public  string hoten;
        public  int masv;
        public float diemtp, diemthi, diemkt;


        public void thongtin()
        {
            Console.Write("Hãy nhập họ tên sinh viên: ");
            hoten = Console.ReadLine();
            Console.Write("Hãy nhập mã sinh viên: ");
            masv = int.Parse(Console.ReadLine());

            do
            {
                Console.Write("Hãy nhập điêm thành phần của sinh viên: ");
                diemtp = float.Parse(Console.ReadLine());

            } while (diemtp < 0 || diemtp > 10);
            do
            {
                Console.Write("Hãy nhập điểm thi của sinh viên: ");
                diemthi = float.Parse(Console.ReadLine());

            } while (diemthi < 0 || diemthi > 10);
            diemkt = diemthi * 7 / 10 + diemtp * 3 / 10;
        }
        public void thilai()
        {
            if (diemkt <= 4)
            {
                Console.WriteLine($"{hoten}\t {masv}\t {diemtp}\t {diemthi}\t {diemkt}");
            }
        }
        public void chitiet()
        {
            Console.WriteLine($"{hoten}\t {masv}\t {diemtp}\t {diemthi}\t {diemkt}");
        }
    }
}
