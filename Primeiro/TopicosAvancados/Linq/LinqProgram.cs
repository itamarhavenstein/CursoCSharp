using System;
using System.Collections.Generic;
using System.Linq;
using Primeiro.TopicosAvancados.Linq.Entities;

namespace Primeiro.TopicosAvancados.Linq
{
  public class LinqProgram
  {
    public void ProgramLinq()
    {
      //Specify the data source
      int[] numbers = new int[] { 2, 3, 4, 5 };

      //define the query expression
      IEnumerable<int> result = numbers.Where(x => x % 2 == 0).Select(x => x * 10);

      foreach (int item in result)
      {
        Console.WriteLine(item);
      }
    }

    public void LinqSearch()
    {
      Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
      Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
      Category c3 = new Category() { Id = 3, Name = "Electronics", Tier = 1 };

      List<Product> products = new List<Product>(){
        new Product() {Id=1, Name= "Computer", Price =1100.0, Category = c2},
        new Product() {Id=2, Name= "Hammer", Price =90.0, Category = c1},
        new Product() {Id=3, Name= "TV", Price =1700.0, Category = c3},
        new Product() {Id=4, Name= "Notebook", Price =1300.0, Category = c2},
        new Product() {Id=5, Name= "Saw", Price =80.0, Category = c1},
        new Product() {Id=6, Name= "Tablet", Price =700.0, Category = c2},
        new Product() {Id=7, Name= "Camera", Price =700.0, Category = c3},
        new Product() {Id=8, Name= "Printer", Price =350.0, Category = c3},
        new Product() {Id=9, Name= "MacBook", Price =1800.0, Category = c2},
        new Product() {Id=10, Name= "Sound Bar", Price =700.0, Category = c3},
        new Product() {Id=11, Name= "Level", Price =70.0, Category = c1},
      };

      var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.0);
      Print("TIER 1 AND PRICE < 900:", r1);

      var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
      Print("NAMES OF PRODUCTS FROM TOOLS", r2);

      var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name });
      Print("NOMES COMEÇADOS EM C E OBJETO ANONIMO", r3);

      var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
      Print("Ordenado por preço e ordenado por nome", r4);

      var r5 = r4.Skip(2).Take(4);
      Print("Pula 2 e pega 4", r5);

      var r6 = products.First();
      Console.WriteLine("Firts Test1 {}", r6);

      var r7 = products.Where(p => p.Price > 3000.0).FirstOrDefault();
      Console.WriteLine("Firts Test2 " + r7);

      var r8 = products.Where(p => p.Id == 3).SingleOrDefault();
      Console.WriteLine("Single or default test1 "+ r8);
        var r9 = products.Where(p => p.Id == 30).SingleOrDefault();
      Console.WriteLine("Single or default test2 "+ r9);
      Console.WriteLine();

      var r10 = products.Max(p=> p.Price);
      Console.WriteLine("Max price: "+ r10);

      var r11 = products.Min(p=> p.Price);
      Console.WriteLine("Min price: "+ r11);

      var r12 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
      Console.WriteLine("Soma dos produtos Cat1 " + r12);

      var r13 = products.Where(p => p.Category.Id == 1).Average(p => p.Price);
      Console.WriteLine("Média dos produtos Cat1 " + r13);
      
      var r14 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty(0.0).Average();
      Console.WriteLine("Média sem problema "+ r14);

      var r15 = products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate((x, y) => x + y);
      Console.WriteLine("Category 1 agregate sum: " + r15);

      //Caso a categoria não exista e não tenha preços para somar irá dar erro para isso colocamos
      //o valor defaulr no agregate 0.0 assim fica resolvida caso não tenha algo para somar.
      var r16 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).Aggregate(0.0, (x, y) => x + y);
      Console.WriteLine("Category 1 agregate sum: " + r16);

      var r17 = products.GroupBy(p => p.Category);
      foreach (IGrouping<Category, Product> group in r17){
        Console.WriteLine("Category " + group.Key.Name+ ":");
        foreach(Product p in group){
          Console.WriteLine(p);
        }
      }
      Console.WriteLine();
    }

    static void Print<T>(string message, IEnumerable<T> collection)
    {
      Console.WriteLine(message);
      foreach (T obj in collection)
      {
        Console.WriteLine(obj);
      }
      Console.WriteLine();
    }
  }
}