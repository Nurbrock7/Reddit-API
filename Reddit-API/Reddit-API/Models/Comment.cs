namespace Reddit_API.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string Text { get; set; }
        public string UserName { get; set; }
        public int PostId { get; set; }
        public virtual Post Post { get; set; }

    }
}
