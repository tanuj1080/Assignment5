using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Bookstore.Models;

namespace Bookstore.Data
{
    public class bookstoreContext : DbContext
    {
        public bookstoreContext (DbContextOptions<bookstoreContext> options)
            : base(options)
        {
        }

        public DbSet<Bookstore.Models.Books> Books { get; set; } = default!;
        public DbSet<Bookstore.Models.Review> Review { get; set; } = default!;
        public DbSet<Bookstore.Models.Genre> Genre { get; set; } = default!;
    }
}
