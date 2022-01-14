using Microsoft.EntityFrameworkCore;
using apiRhMySql.Models;

namespace apiRhMySql.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<apiRhMySql.Models.Setor> Setor { get; set; }
    }
}
