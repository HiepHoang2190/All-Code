using System;
using System.Collections.Generic;
using System.Text;

namespace test6
{
   public class Post : Ipost
    {   public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public float   AverageRate { get; private set; }

        public int Count { get; set; }

      
        public int[] Rates;
        public void CalculatorRate()
        {
            float total = 0;
            foreach (float item in Rates)
            {
                total += item;
            }
            AverageRate = total / Rates.Length;

        }

        public string Display()
        {
            return $"Id:{Id}, Title:{Title}, Content:{Content}, Author:{Author}, AverageRate:{AverageRate}, Count:{Count}";
        }
    }
}
