using Reddit.Models;

namespace Reddit.Dtos
{
    public class PostDto
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string AuthorName { get; set; }
        public string CommunityName { get; set; }

        public Post CreatePost() {
        return new Post { Title = Title, Content = Content,
            AuthorName = AuthorName, CommunityName = CommunityName };
        }
    }
}
