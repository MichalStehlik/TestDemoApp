using Microsoft.EntityFrameworkCore;
using TestDemoApp.Server.Models;

namespace TestDemoApp.Server.Libs
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; } = null!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
