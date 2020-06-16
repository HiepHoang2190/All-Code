using System;

namespace Loop_For
{
    class Program
    {
        static void Main(string[] args)
        {

            //vd1
            //int n = 100;
            //int j = 0;

            //for (int i = 0; i * j < n; i++, j += 3, Console.WriteLine($"HowKTeam.com For Loop {i}"))
            //{
            //    Console.WriteLine("=======================================");
            //    Console.WriteLine($"i: {i} | j: {j} | i * j: {i*j}");
            //}
            //Console.ReadKey();


            //========================
            //VD2:Chúng ta cũng có thể vẽ một hình chữ nhật
            //rỗng NxM với vòng lặp for:
            //========================

            //int N = 10;
            //int M = 20;

            //char drawChar = '*';
            //char insideChar = ' ';


            //// Vẽ từ trên xuống
            //for (int i = 0; i < N; i++)
            //{
            //    // Vẽ từ trái sang
            //    for (int j = 0; j < M; j++)
            //    {
            //        /*
            //         * Nếu đang ở tọa độ là cạnh trên hoặc dưới i % (N - 1) == 0
            //         * hoặc đang ở cạnh trái hoặc phải (j % (M - 1) == 0)
            //         * mà không nằm ở cạnh trên hoặc dưới (i % (N - 1) != 0)
            //         * ((i % (N - 1) != 0) && (j % (M - 1) == 0))
            //         * thì vẽ ra ký tự của hình chữ nhật
            //         * ngược lại vẽ ra ký tự không thuộc hình chữ nhật
            //        */

            //        if (i % (N - 1) == 0 || ((i % (N - 1) != 0) && (j % (M - 1) == 0)))
            //        {
            //            Console.Write(drawChar);    // lúc này là ký tự *
            //        }
            //        else
            //        {
            //            Console.Write(insideChar);  // lúc này là ký tự rỗng ' '
            //        }
            //    }
            //    //mỗi lần vẽ xong một hàng thì xuống dòng
            //    Console.WriteLine();
            //}
            //Console.ReadKey();

            //===============================
            //VD3: vẽ hcn như trên nhưng có màu



            int N = 10;
            int M = 20;

            char drawChar = '=';
            char insideChar = '\'';


            // Vẽ từ trên xuống
            for (int i = 0; i < N; i++)
            {
                // Vẽ từ trái sang
                for (int j = 0; j < M; j++)
                {
                    /*
                     * Nếu đang ở tọa độ là cạnh trên hoặc dưới i % (N - 1) == 0
                     * hoặc đang ở cạnh trái hoặc phải (j % (M - 1) == 0)
                     * mà không nằm ở cạnh trên hoặc dưới (i % (N - 1) != 0)
                     * ((i % (N - 1) != 0) && (j % (M - 1) == 0))
                     * thì vẽ ra ký tự của hình chữ nhật
                     * ngược lại vẽ ra ký tự không thuộc hình chữ nhật
                    */

                    if (i % (N - 1) == 0 || ((i % (N - 1) != 0) && (j % (M - 1) == 0)))
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write(drawChar);    // lúc này là ký tự *
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(insideChar);  // lúc này là ký tự rỗng ' '
                    }
                }
                //mỗi lần vẽ xong một hàng thì xuống dòng
                Console.WriteLine();
            }
            Console.ReadKey();





        }
    }
}
