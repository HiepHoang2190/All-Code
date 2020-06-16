using System;
using System.Collections.Generic;
using System.Text;

using System.Collections;

namespace Test2
{
    class HastableDemo
    {
        public Hashtable ht = new Hashtable();
        public void Show()
        {
            //ht.Add("11", new Product()
            //{
            //    Id = 1,
            //    Name = "IP6S"
            //});
            //ht.Add("22", new Product()
            //{
            //    Id = 2,
            //    Name = "IP7"
            //});
            //ht.Add("33", new Product()
            //{
            //    Id = 3,
            //    Name = "IP8"
            //});
            //ht.Add("44", new Product()
            //{
            //    Id = 4,
            //    Name = "IPX"
            //});
            //foreach(var key in ht.Keys)
            //{
            //    Console.WriteLine(ht[key].ToString());
            //}




            ht.Add("IP6", new List<Product>(){
                new Product()
                {
                    Id =1,
                    Name = "IP6"
                },
                new Product()
                {
                    Id = 2,
                    Name = "IP6S"
                },
                new Product()
                {
                    Id = 3,
                    Name = "IP6S Plus"
                }
            });
            ht.Add("IP7", new List<Product>(){
                new Product()
                {
                    Id =1,
                    Name = "IP77"
                },
                new Product()
                {
                    Id = 2,
                    Name = "IP7S"
                },
                new Product()
                {
                    Id = 3,
                    Name = "IP7S Plus"
                }
            });

            foreach (List<Product> value in ht.Values)
            {
                foreach (Product pdt in value)
                {
                    Console.WriteLine(pdt.ToString());
                }
            }

            foreach (string key in ht.Keys)
            {
                foreach (Product pdt in (List<Product>)ht[key])
                {
                    Console.WriteLine(pdt.ToString());
                }
            }

        }

    }
}
