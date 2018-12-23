using Microsoft.EntityFrameworkCore;
using TODOList.Entities;
using TODOList.Repositories.ModelBuilders;

namespace TODOList.Repositories
{
    public class TODOListContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<List> Lists { get; set; }
        public DbSet<Element> Elements { get; set; }

        public TODOListContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryModelBuilder());
            modelBuilder.ApplyConfiguration(new ListModelBuilder());
            modelBuilder.ApplyConfiguration(new ElementModelBuilder());

            base.OnModelCreating(modelBuilder);
        }
    }                                                                                              
}
