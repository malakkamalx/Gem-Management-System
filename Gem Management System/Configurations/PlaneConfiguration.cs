using Gem_Management_System.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gem_Management_System.Configurations
{
    public class PlaneConfiguration : IEntityTypeConfiguration<Plan>
    {
        public void Configure(EntityTypeBuilder<Plan> builder)
        {
            builder.ToTable("Plans", t =>
            {
                t.HasCheckConstraint("CK_Plan_DurationDays","[DurationDays] BETWEEN 1 AND 365 ");
            });
            builder.Property(p => p.Name).IsRequired().HasColumnType("varchar").HasMaxLength(50);
            builder.Property(p => p.Description).IsRequired().HasMaxLength(500);
            builder.Property(p => p.Price).HasPrecision(10,2);
            builder.Property(p => p.IsActive).HasDefaultValue(true);
        }
    }
}
