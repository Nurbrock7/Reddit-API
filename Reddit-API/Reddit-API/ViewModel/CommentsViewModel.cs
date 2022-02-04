using Reddit_API.Models;
using System.Collections.Generic;

namespace Reddit_API.ViewModel
{
    public class CommentsViewModel
    {
        public Post post { get; set; }
        public IEnumerable<comment> Comments { get; set; }
    }
}
