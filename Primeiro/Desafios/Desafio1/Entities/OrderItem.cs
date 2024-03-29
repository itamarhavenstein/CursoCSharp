using System.Globalization;
using System.Text;

namespace Primeiro.Desafios.Desafio1.Entities
{
  public class OrderItem
  {
    public int Quantity { get; set; }
    public double Price { get; set; }
    public Product Product { get; set; }

    public OrderItem() { }

    public OrderItem(int quantity, double price, Product product)
    {
      Quantity = quantity;
      Price = price;
      Product = product;
    }

    public double SubTotal()
    {
      return Quantity * Price;
    }

    public override string ToString()
    {
      StringBuilder sb = new StringBuilder();
      sb.Append(Product.Name +", $");
      sb.Append(Price.ToString("F2", CultureInfo.InvariantCulture)+ ", ");
      sb.Append("Quantity: "+Quantity +", ");
      sb.Append("SubTotal: $"+ SubTotal().ToString("F2",CultureInfo.InvariantCulture));
      return sb.ToString();
    }
  }
}