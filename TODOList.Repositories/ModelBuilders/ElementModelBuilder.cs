﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TODOList.Entities;

namespace TODOList.Repositories.ModelBuilders
{
    public class ElementModelBuilder : IEntityTypeConfiguration<Element>
    {
        public void Configure(EntityTypeBuilder<Element> builder)
        {
            builder.ToTable("Elements", "TDL")
                .HasKey(property => property.Id)
                .ForSqlServerIsClustered();

            builder.Property(property => property.Id)
                .UseSqlServerIdentityColumn();

            builder.Property(property => property.Description)
                .HasColumnType("VARCHAR(50)");

            builder.Property(property => property.IsDone)
                .HasColumnType("BIT");
        }
    }
}
