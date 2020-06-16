using System;

namespace Test4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyGeneric<User> myGeneric = new MyGeneric<User>();
            myGeneric.Add(new User()
            {
                Avatar = "avatar",
                Email = "khoa.nguyen@codegym.vn",
                Id = 1
            });
            for(int i = 0; i < myGeneric.Count; i++)
            {
            // Console.WriteLine(myGeneric.list[i].ToString());
                Console.WriteLine(myGeneric[i].ToString());
            }
        }
    }
}
