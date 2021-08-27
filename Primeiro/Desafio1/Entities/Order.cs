using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Primeiro.Desafio1.Entities.Enums;

namespace Primeiro.Desafio1.Entities
{
  public class Order
  {
    public DateTime Moment { get; set; }
    public OrderStatus Status { get; set; }
    public Client Client { get; set; }
    public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    public Order() { }

    public Order(OrderStatus status, Client client)
    {
      Moment = DateTime.Now;
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

    public override string ToString()
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendLine("Order Summary:");
      sb.Append("Order moment: ");
      sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
      sb.AppendLine("Order status: " + Status.ToString());
      sb.Append("Client: ");
      sb.AppendLine(Client.ToString());
      sb.AppendLine("Order items:");

      foreach (var item in OrderItems)
      {
        sb.AppendLine(item.ToString());
      }

      sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
      return sb.ToString();
    }
  }
}