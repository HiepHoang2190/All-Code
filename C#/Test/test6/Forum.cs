using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace test6
{
    class Forum:Post, Ipost
    {
      public  SortedList<int,Post> Posts = new SortedList<int,Post>();

        public Forum(SortedList<Id, Post> posts)
        {
            Posts = posts;
        }
        public void Add(string name)
        {
            Posts.Add(Id, new Post()
            {   
                Title="Truyen",
                Author="Hiep",
                Content="tru tien",
               
                Id=1,
                Rates=new int[Count]

            });
        }
        private Post Check(string name, out int index)
        {
            index = -1;
            foreach (Post item in Posts)
            {
                if (item.Title.Equals(name))
                {
                    index = Posts.IndexOfValue(item);
                    return item;
                }
            }
            return null;
            
        }
    }
}
