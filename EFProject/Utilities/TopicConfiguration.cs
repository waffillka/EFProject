using EFProject.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFProject.Utilities
{
    class TopicConfiguration : IEntityTypeConfiguration<Topic>
    {
        public void Configure(EntityTypeBuilder<Topic> builder)
        {
            //builder.Property(b => b.Title).IsRequired();
            builder.HasKey(b => b.IdTopic);
            builder.Property(b => b.Title).IsRequired().HasMaxLength(150);
        }
    }
}
