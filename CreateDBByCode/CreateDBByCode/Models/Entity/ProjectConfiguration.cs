using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CreateDBByCode.Models.Entity
{
    internal class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.ToTable(nameof(Project)).HasKey(p => p.ProjectId);
            builder.Property(p => p.ProjectId).HasColumnName("ProjectId").ValueGeneratedOnAdd();
            builder.Property(p => p.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            builder.Property(p => p.Budget).HasColumnName("Budget").HasColumnType("money");
            builder.Property(p => p.StartedDate).HasColumnName("StartedDate").HasMaxLength(7);
        }
    }
}
