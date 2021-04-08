using EFProject.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFProject.Utilities
{
    class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasKey(b => b.IdPost);
            builder.Property(b => b.Title).IsRequired().HasMaxLength(100);
            builder.HasOne(b => b.User).WithMany(b => b.Posts).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(b => b.Topic).WithMany(b => b.Posts).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
