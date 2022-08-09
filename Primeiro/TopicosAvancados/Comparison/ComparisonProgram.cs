using System;
using System.Collections.Generic;

namespace Primeiro.TopicosAvancados.Comparison
{
  public class ComparisonProgram
  {
    public void ComparisonProg()
    {
      List<Product> list = new List<Product>();

      list.Add(new Product("TV", 900.00));
      list.Add(new Product("Notebook", 1200.00));
      list.Add(new Product("Tablet", 400.00));
      //delegate
      //list.Sort(CompareProducts);
      //expressão lambda
      Comparison<Product>  comp = (p1,p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
      list.Sort(comp);
      
      foreach (Product p in list)
      {
        Console.WriteLine(p);
      }
    }

    private int CompareProducts(Product p1, Product p2)
    {
      return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
    }
  }
}