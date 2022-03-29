using System;
using System.Linq;

namespace BlogPost.Services
{
    public class BlogService
    {
        public void AddBlog()
        {
            
            Console.WriteLine("Enter your Blog Title: ");
            var name = Console.ReadLine();

            var blog = new Blog();
            blog.Name = name;
            

            using (var context = new DataContext())
            {
                context.Blogs.Add(blog);
                context.SaveChanges();
            }
        }

        public void ShowBlogs()
        {
            var blog = new Blog();
            Console.WriteLine("Here is the list of Blogs");
            using (var context = new DataContext())
            {
                var blogs = context.Blogs;
                if (blogs.Any())
                {
                    foreach (var blogRead in blogs)
                    {
                        Console.WriteLine($"{blogRead.BlogId} {blogRead.Name}");
                    }
                }else
                    Console.WriteLine("No blogs to show");
            }
        }

        public void AddPost()
        {
            ShowBlogs();
            Console.WriteLine("Type the ID of the Blog to add a post to from the list above: ");
            var blogid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter post title: ");
            var title = Console.ReadLine();
            Console.WriteLine("Enter Post Content: ");
            var content = Console.ReadLine();
            var post = new Post();
            post.BlogId = blogid;
            post.Title = title;
            post.Content = content;
            using (var context = new DataContext())
            {
                context.Posts.Add(post);
                context.SaveChanges();
            }
        }

        public void ShowPosts()
        {
            ShowBlogs();
            Console.WriteLine("Enter ID of Blog's posts you would like to view from list above:");
            var blogid = Convert.ToInt32(Console.ReadLine());
            
            using (var context = new DataContext()) 
            {
                try
                {
                    var blog = context.Blogs.FirstOrDefault(x => x.BlogId == blogid);
                    

                    System.Console.WriteLine($"Posts for Blog {blog.Name}");

                    var posts = context.Posts.Where(x => x.BlogId == blogid);
                foreach (var post in posts ) {
                    System.Console.WriteLine($"\tPost {post.PostId} {post.Title}");
                }
                }
                catch (NullReferenceException e)
                {
                    Console.WriteLine("None found please go back create a post first");
                    AddPost();
                }
            }
        }
    }
    
}