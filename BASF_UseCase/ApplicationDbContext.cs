using BASF_UseCase.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BASF_UseCase
{
    public class ApplicationDbContext: IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Use of Fluent API to define the type of values to the material and quantity         
            modelBuilder.Entity<Material>().Property(prop => prop.MaterialValue).HasColumnType("char(40)").IsRequired();

            modelBuilder.Entity<Material>().Property(prop => prop.Quantity).HasPrecision(precision: 8, scale: 3);
        }

        public DbSet<Material> Materials { get; set; }
    }
}
