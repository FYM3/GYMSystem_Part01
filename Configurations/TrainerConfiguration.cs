using GYMSystem_Part01.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GYMSystem_Part01.Configurations
{
    public class TrainerConfiguration : GymUserConfigurations<Trainer>, IEntityTypeConfiguration<Trainer>
    {
        public new void Configure(EntityTypeBuilder<Trainer> builder)
        {
            builder.Property(X => X.CreatedAt).HasColumnName("HireDate")
                                              .HasDefaultValueSql("GETDATE()");

            base.Configure(builder);
        }
    }
}
