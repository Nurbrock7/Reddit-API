using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Reddit_API.Models
{
    public class Topic
    {
        public int TopicId { get; set; }
        [Required(ErrorMessage = "Please enter a topic name.")]
        public string Name { get; set; }
    }
}
