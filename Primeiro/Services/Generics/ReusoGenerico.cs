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

    public void EqualsGetHashCode(){
      Client a = new Client{Name = "Maria", Email = "maria@gmail.com"};
      Client b = new Client{Name = "Alex", Email = "maria@gmail.com"};

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
  }
}