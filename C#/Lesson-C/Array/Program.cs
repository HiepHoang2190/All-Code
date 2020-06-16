using System;
//Chuyển năm dương lịch thành năm âm lịch
namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int Year; // Biến chứa giá trị năm cần tính.
            // Mảng Can chứa các giá trị can tương ứng theo bảng can
            string[] Can = { "Canh", "Tan", "Nham", "Quy", "Giap", "At", "Binh", "Dinh", "Mau", "Ky" };

            // Mảng Chi chứa các giá trị chi tương ứng theo bảng chi
            string[] Chi = { "Than", "Dau", "Tuat", "Hoi", "Ty", "Suu", "Dan", "Meo", "Thin", "Ty", "Ngo", "Mui" };


            Console.Write(" Moi ban nhap mot nam bat ky: ");

            // Nhập năm dương lịch và ép kiểu về kiểu số nguyên
            Year = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"Nam {Year} co nam am lich la: {Can[Year % 10]} {Chi[Year % 12]}");
        }
    }
}
