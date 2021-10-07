using Microsoft.EntityFrameworkCore;
using MyBug.Models;

namespace MyBug.Data
{
    public class BugDbContext : DbContext
    {
        public BugDbContext(DbContextOptions<BugDbContext> options) : base(options)
        {

        }
        public DbSet<Bug> Bugs { get; set; }
    }
}
