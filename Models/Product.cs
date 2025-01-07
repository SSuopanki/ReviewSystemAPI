using NuGet.Protocol.Core.Types;

namespace ReviewSystemAPI.Models
{
    public class Product
    {
        public Guid ProductId { get; set; }
        public required string ProductName { get; set; }
        public decimal ProductRating { get; set; }
        public required List<Review> Reviews {get; set;}

    }
}
