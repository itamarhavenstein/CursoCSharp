using System;
using System.Collections.Generic;

namespace Primeiro.Services.Generics.Dictionaries
{
  public class ExemploDicSort
  {
    public void DictionarExemplo()
    {
      Dictionary<string, string> cookies = new Dictionary<string, string>();
      cookies["user"] = "maria";
      cookies["email"] = "maria@gmail.com";
      cookies["phone"] = "99712234";
      cookies["phone"] = "83737388";

      Console.WriteLine(cookies["email"]);
      Console.WriteLine(cookies["phone"]);

      cookies.Remove("email");

      if (cookies.ContainsKey("email"))
      {
        Console.WriteLine(cookies["email"]);
      }
      else
      {
        Console.WriteLine("there is no email key.");
      }

      Console.WriteLine("size: " + cookies.Count);

      Console.WriteLine("All COOKIES");
      foreach(KeyValuePair<string,string> item in cookies){
        Console.WriteLine(item.Key + ": " + item.Value);
      }
    }
  }
}