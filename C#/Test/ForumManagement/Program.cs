using System;

namespace ForumManagement
{
    class Program
    {
        public static Forum forum = new Forum();
        public static int PostId = 0;
        static void Main(string[] args)
        {
         
            //Rating();
            //Rating();
            //CreatePost();
            //Rating();
            forum.Show();
            CreatePost();
        
            forum.Show();
        }

        public static void CreatePost()
        {
            Console.Write("Title:");
            var title = Console.ReadLine();
            Console.Write("Author:");
            var author = Console.ReadLine();
            Console.Write("Content:");
            var content = Console.ReadLine();
            var post = new Post()
            {
                Id = PostId,
                Author = author,
                Content=content,
                Title=title

            };
            forum.Add(post);

        }
        public static void Rating()
        {
            Console.Write("Enter post Id: ");
            var id = int.Parse(Console.ReadLine());
            Console.Write("Give rate value (1 to 5):");
            var rateValue = int.Parse(Console.ReadLine());
            forum.Rating(id, rateValue);
        }

        public static void UpdatePost()
        {
            Console.Write("Id");
            var id = int.Parse(Console.ReadLine());
            Console.Write("Content");
            var content =(Console.ReadLine());
            forum.Update(content, id);
        }
        public static void RemovePost()
        {
            Console.Write("Id");
            var id = int.Parse(Console.ReadLine());
            
            forum.Remove(id);
        }
        public static void SearchPost()
        {
            Console.Write("enter keyword");
            var keyword =(Console.ReadLine());

            forum.Search(keyword);
        }
    }
}
