using Gem_Management_System.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gem_Management_System.Configurations
{
    public class TrainerConfiguratin:UserGemConfiguration<Trainer>
    {
        public override void Configure(EntityTypeBuilder<Trainer> builder)
        {
            base.Configure(builder);
            builder.ToTable("Trainers", t =>
            {
                t.HasCheckConstraint("CK_Trainer_Email", "[Email] LIKE '_%@_%._%'");
                t.HasCheckConstraint("CK_Trainer_Phone",
                    "[Phone] LIKE '010%_' OR [Phone] LIKE '011%_' OR [Phone] LIKE '012%_' OR [Phone] LIKE '015%_'");
            });
            builder.Property(t => t.HireDate).HasDefaultValueSql("GETDATE()");
            builder.Property(t => t.Speciality).IsRequired().HasMaxLength(100);
        }
    }
}
