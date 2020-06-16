using System;
// yêu cầu: thiết kế lớp sinh viên bao gồm các thuộc tính:
//- Họ tên, tuổi, điểm toán, điểm văn, điểm trung bình của 1 sinh viên.
//-Khai báo mảng sử dụng lớp sinh viên trên để nhập thông tin cho n sinh viên(n nhập từ bàn phím).
//= Tính điểm trung bình và in ra màn hình danh sách các sinh viên đó.
using System.Text;
namespace Class_Student
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            int n;
            Console.Write("Nhập số lượng học sinh: ");
            n = int.Parse(Console.ReadLine());
            Student[] arrStudent = new Student[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhập thông tin sinh viên thứ: {(i + 1).ToString()}");
                arrStudent[i] = new Student();
                arrStudent[i].nhap();
            }

            Console.WriteLine("Danh sách học sinh: ");
            Console.WriteLine($"Họ tên \t Tuổi \t Điểm Toán\t Điểm Văn \t Điểm Trung Bình \t ");
            
            for (int i = 0; i < n; i++)
            {
                arrStudent[i].xuat();
            }
            Console.ReadLine();
        }
    }

    class Student
    {
        private string HoTen { get; set; }
        private int Tuoi { get; set; }
        private double DiemToan { get; set; }
        private double DiemVan { get; set; }
        private double DiemTB { get; set; }

        public Student()
        {

        }

        public string HOTEN
        {
            get => HoTen;
            set => HoTen = value;
        }
        public int TUOI
        {
            get => Tuoi;
            set => Tuoi = value;
        }
        public double DIEMTOAN
        {
            get => DiemToan;
            set => DiemToan = value;
        }
        public double DIEMVAN
        {
            get => DiemVan;
            set => DiemVan = value;
        }
        public double DIEMTB
        {
            get => Sum(DiemToan,DiemVan);
            set => DiemTB = value;
        }

        public void nhap()
        {
            Console.Write("Nhập họ tên: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhập tuổi: ");
            Tuoi =int.Parse(Console.ReadLine());
            Console.Write("Nhập điểm toán: ");
             DiemToan=double.Parse(Console.ReadLine());
            if(DiemToan>10|| DiemToan < 0)
            {
                Console.WriteLine("Điểm phải nằm trong khoảng 0=>10");
                Console.Write("Nhập lại điểm toán: ");
                DiemToan = double.Parse(Console.ReadLine());
            }

            Console.Write("Nhập điểm Văn: ");
            DiemVan = double.Parse(Console.ReadLine());
            if (DiemVan > 10 || DiemVan < 0)
            {
                Console.WriteLine("Điểm phải nằm trong khoảng 0=>10");
                Console.Write("Nhập lại điểm Văn: ");
                DiemVan = double.Parse(Console.ReadLine());
            }


        }
        public void xuat()
        {
            DiemTB = Sum(DiemToan, DiemVan);
            Console.WriteLine($"{HoTen}\t {Tuoi}\t {DiemToan}\t{DiemVan}\t {DiemTB}\t");
            
        }
        public double  Sum(double dt, double dv)
        {
            return (Math.Round(((dt + dv) / 2), 2));
        }
    }
}

