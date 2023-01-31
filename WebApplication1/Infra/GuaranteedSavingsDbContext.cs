using Microsoft.EntityFrameworkCore;
using System.Reflection;
using WebApplication1.Domain;

namespace WebApplication1.Infra
{
    public class GuaranteedSavingsDbContext:DbContext
    {
        public GuaranteedSavingsDbContext(DbContextOptions<GuaranteedSavingsDbContext> options):base(options) { }

        public DbSet<CalculateFormula> CalculateFormula { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }
}
