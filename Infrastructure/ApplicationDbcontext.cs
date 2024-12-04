using Infrastructure.Models.HumanResourceModels;
using Infrastructure.Models.RegistryModels;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class ApplicationDbcontext : DbContext
    {
        public ApplicationDbcontext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Department> Departments { get; set; }

        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .Property(x => x.CreatedDate)
                .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<Employee>()
                .Property(x => x.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Department>()
                .Property(x => x.CreatedDate)
                .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<Department>()
                .Property(x => x.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Customer>()
                .Property(x => x.CreatedDate)
                .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<Customer>()
                .Property(x => x.Id)
                .ValueGeneratedOnAdd();
        }
    }
}
