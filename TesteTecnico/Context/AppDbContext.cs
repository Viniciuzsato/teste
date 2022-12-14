using Microsoft.EntityFrameworkCore;
using TesteTecnico.Entity;

namespace TesteTecnico.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Produto>? Produto { get; set; }
        public DbSet<Cliente>? Cliente { get; set; }
    }
}
