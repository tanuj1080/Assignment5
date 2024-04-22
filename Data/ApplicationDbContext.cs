using Bookstore.Models;
using Microsoft.EntityFrameworkCore;

namespace Bookstore.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Review> Reviews { get; set; }
    }
}
