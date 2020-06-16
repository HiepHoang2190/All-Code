using System;
//Ví dụ: Viết chương trình giải phương trình bậc 1: Ax + B = 0.
namespace If_Else
{
    class Program
    {
        static void Main(string[] args)
        {
            string strA, strB;
            int A, B;
            double Nghiem;

            Console.WriteLine("         ***************************************************");
            Console.WriteLine("         *                                        			        *");
            Console.WriteLine("         *    Chuong trinh giai phuong trinh Ax + B = 0 *");
            Console.WriteLine("         *                                                 		        *");
            Console.WriteLine("         ***************************************************");



            //======================
            //KIỂU 1
            //======================


            //Console.Write("\n moi ban nhap vao so A: ");
            //strA = Console.ReadLine();
            //Console.Write("\n moi ban nhap vao so B: ");
            //strB = Console.ReadLine();

            //A = int.Parse(strA);
            //B = int.Parse(strB);
            //Nghiem = (double)-B / A;
            //if (A == 0)
            //{
            //    Console.WriteLine("Phuong trinh vo nghiem");
            //}

            //else
            //{
            //    Console.WriteLine($"Nghiem= {Nghiem} ");
            //}



            //======================
            //KIỂU 2
            //======================
            Console.Write(" Moi nhap so A: ");
            strA = Console.ReadLine();
            Console.Write(" Moi nhap so B: ");
            strB = Console.ReadLine();

            if (int.TryParse(strA, out A) == false || int.TryParse(strB, out B) == false) // kiểm tra người dùng có thực sự nhập số nguyên vào hay không. Nếu ép kiểu thành công sẽ trả về true, ngược lại trả về false
            {
                Console.WriteLine(" Du lieu nhap sai !");
                return; // Lệnh này tạm hiểu là dừng và thoát chương trình mà không thực hiện những câu lệnh sau nó nữa. Sẽ được tìm hiểu chi tiết trong bài 16 Hàm
            }
            else
            {
                Console.WriteLine($"\n Phuong trinh cua ban vua nhap la: {A}x + {B} = 0");

                if (A == 0)
                {
                    Console.WriteLine("\n Phuong trinh co vo so nghiem !");
                }
                else if (B == 0)
                {
                    Console.WriteLine("\n Phuong trinh co nghiem x = 0");
                }
                else
                {
                    Nghiem = (double)-B / A; // Ép kiểu để cho ra kết quả chính xác
                    Console.WriteLine($"\n Phuong trinh co nghiem x = {Nghiem}");
                }
            }
        }
    }
}
