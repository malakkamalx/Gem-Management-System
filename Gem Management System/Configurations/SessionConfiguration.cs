using Gem_Management_System.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gem_Management_System.Configurations
{
    public class SessionConfiguration : IEntityTypeConfiguration<Session>

    {
        
         void IEntityTypeConfiguration<Session>.Configure(EntityTypeBuilder<Session> builder)
        {
            builder.ToTable("Sessions", t => { t.HasCheckConstraint("CK_Session_CapaCity","[Capacity] between 1 and 25");
                t.HasCheckConstraint("CK_Session_EndDate","[EndDate]>[StartDate]");
            });

            builder.HasOne(s => s.Trainer).WithMany(s => s.Sessions).HasForeignKey(s => s.TrainerId).OnDelete(DeleteBehavior.Restrict);

        }
    }
}
