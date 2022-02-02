using Reddit_API.Models;
using System.Collections.Generic;

namespace Reddit_API.ViewModel
{
    public class PostViewModel
    {
        public Topic topic { get; set; }
        public IEnumerable<Post> Posts { get; set; }
    }
}
