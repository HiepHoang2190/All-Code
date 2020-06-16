using System;
/*Ví dụ: Viết chương trình tính năm âm lịch từ năm dương lịch đã nhập.
 * Thuật toán tính năm âm lịch:

Năm âm lịch = Can + Chi. Vì thế cần tính được Can và Chi sau đó ghép lại là xong.
Tính Can bằng cách:
Tìm phần dư của phép chia năm dương lịch cho 10.
Tra bảng sau để tìm ra Can tương ứng
    Năm dương %10     0    1   2    3   4   5   6    7   8   9    
 *      Can          Canh Tân Nhâm Quý Giáp Ất Bính Đinh Mậu Kỷ   
 *Tìm Chi bằng cách:
Tìm phần dư của phép chia năm dương lịch cho 12.
Tra bảng sau để tìm ra Chi tương ứng:
    Năm dương%12      0    1    2   3   4  5   6   7   8   9   10  11
        Chi          Thân Dậu Tuất Hợi Tý Sửu Dần Mão Thìn Tỵ Ngọ Mùi
 * 
 * Nối Can và Chi lại để được kết quả
 * 
 * 
 */

namespace Switch_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            int Year; // Biến chứa giá trị năm cần tính.
            string Can = "", Chi = ""; // Biến chứa kết quả.

            Console.Write(" Moi ban nhap mot nam bat ky: ");
            Year = Int32.Parse(Console.ReadLine()); // Nhập năm dương lịch và ép kiểu về kiểu số nguyên

            switch (Year % 10) // Tìm Can như thuật toán đã trình bày.
            {
                case 0: // Mỗi case này tương ứng một kết quả cần tra cứu trong bảng tra cứu Can
                    Can = "Canh"; // Giá trị tương ứng với mỗi case
                    break;
                case 1:
                    Can = "Tan";
                    break;
                case 2:
                    Can = "Nham";
                    break;
                case 3:
                    Can = "Quy";
                    break;
                case 4:
                    Can = "Giap";
                    break;
                case 5:
                    Can = "At";
                    break;
                case 6:
                    Can = "Binh";
                    break;
                case 7:
                    Can = "Dinh";
                    break;
                case 8:
                    Can = "Mau";
                    break;
                case 9:
                    Can = "Ky";
                    break;
            }

            switch (Year % 12) // Tìm Chi như thuật toán đã trình bày
            {
                case 0: // Mỗi case này tương ứng một kết quả cần tra cứu trong bảng tra cứu Chi
                    Chi = "Than"; // Giá trị tương ứng với mỗi case
                    break;
                case 1:
                    Chi = "Dau";
                    break;
                case 2:
                    Chi = "Tuat";
                    break;
                case 3:
                    Chi = "Hoi";
                    break;
                case 4:
                    Chi = "Ty";
                    break;
                case 5:
                    Chi = "Suu";
                    break;
                case 6:
                    Chi = "Dan";
                    break;
                case 7:
                    Chi = "Meo";
                    break;
                case 8:
                    Chi = "Thin";
                    break;
                case 9:
                    Chi = "Ti";
                    break;
                case 10:
                    Chi = "Ngo";
                    break;
                case 11:
                    Chi = "Mui";
                    break;
            }

            Console.WriteLine($"Nam {Year} co nam am lich la: {Can} {Chi}"); // Nối Can và Chi lại để được năm âm lịch

            Console.ReadLine();
        }
    }
}
