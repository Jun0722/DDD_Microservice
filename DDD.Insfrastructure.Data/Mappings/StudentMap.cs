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
            //实体属性Map
            builder.Property(c => c.Id)
                .HasColumnName("Id");

            builder.Property(c => c.Name)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(c => c.Email)
                .HasColumnType("varchar(100)")
                .HasMaxLength(11)
                .IsRequired();

            builder.Property(c => c.Phone)
                .HasColumnType("varchar(100)")
                .HasMaxLength(20)
                .IsRequired();

            //处理值对象配置，否则会被视为实体
            builder.OwnsOne(p => p.Address);

            //注意：这是EF版本的写法，Core中不能使用！！！
            //builder.Property(c => c.Address.City)
            //     .HasColumnName("City")
            //     .HasMaxLength(20);
            //builder.Property(c => c.Address.Street)
            //     .HasColumnName("Street")
            //     .HasMaxLength(20);
        }
    }
}
