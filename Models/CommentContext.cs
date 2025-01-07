using Microsoft.EntityFrameworkCore;
using ReviewSystemAPI.Models;

namespace ReviewSystemAPI.Models;
public class CommentContext : DbContext
{
    public CommentContext(DbContextOptions<CommentContext> options)
        : base(options)
    {
    }

    public DbSet<Comment> Comment { get; set; } = null!;

}
