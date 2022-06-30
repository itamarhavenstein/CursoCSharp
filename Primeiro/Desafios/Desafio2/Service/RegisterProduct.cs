using System;
using System.Collections.Generic;
using Primeiro.Desafios.Desafio2.Entities;

namespace Primeiro.Desafios.Desafio2.Service
{
  public class RegisterProduct
  {
    public void RegisterProd()
    {
      Console.WriteLine("Enter the number of products: ");
      int qtd = int.Parse(Console.ReadLine());

      List<Product> products = new List<Product>();

      for (int i = 1; i <= qtd; i++)
      {
        Console.WriteLine($"Product #{i} data:");
        Console.Write("Common, used or imported (c/u/i)? ");
        char escolha = char.Parse(Console.ReadLine());
        Console.Write("Name : ");
        string name = Console.ReadLine();
        Console.Write("Price: ");
        double price = double.Parse(Console.ReadLine());

        switch (escolha)
        {
          case 'i':
            Console.Write("Customs fee: ");
            double customsFee = double.Parse(Console.ReadLine());
            ImportedProduct imported = new ImportedProduct(name, price, customsFee);
            products.Add(imported);
            break;
          case 'c':
            Product product = new Product(name, price);
            products.Add(product);
            break;
          case 'u':
            Console.Write("Manufacture date (YYYY/MM/DD): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            UsedProduct usedProduct = new UsedProduct(name,price,date);
            products.Add(usedProduct);
            break;
          default:
            Console.WriteLine("Insira o valor correto!");
            break;
        }
      }
      Console.WriteLine("PRICE TAGS: ");
      foreach (Product product in products) 
      {
          Console.WriteLine(product.PriceTag());
      }

    }
  }
}