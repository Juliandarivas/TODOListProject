using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Text;
using TODOList.Entities;
                                                                                                                               
namespace TODOList.Repositories.ModelBuilders
{
    public class CategoryModelBuilder : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories", "TDL")
                .ForSqlServerIsMemoryOptimized()
                .HasKey(property => property.Id)
                .ForSqlServerIsClustered();

            builder.Property(property => property.Id)
                .UseSqlServerIdentityColumn();

            builder.HasMany(property => property.Lists).WithOne()
                .HasPrincipalKey(property => property.Id)
                .HasForeignKey(property => property.CategoryId);

            builder.Property(property => property.Description)
                .HasColumnType("VARCHAR(50)");

            builder.Property(property => property.Color)
                .HasColumnType("VARCHAR(6)");
        }
    }
}
