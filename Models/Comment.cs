namespace Reddit.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string AuthorName { get; set; }
        public string Content { get; set; }
        public int Upvote { get; set; }
        public int Downvote { get; set; }
    }
}
