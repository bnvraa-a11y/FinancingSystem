using FinancingSystem.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace FinancingSystem.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<FinancingApplication> FinancingApplications { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Role>().HasData(
                new Role { Id = 1, Name = "Customer" }, 
                new Role { Id = 2, Name = "Employee" },  
                new Role { Id = 3, Name = "Admin" }     
            );
        }
    }
}