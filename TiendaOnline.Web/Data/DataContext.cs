﻿using Microsoft.EntityFrameworkCore;
using TiendaOnline.Web.Entities;
using TiendaOnline.Web.Models;

namespace TiendaOnline.Web.Data
{
    
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<City> Cities { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Department> Departments { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<City>()
            .HasIndex(t => t.Name)
            .IsUnique();

            modelBuilder.Entity<Country>()
            .HasIndex(t => t.name)
            .IsUnique();

            modelBuilder.Entity<Department>()
            .HasIndex(t => t.Name)
            .IsUnique();
        }
    }
}
