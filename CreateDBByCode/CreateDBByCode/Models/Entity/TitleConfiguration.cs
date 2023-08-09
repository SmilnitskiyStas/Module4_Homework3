using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CreateDBByCode.Models.Entity
{
    internal class TitleConfiguration : IEntityTypeConfiguration<Title>
    {
        public void Configure(EntityTypeBuilder<Title> builder)
        {
            builder.ToTable("Title").HasKey(t => t.TitleId);
            builder.Property(t => t.TitleId).HasColumnName("TitleId").ValueGeneratedOnAdd();
            builder.Property(t => t.Name).IsRequired().HasColumnName("Name").HasMaxLength(50);
        }
    }
}
