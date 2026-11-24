using GYMSystem_Part01.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GYMSystem_Part01.Configurations
{
    public class GymUserConfigurations<T> : IEntityTypeConfiguration<T> where T : GymUser
    {
        public void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(x => x.Name)
                .HasColumnType("nvarchar")
                .HasMaxLength(50);

            builder.Property(x => x.Phone)
                .HasColumnType("nvarchar")
                .HasMaxLength(11);

            builder.Property(x => x.Email)
                .HasColumnType("nvarchar")
                .HasMaxLength(100);

            builder.ComplexProperty(x => x.Address);

            builder.HasIndex(x => x.Email).IsUnique();
            builder.HasIndex(x => x.Phone).IsUnique();

            builder.ToTable(tableBuilder =>
            {
                tableBuilder.HasCheckConstraint(
                    "GymUser_EmailCheck",
                    "Email LIKE '%@%.com'");

                tableBuilder.HasCheckConstraint(
                    "GymUser_PhoneCheck",
                    "LEN(Phone) = 11 AND (Phone LIKE '010%' OR Phone LIKE '011%' OR Phone LIKE '012%' OR Phone LIKE '015%')");
            });
        }
    }
}