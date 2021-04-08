using System.Collections.Generic;

namespace EFProject.Model
{
    class Topic
    {
        public int IdTopic { set; get; }
        public string Title { set; get; }

        public List<Post> Posts { get; set; } = new List<Post>();
    }
}
