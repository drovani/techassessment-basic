using Microsoft.EntityFrameworkCore;

namespace TechnicalAssessment.DataServices
{
    public class BloggingContext : DbContext
    {
        public BloggingContext(DbContextOptions<BloggingContext> options) : base(options) { }

        public DbSet<BlogPost> BlogPosts { get; set; }
    }
}
