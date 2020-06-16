using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Test2
{
    class ArrayListDemo
    {
       public ArrayList al = new ArrayList();
        public void Test()
        {
            //al.Add(1);
            //al.Add(5);
            //al.Add(6.7);
            //al.Add(new Product()
            //{
            //    Id = 1,
            //    Name = "Ip6s"
            //});
            //foreach(var item in al)
            //{
            //    Console.WriteLine(item.ToString());
            //}


            al.Add(new Product()
            {
                Id = 1,
                Name = "IP6S"
            });
            al.Add(new Product()
            {
                Id = 4,
                Name = "IP7S"
            });
            al.Add(new Product()
            {
                Id = 2,
                Name = "IP8S"
            });
            al.Add(new Product()
            {
                Id = 3,
                Name = "IP9S"
            });
            al.Sort(new CustormSort());
            foreach(var item in al)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public class CustormSort:IComparer
        {
            public int Compare(object x, object y)
            {
                return ((Product)y).Id - ((Product)x).Id;
            }
        }
    }
}
