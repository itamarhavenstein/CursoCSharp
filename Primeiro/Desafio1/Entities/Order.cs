using System;
using System.Collections.Generic;
using Primeiro.Desafio1.Entities.Enums;

namespace Primeiro.Desafio1.Entities
{
  public class Order
  {
    public DateTime Moment { get; set; }
    public OrderStatus Status { get; set; }
    public Client Client { get; set; }
    public List<OrderItem> OrderItems { get; set; }

    public Order() { }

    public Order(DateTime moment, OrderStatus status, Client client)
    {
      Moment = moment;
      Status = status;
      Client = client;
    }

    public void AddItem(OrderItem item)
    {
      OrderItems.Add(item);
    }

    public void RemoveItem(OrderItem item)
    {
      OrderItems.Remove(item);
    }

    public double Total()
    {
      double total = 0;
      foreach (var item in OrderItems)
      {
        total += item.SubTotal();
      }
      return total;
    }
  }
}