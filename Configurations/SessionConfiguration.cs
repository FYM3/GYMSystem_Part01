using GYMSystem_Part01.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GYMSystem_Part01.Configurations
{
    public class SessionConfiguration : IEntityTypeConfiguration<Session>
    {
        public void Configure(EntityTypeBuilder<Session> builder)
        {
            builder.Property(X => X.CreatedAt)
                .HasDefaultValueSql("GETDATE()");

            builder.HasOne(X => X.Trainer)
                .WithMany(X => X.Sessions)
                .HasForeignKey(X => X.TrainerId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.ToTable(X =>
            {
                X.HasCheckConstraint("ck_CapacityConstraint", "Capacity Between 1 And 25");
                X.HasCheckConstraint("ck_StartEndDateConstraint", "EndDate > StartDate");
            });

        }
    }
}
