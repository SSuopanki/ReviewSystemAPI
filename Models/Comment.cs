namespace ReviewSystemAPI.Models
{
    public class Comment
    {
        public Guid CommentId { get; set; }
        public Guid UserId { get; set; }
        public required string CommentText { get; set; }
        public Guid ReviewId { get; set; }


    }
}
