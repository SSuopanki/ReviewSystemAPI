namespace ReviewSystemAPI.Models
{
    public class Review
    {
        public Guid ReviewId { get; set; }
        public required string ReviewTitle { get; set; }
        public required string ReviewText { get; set; }
        public DateTime ReviewDate { get; set; }
        public Guid UserId { get; set; }
        public required string UserName { get; set; }
        public int Likes { get; set; }
        public int Dislikes { get; set; }
        public decimal Rating { get; set; }
        public Guid ProductId { get; set; }

    }
}
