using System;
using DDD.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DDD.Insfrastructure.Data.Mappings
{
    public class StudentMap : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.Property(c => c.Id)
                   .HasColumnName("Id");

            builder.Property(c => c.Name)
                   .HasColumnName("varchar(100)")
                   .HasMaxLength(100)
                   .IsRequired();

            builder.Property(c => c.Email)
                   .HasColumnType("varchar(100)")
                   .HasMaxLength(11)
                   .IsRequired();
        }
    }
}
