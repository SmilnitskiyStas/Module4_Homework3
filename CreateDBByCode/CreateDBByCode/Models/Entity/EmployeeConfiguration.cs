using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CreateDBByCode.Models.Entity
{
    internal class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employee").HasKey(e => e.EmployeeID);
            builder.Property(e => e.EmployeeID).HasColumnName("EmployeeId").ValueGeneratedOnAdd();
            builder.Property(e => e.FirstName).IsRequired().HasColumnName("FirstName").HasMaxLength(50);
            builder.Property(e => e.LastName).IsRequired().HasColumnName("LastName").HasMaxLength(50);
            builder.Property(e => e.HiredDate).HasColumnName("HiredDate").HasMaxLength(7);
            builder.Property(e => e.DateOfBirth).HasColumnName("DateOfBirth").HasColumnType("date");
            builder.Property(e => e.OfficeId).HasColumnName("OfficeId");
            builder.Property(e => e.TitleId).HasColumnName("TitleId");
            builder.HasOne(t => t.Title)
                .WithMany(e => e.Employees)
                .HasForeignKey(t => t.TitleId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(o => o.Office)
                .WithMany(e => e.Employees)
                .HasForeignKey(o => o.OfficeId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
