using Microsoft.EntityFrameworkCore;
using Identity.Domain.Entities;
using Identity.Infrastructure.Persistence.Configurations;

namespace Identity.Infrastructure.Persistence
{
    public class ExampleDbContext : DbContext
    {
        public DbSet<ExampleEntity> Examples => Set<ExampleEntity>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<ExampleEntity>(new ExampleConfiguration());


            base.OnModelCreating(modelBuilder);
        }
    }
}
