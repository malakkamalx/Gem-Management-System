using Gem_Management_System.Configurations;
using Gem_Management_System.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gem_Management_System.Configurations
{
    public class MemberConfiguration : UserGemConfiguration<Member>
    {
        public override void Configure(EntityTypeBuilder<Member> builder)
        {
            base.Configure(builder);
            builder.ToTable("Members", t =>
            {
                t.HasCheckConstraint("CK_Member_Email", "[Email] LIKE '_%@_%._%'");

                t.HasCheckConstraint("CK_Member_Phone", "[Phone] LIKE '010%_' OR [Phone] LIKE '011%_' OR [Phone] LIKE '012%_' OR [Phone] LIKE '015%_'");
            });
            builder.Property(m => m.JoinDate).HasDefaultValueSql("GETDATE()");
        }
    }
}