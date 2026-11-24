using Gem_Management_System.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gem_Management_System.Configurations
{
    public abstract class UserGemConfiguration<T> : IEntityTypeConfiguration<T> where T : UserGem
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(u => u.Name).IsRequired().HasColumnType("varchar").HasMaxLength(50);
            builder.Property(u => u.Email).IsRequired().HasColumnType("varchar").HasMaxLength(100);
            builder.Property(u => u.Phone).IsRequired().HasColumnType("varchar").HasMaxLength(11);
            builder.HasIndex(u => u.Email).IsUnique();
            builder.HasIndex(u => u.Phone).IsUnique();
            builder.ComplexProperty(u => u.Address);
        }
    }
}
