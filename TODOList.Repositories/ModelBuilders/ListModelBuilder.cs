using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TODOList.Entities;

namespace TODOList.Repositories.ModelBuilders
{
    public class ListModelBuilder : IEntityTypeConfiguration<List>
    {
        public void Configure(EntityTypeBuilder<List> builder)
        {
            builder.ToTable("Lists", "TDL")
                .ForSqlServerIsMemoryOptimized()
                .HasKey(property => property.Id)
                .ForSqlServerIsClustered();

            builder.Property(property => property.Id)
                .UseSqlServerIdentityColumn();

            builder.HasMany(property => property.Elements).WithOne()
                .HasPrincipalKey(property => property.Id)
                .HasForeignKey(property => property.ListId);

            builder.Property(property => property.Description)
                .HasColumnType("VARCHAR(50)");

            builder.Property(property => property.Bookmark)
                .HasColumnType("BIT");
        }
    }
}
