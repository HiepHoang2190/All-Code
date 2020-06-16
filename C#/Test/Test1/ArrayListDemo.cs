using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Test1
{
    class ArrayListDemo
    {
        public ArrayList al = new ArrayList();

        public void Add()
        {   
            Console.WriteLine("Nhập số lượng sản phẩm mà bạn muốn thêm vào: ");
            var x = int.Parse(Console.ReadLine());
            
            for(int i = 0; i < x; i++)
            {
                Console.WriteLine("Nhập Id: ");
                var id = Console.ReadLine();
                Console.WriteLine("Nhập Name: ");
                var name = Console.ReadLine();
                al.Add(new Product()
                {
                    Id = int.Parse(id),
                    Name = $"{name}"
                });
               


            }


            foreach (var item in al)
            {
                Console.WriteLine(item.ToString());
            }

        }
        public void Remove()
        {
            Console.WriteLine("Nhập tên sản phẩm mà bạn muốn xóa: ");
            var pn = (Console.ReadLine());

           for(int i=0; i < al.Count; i++)
            {
                
            }


            foreach (var item in al)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
