using EFProject.Model;
using EFProject.Utilities;
using Microsoft.EntityFrameworkCore;

namespace EFProject
{
    class ApplicationContext : DbContext
    {
        public DbSet<Post> Post { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Topic> Topic { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new PostConfiguration());
            modelBuilder.ApplyConfiguration(new TopicConfiguration());

            //modelBuilder.Entity<Post>()
            //.HasOne(p => p.User)
            //.WithMany(t => t.Posts)
            //.HasForeignKey(p => p.UserId);
            //.OnDelete(DeleteBehavior.Restrict);
        }
    }
}
