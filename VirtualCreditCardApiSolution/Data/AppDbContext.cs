using Microsoft.EntityFrameworkCore;
using VirtualCreditCardApi.Model;

namespace VirtualCreditCardApi.Data
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VirtualCreditCard>().HasIndex(n => n.NumeroCartaoVirtual)
                .IsUnique();
            modelBuilder.Entity<Cliente>().HasIndex(c => c.cpf)
                .IsUnique();
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<VirtualCreditCard> VirtualCreditCards { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
    }
}