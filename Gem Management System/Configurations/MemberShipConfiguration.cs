using Gem_Management_System.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gem_Management_System.Configurations
{
    public class MemberShipConfiguration : IEntityTypeConfiguration<MemberShip>
    {
        public void Configure(EntityTypeBuilder<MemberShip> builder)
        {
            builder.Property(m => m.StartDate).IsRequired().HasDefaultValueSql("GetDate()");
            builder.HasOne(m => m.Member).WithMany(m => m.MemberShips).HasForeignKey(m => m.MemberId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(m => m.Plan).WithMany(m => m.MemberShips).HasForeignKey(m => m.PlanId).OnDelete(DeleteBehavior.Restrict);


        }
    }
}
