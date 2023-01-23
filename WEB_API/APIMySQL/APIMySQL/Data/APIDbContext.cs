using APIMySQL.Models;
using Microsoft.EntityFrameworkCore;

namespace APIMySQL.Data
{
    public class APIDbContext : DbContext
    {
        public APIDbContext(DbContextOptions<APIDbContext> options) : base(options) { }

        public DbSet<Estado> Estado { get; set; }
    }
}
