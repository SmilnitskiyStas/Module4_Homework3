using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CreateDBByCode.Models.Entity
{
    internal class EmployeeProjectConfiguration : IEntityTypeConfiguration<EmployeeProject>
    {
        public void Configure(EntityTypeBuilder<EmployeeProject> builder)
        {
            builder.ToTable(nameof(EmployeeProject)).HasKey(ep => ep.EmployeeProjectId);
            builder.Property(ep => ep.EmployeeProjectId).HasColumnName("EmployeeProjectId").ValueGeneratedOnAdd();
            builder.Property(ep => ep.Rate).HasColumnName("Rate").HasColumnType("money");
            builder.Property(ep => ep.StartedDate).HasColumnName("StartedDate").HasMaxLength(7);
            builder.Property(ep => ep.EmployeeId).HasColumnName("EmployeeId");
            builder.Property(ep => ep.ProjectId).HasColumnName("ProjectId");
            builder.HasOne(e => e.Employee)
                .WithMany(ep => ep.Projects)
                .HasForeignKey(e => e.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(p => p.Project)
                .WithMany(ep => ep.Employees)
                .HasForeignKey(p => p.ProjectId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
