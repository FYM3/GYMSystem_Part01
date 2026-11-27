using GYMSystem_Part01.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GYMSystem_Part01.Configurations
{
    public class MemberConfiguration : GymUserConfigurations<Member>, IEntityTypeConfiguration<Member>
    {
        public new void Configure(EntityTypeBuilder<Member> builder)
        {
            builder.Property(X => X.CreatedAt).HasColumnName("JoinDate")
                                              .HasDefaultValueSql("GETDATE()");

            base.Configure(builder);
        }
    }
}
