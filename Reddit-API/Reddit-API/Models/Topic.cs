using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Reddit_API.Models
{
    public class Topic
    {
        public int TopicId { get; set; }
        public string Name { get; set; }
    }
}
