using GYMSystem_Part01.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class MembershipConfiguration : IEntityTypeConfiguration<MemberShip>
{
    public void Configure(EntityTypeBuilder<MemberShip> builder)
    {
        builder.HasKey(e => e.Id);

        builder.Property(x => x.CreatedAt)
            .HasDefaultValueSql("GETDATE()");

        builder.HasOne(m => m.Member)
            .WithMany(mem => mem.MemberSubscription)
            .HasForeignKey(m => m.MemberId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(m => m.Plan)
            .WithMany(p => p.PlanSubscription)
            .HasForeignKey(m => m.PlanId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}