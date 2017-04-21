namespace WannabeReddit.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WannabeReddit.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WannabeReddit.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WannabeReddit.Models.ApplicationDbContext context)
        {
            var posts = new List<Post>
            {
                new Post  {
                    Title = "First Day of C#",
                    Body = "It was been of my best day yet. I was able to keep up with the content in class and complete the level 3 assignment!  ",
                    UpVotes = 20, DownVotes = 1000
                },

               new Post  {
                    Title = "Second Day of C#",
                    Body = "Today I learned English",
                    UpVotes = 1, DownVotes = 9001
                },

               new Post  {
                    Title = "Third Day of C#",
                    Body = "Sempai noticed me today. But then he made fun of my XS T-shirt. Forever alone",
                    UpVotes = 0, DownVotes = 100000
                },

            };

            posts.ForEach(post => context.Posts.AddOrUpdate(p => new { p.Title }, post));
            //context.SaveChanges();



        }
    }
}
