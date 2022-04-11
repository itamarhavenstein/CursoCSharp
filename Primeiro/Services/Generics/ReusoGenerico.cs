using System;
using System.Collections.Generic;
using System.Globalization;
using Primeiro.Services.Generics.Entities;

namespace Primeiro.Services.Generics
{
  public class ReusoGenerico
  {
    public void Reuso()
    {

      PrintService<int> printService = new PrintService<int>();

      Console.Write(" How many values? ");
      int n = int.Parse(Console.ReadLine());

      for (int i = 0; i < n; i++)
      {
        int x = int.Parse(Console.ReadLine());
        printService.AddValue(x);
      }

      printService.Print();
      Console.WriteLine("First: " + printService.First());
    }

    public void CalculationMax()
    {
      List<Product> list = new List<Product>();

      Console.Write("Enter N: ");
      int n = int.Parse(Console.ReadLine());

      for (int i = 0; i < n; i++)
      {
        string[] vect = Console.ReadLine().Split(',');
        string name = vect[0];
        double price = double.Parse(vect[1], CultureInfo.InvariantCulture);

        list.Add(new Product(name, price));
      }

      CalculationService calculationService = new CalculationService();

      Product max = calculationService.Max(list);

      Console.WriteLine("Max:");
      Console.WriteLine(max);
    }

    public void EqualsGetHashCode()
    {
      Client a = new Client { Name = "Maria", Email = "maria@gmail.com" };
      Client b = new Client { Name = "Alex", Email = "maria@gmail.com" };

      //é mais lento que o hashCode mas é mais confiável
      Console.WriteLine(a.Equals(b));
      Console.WriteLine(a == b);
      //GetHashCode usado para quando vc tem muitas informações para comparar
      Console.WriteLine(a.GetHashCode());
      Console.WriteLine(b.GetHashCode());

      ///um exemplo para utilizar isso é quando se tem uma lista muito grande que vc
      ///precisa comparar é interesante utilizar o hashCode e depois de ter achado um que seja igual
      ///vc confirma com Equals para ter certeza do que vc está comparando.
    }

    public void HasetSortSet()
    {
      HashSet<string> set = new HashSet<string>();
      set.Add("itamar");
      set.Add("TV");
      set.Add("Notebook");

      Console.WriteLine(set.Contains("Notebook"));

      foreach (var item in set)
      {
        Console.WriteLine(item);
      }
    }

    public void HasetSortSet2()
    {
      SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };
      SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

      // PrintCollection(a);

      //union
      SortedSet<int> c = new SortedSet<int>(a);
      c.UnionWith(b);

      PrintCollection(c);
      
      //intersection
      SortedSet<int> d = new SortedSet<int>(a);
      d.IntersectWith(b);
      PrintCollection(d);

      //Difference
      SortedSet<int> e = new SortedSet<int>(a);
      e.ExceptWith(b);
      PrintCollection(e);
    }

    static void PrintCollection<T>(IEnumerable<T> collection)
    {
      foreach (T item in collection)
      {
        Console.Write(item + " ");
      }
      Console.WriteLine();
    }
  }

}