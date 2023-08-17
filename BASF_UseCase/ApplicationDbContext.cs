using BASF_UseCase.Entities;
using Microsoft.EntityFrameworkCore;

namespace BASF_UseCase
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Usar API Fluente
            modelBuilder.Entity<Material>().Property(prop => prop.MaterialValue).HasMaxLength(150).IsRequired();
            modelBuilder.Entity<Material>().Property(prop => prop.Quantity).HasPrecision(precision: 5, scale: 2);
        }

        public DbSet<Material> Materials { get; set; }
    }
}
