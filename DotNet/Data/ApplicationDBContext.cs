using DotNet.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace DotNet.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions dbContextOptions) : base(dbContextOptions) {
            
        }
        public DbSet<Stock> Stock { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}
