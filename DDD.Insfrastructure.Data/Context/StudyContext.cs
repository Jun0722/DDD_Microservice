using System;
using System.IO;
using DDD.Domain.Models;
using DDD.Insfrastructure.Data.Mappings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DDD.Insfrastructure.Data.Context
{
    public class StudyContext:DbContext
    {
        public DbSet<Student> Students { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StudentMap());

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                                                   .AddJsonFile("appsettings.json")
                                                   .Build();
            optionsBuilder.UseMySql(config.GetConnectionString("DefaultConnection"));
                
        }
    }
}
