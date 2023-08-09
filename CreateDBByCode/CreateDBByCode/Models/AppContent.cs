using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreateDBByCode.Models.Entity;
using Microsoft.EntityFrameworkCore;

namespace CreateDBByCode.Models
{
    internal class AppContent : DbContext
    {
        public DbSet<Employee> Employee { get; set; }

        public DbSet<Office> Office { get; set; }

        public DbSet<Title> Titles { get; set; }

        public DbSet<Project> Projects { get; set; }

        public DbSet<EmployeeProject> EmployeeProjects { get; set; }

        public AppContent(DbContextOptions<AppContent> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new OfficeConfiguration());
            modelBuilder.ApplyConfiguration(new TitleConfiguration());
            modelBuilder.ApplyConfiguration(new ProjectConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeProjectConfiguration());
        }
    }
}
