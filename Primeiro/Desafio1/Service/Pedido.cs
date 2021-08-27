using System;
using System.Collections.Generic;
using Primeiro.Desafio1.Entities;
using Primeiro.Desafio1.Entities.Enums;

namespace Primeiro.Desafio1.Service
{
  public class Pedido
  {
    public void PedidoCompra()
    {
      Console.WriteLine("Enter Client data: ");

      Console.Write("Name: ");
      string Name = Console.ReadLine();
      Console.Write("Email: ");
      string Email = Console.ReadLine();
      Console.Write("birth date (YYYY/MM/DD): ");
      DateTime Birth = DateTime.Parse(Console.ReadLine());

      Client client = new Client(Name, Email, Birth);

      Console.WriteLine("Enter order data: ");
      Console.WriteLine("Status: ");
      OrderStatus Status = Enum.Parse<OrderStatus>(Console.ReadLine().ToUpper());
      Console.WriteLine("How many items to this order? ");
      int QtdItems = int.Parse(Console.ReadLine());

      Order order = new Order(Status, client);
      for (int i = 1; i <= QtdItems; i++)
      {
        Console.WriteLine($"Enter #{i} item data: ");
        Console.WriteLine("Product name: ");
        string ProductName = Console.ReadLine();
        Console.WriteLine("Product price: ");
        double ProductPrice = double.Parse(Console.ReadLine());
        Console.WriteLine("Quantity: ");
        int Qtd = int.Parse(Console.ReadLine());
        Product product = new Product(ProductName, ProductPrice);
        OrderItem orderItem = new OrderItem(Qtd, ProductPrice, product);
        order.AddItem(orderItem);
      }

      Console.WriteLine(order.ToString());
    }
  }
}