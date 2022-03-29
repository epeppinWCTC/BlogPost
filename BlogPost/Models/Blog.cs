using System.Collections.Generic;

namespace BlogPost
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string Name { get; set; }
        public virtual List<Post> Posts { get; set; } // setup for later user of "Lazy Loading"
    }
}