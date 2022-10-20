using Projeto_CMTECH_UNICAP.Models;
using Microsoft.EntityFrameworkCore;

namespace Projeto_CMTECH_UNICAP.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Usuario> usuario { get; set; }
    }
}
