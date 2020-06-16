using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
namespace Test2
{
    class SortedListDemo
    {
        SortedList sl = new SortedList();
        
        public void Show()
        {
            sl.Add(3, "Vũ");
            sl.Add(4, "Hoàng");
            sl.Add(1, "Minh");
            sl.Add(2, "Tiến");
            sl.Add(36, "Giang");

           
            foreach(var key in sl.Keys)
            {
                Console.WriteLine(sl[key].ToString());
            }
        }
    }
}
