using System;

namespace BlogPost.Services
{
    public class Menu
    {
        //1. Display Blogs
        //2. Add Blog
        //3. Display Posts
        //4. Add Post

        public void ShowMenu()
        {
            var choice = "" ;
            do
            {
                Console.WriteLine("Chose an option (X to exit): ");
                Console.WriteLine("1. Display Blogs");
                Console.WriteLine("2. Add Blog");
                Console.WriteLine("3. Display Posts");
                Console.WriteLine("4. Add Post");
                choice = Console.ReadLine();
                var blogService = new BlogService();
                switch (choice)
                {
                    case "1":
                        blogService.ShowBlogs();
                        break;
                    case "2":
                        blogService.AddBlog();
                        break;
                    case "3":
                        blogService.ShowPosts();
                        break;
                    case "4":
                        blogService.AddPost();
                        break;
                }
            } while (choice != "x");
        }
    }
}