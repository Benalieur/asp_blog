using Microsoft.EntityFrameworkCore;

namespace asp_blog_app.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}
    public required DbSet<BlogPost> BlogPosts {get; set; }
}