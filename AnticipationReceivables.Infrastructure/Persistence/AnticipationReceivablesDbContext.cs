using AnticipationReceivables.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace AnticipationReceivables.Infrastructure.Persistence
{
    public class AnticipationReceivablesDbContext : DbContext
    {
        public AnticipationReceivablesDbContext(DbContextOptions<AnticipationReceivablesDbContext> options) : base(options)
        {

        }

        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Installment> Installments { get; set; }
        public DbSet<Anticipation> Anticipations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
