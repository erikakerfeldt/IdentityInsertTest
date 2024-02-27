using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace IdentityInsertTest
{
    internal partial class EFCoreTestContext : DbContext
    {
        public EFCoreTestContext()
        {
        }

        public EFCoreTestContext(DbContextOptions<EFCoreTestContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseSqlServer("Server=.;Database=EFCoreTest;Integrated Security=True;TrustServerCertificate=True;")
                    .EnableSensitiveDataLogging()
                    .LogTo(Console.WriteLine, LogLevel.Trace);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CompanyConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
        }
    }
}
