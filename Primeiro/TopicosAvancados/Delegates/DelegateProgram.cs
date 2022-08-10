using System;
using System.Collections.Generic;
using Primeiro.TopicosAvancados.Delegates.Services;

namespace Primeiro.TopicosAvancados.Delegates
{
  delegate double BinaryNumericOperation(double n1, double n2);
  delegate void BinaryNumericOperations(double n1, double n2);

  public class DelegateProgram
  {
    public void DelegaProgram()
    {
      double a = 10;
      double b = 12;
      BinaryNumericOperation op = CalculationServices.Sum;

      double result = op(a, b);
      Console.WriteLine(result);
    }

    public void DelegaProgram2()
    {
      double a = 10;
      double b = 12;
      BinaryNumericOperations op = CalculationServices.ShowSum;
      op += CalculationServices.ShowMax;
      op.Invoke(a, b);
    }

    public void DelegatePredicateProgram()
    {
      List<Product> list = new List<Product>();

      list.Add(new Product("TV", 900.00));
      list.Add(new Product("Mouse", 50.00));
      list.Add(new Product("Tablet", 350.50));
      list.Add(new Product("HD Case", 80.90));

      //predicate é um delegate, que faz uma referencia para uma função.
      list.RemoveAll(ProductTest);
      foreach (Product p in list)
      {
        Console.WriteLine(p);
      }
    }

    private static bool ProductTest(Product p)
    {
      return p.Price >= 100.0;
    }

    public void DelegateActionProgram()
    {
      List<Product> list = new List<Product>();

      list.Add(new Product("TV", 900.00));
      list.Add(new Product("Mouse", 50.00));
      list.Add(new Product("Tablet", 350.50));
      list.Add(new Product("HD Case", 80.90));

      //3 formas de utilizar o delegate action, podendo ainda colocar o expressão lambda dentro do ForEach
      Action<Product> act = p => { p.Price += p.Price * 0.1; };
      list.ForEach(act);

      // Action<Product> act = UpdatePrice;
      // list.ForEach(act);

      //list.ForEach(UpdatePrice);
      foreach (Product p in list)
      {
        Console.WriteLine(p);
      }
    }

    static void UpdatePrice(Product p)
    {
      p.Price += p.Price * 0.1;
    }
  }
}