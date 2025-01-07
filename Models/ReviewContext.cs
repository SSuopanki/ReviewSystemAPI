using Microsoft.EntityFrameworkCore;
using ReviewSystemAPI.Models;

namespace ReviewSystemAPI.Models;
public class ReviewContext : DbContext
{
    public ReviewContext(DbContextOptions<ReviewContext> options)
        : base(options)
    {
    }

    public DbSet<Review> Review { get; set; } = null!;

}
