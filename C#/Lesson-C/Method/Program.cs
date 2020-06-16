using System;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumTwoNumber());
            Console.ReadKey();
           
            
            
        }
        /// <summary>
        ///  hai biến firstNumber và secondNumber hiện là biến toàn cục của các hàm nằm bên trong class Program nhưng lại là biến cục bộ của class Program
        ///  Cần có từ khóa static vì các hàm sử dụng nó đều có từ khóa static
        /// </summary>

        static int firstNumber = 5;
        static int secondNumber = 10;

        /// <summary>
        /// hàm trả ra kết quả tổng của 2 số firstNumber và secondNumber
        /// </summary>
        /// <returns></returns>
        
        static int SumTwoNumber()
        {
            return firstNumber + secondNumber;
        }
    }
}
