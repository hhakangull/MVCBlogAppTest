using System.Collections.Generic;

namespace BlogApp.Entity.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string? Name { get; set; }

        public List<Blog>? Blogs { get; set; }
    }
}