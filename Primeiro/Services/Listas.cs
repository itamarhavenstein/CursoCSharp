using System;
using System.Collections.Generic;
using Primeiro.Models;

namespace Primeiro.Services
{
  public class Listas
  {
    public void UsandoListas()
    {

      List<string> list = new List<string>();
      list.Add("Maria");
      list.Add("Alex");
      list.Add("Bob");
      list.Add("Itamar");
      list.Insert(2, "Sandra");

      foreach (var item in list)
      {
        Console.WriteLine(item);
      }
      Console.WriteLine("List count: " + list.Count);

      string s1 = list.Find(x => x[0] == 'A');
      Console.Write("First 'A': " + s1);

      var s2 = list.FindLast(x => x[0] == 'B');
      Console.WriteLine("Last 'B': " + s2);

      int pos1 = list.FindIndex(x => x[0] == 'A');


    }

    public void AlugandoQuartos()
    {
      Pessoa[] quartos = new Pessoa[10];

      Console.WriteLine("Quantos quartos serão alugados? ");
      var qtd = int.Parse(Console.ReadLine());

      for (var i = 1; i <= qtd; i++)
      {
        Console.WriteLine("Aluguel #{0}: ", i);
        Console.Write("Nome: ");
        var nome = Console.ReadLine();
        Console.Write("Email: ");
        var email = Console.ReadLine();
        Console.Write("Quarto: ");
        var quarto = int.Parse(Console.ReadLine());
        Console.WriteLine();
        var hospede = new Pessoa(nome, email);
        quartos[quarto - 1] = hospede;
      }

      Console.WriteLine("Quartos ocupados:");
      for (var i = 0; i < quartos.Length; i++)
      {
        if (quartos[i] != null)
        {
          Console.WriteLine("{0}: {1}, {2}", i + 1, quartos[i].Nome, quartos[i].Email);
        }
      }
    }

  }
}