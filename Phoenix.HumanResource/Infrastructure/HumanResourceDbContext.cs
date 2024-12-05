using Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Phoenix.HumanResource.Infrastracture
{
    public class HumanResourceDbContext : DbContext
    {
        public HumanResourceDbContext(DbContextOptions<HumanResourceDbContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Department> Departments { get; set; }

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
        }
    }
}
