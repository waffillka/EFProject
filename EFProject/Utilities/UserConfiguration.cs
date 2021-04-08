using EFProject.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFProject.Utilities
{
    class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.IdUser);
            builder.HasAlternateKey(b => b.PhoneNamber);
            builder.Property(b => b.Role).IsRequired().HasDefaultValue(-1).HasMaxLength(2);
            builder.Property(b => b.LastName).IsRequired().HasMaxLength(50);
            builder.Property(b => b.FirstName).IsRequired().HasMaxLength(50);
            builder.Property(b => b.Password).IsRequired();

        }
    }
}
