using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CreateDBByCode.Models.Entity
{
    internal class OfficeConfiguration : IEntityTypeConfiguration<Office>
    {
        public void Configure(EntityTypeBuilder<Office> builder)
        {
            builder.ToTable("Office").HasKey(o => o.OfficeId);
            builder.Property(o => o.OfficeId).HasColumnName("OfficeId").ValueGeneratedOnAdd();
            builder.Property(o => o.Title).HasColumnName("Title").IsRequired().HasMaxLength(100);
            builder.Property(o => o.Location).HasColumnName("Location").IsRequired().HasMaxLength(100);
        }
    }
}
