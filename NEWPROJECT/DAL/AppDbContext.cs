using Microsoft.EntityFrameworkCore;
using NEWPROJECT.Models;

namespace NEWPROJECT.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) { }

        public  DbSet<Blog> blogs { get; set; }
        public DbSet<Tag> tags { get; set; }
        public DbSet<TagBlog> tagblogs { get; set; }
        




    }
}
