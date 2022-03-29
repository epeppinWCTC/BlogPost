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
                switch (choice)
                {
                    case "1":
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                }
            } while (choice != "x");
        }
    }
}