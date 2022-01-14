using Microsoft.EntityFrameworkCore;
using apiRhMySql.Models;

namespace apiRhMySql.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Cargo> Cargo { get; set; }
        public DbSet<Setor> Setor { get; set; }
        public DbSet<Colaborador> Colaborador { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().HasKey(u => new { u.IdUsuario });
        }
    }
}
