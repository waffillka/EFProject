using EFProject.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace EFProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            using (ApplicationContext db = new SampleContextFactory().CreateDbContext(args))
            {

                Topic topic1 = new Topic() { Title = "Topic1" };
                Topic topic2 = new Topic() { Title = "Topic2" };
                Topic topic3 = new Topic() { Title = "Topic3" };
                db.Topic.AddRange(topic1, topic2, topic3);
                User user1 = new User()
                {
                    FirstName = "George",
                    LastName = "Sebik",
                    PhoneNamber = "+375444569273",
                    Password = "Painkiller413",
                    Birthday = new DateTime(2000, 6, 27),
                    Role = 1,
                };
                User user2 = new User()
                {
                    FirstName = "Dminty",
                    LastName = "Sachok",
                    PhoneNamber = "+375444569272",
                    Password = "Painkiller412",
                    Birthday = new DateTime(1999, 9, 22),
                    Role = 2,
                };
                db.User.AddRange(user1, user2);


                Post post1 = new Post()
                {
                    Title = "TitlePost1",
                    TextPost = "TextPost1",
                    User = user1,
                    Topic = topic1,
                };

                Post post2 = new Post()
                {
                    Title = "TitlePost2",
                    TextPost = "TextPost2",
                    User = user1,
                    Topic = topic2,
                };

                Post post3 = new Post()
                {
                    Title = "TitlePost3",
                    TextPost = "TextPost3",
                    User = user2,
                    Topic = topic3,
                };

                db.Post.AddRange(post1, post2, post3);
                db.SaveChanges();

            }

            Console.WriteLine("Data is saved");
            using (ApplicationContext db = new SampleContextFactory().CreateDbContext(args))
            {
                //List<Post> posts = db.Posts.
                var temp = db.Post.Include(b => b.User).Include(b => b.Topic).ToList();

                foreach (var n in temp)
                {
                    Console.WriteLine($"TitlePost = {n.Title}\n TextPost = {n.TextPost}\n" +
                        $" TitleTopic = {n.Topic.Title}\n" +
                        $"FirstName = {n.User.FirstName}\n" +
                        $"LastName = {n.User.LastName}\n " +
                        $"PhoneNamber = {n.User.PhoneNamber}\n" +
                        $"Password = {n.User.Password}\n" +
                        $"Birthday = {n.User.Birthday}\n" +
                        $"Role = {n.User.Role}");
                }

                Console.WriteLine("Show All POSTS");
            }
        }
    }
}

