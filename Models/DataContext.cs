using Microsoft.EntityFrameworkCore;

namespace aspnet_core___Copia.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {}

        public DbSet<Chamado> Chamado { get; set; }
        public DbSet<Cliente> Clientes{get; set;}
    }
}