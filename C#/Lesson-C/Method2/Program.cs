using System;

namespace Method2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\n Enter score: ");
            double score = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The grade is: " + GetGrade(score));
            
            Console.ReadKey();
        }

        public static char GetGrade(double score)
        {
            if (score >= 90.0)
            {
                return 'A';
            }
            else if (score >= 80)
            {
                return 'B'; 
            }else if (score>=70)
            {
                return 'C';
            }else if (score>=60)
            {
                return 'D';
            }else
            {
                return 'E';
            }

        }
    }   
}
