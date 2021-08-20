using System;
using Primeiro.Tarefa2.Entities;

namespace Primeiro.Tarefa2.Services
{
    public class SocialPosts
    {
        public void SocialMidia()
        {
            Comment c1 = new Comment("Have a nice trip");
            Comment c2 = new Comment("Wow that's awesome!");
            Post p1 = new Post(
              DateTime.Parse("2018/06/21 13:05:44"),
              "Traveling to New Zealand",
              "I'm going to visit this wonderful country!",
              12
            );
            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment("Good night");
            Comment c4 = new Comment("May the force be with you");
            Post p2 = new Post(
              DateTime.Parse("2018/07/28 23:14:19"),
              "Good night guys",
              "See you tomorrow",
              5
            );
            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}