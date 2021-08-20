using System;
using System.Collections.Generic;
using System.Text;

namespace Primeiro.Tarefa2.Entities
{
  public class Post
  {
    public Post()
    {
    }

    public DateTime Moment { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public int Likes { get; set; }
    public List<Comment> Comments { get; set; } = new List<Comment>();

    public Post(DateTime moment, string title, string content, int likes)
    {
      Moment = moment;
      Title = title;
      Content = content;
      Likes = likes;
    }

    public void AddComment(Comment comment){
      Comments.Add(comment);
    }

    public void RemoveComment(Comment comment){
      Comments.Remove(comment);
    }

    public override string ToString()
    {
      StringBuilder sp = new StringBuilder();
      sp.AppendLine(Title);
      sp.Append(Likes);
      sp.Append(" Likes - ");
      sp.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
      sp.AppendLine(Content);
      sp.AppendLine("Comments: ");
      foreach (Comment c in Comments)
      {
          sp.AppendLine(c.Text);
      }

      return sp.ToString();
    }
  }
}