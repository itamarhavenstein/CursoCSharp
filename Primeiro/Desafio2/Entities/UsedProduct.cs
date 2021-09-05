using System.Globalization;
using System;

namespace Primeiro.Desafio2.Entities
{
  public class UsedProduct : Product
  {
    public Date ManufactureDate { get; set; }

    public UsedProduct() { }

    public UsedProduct(string name, double price, Date manufactureDate) : base(name, price)
    {
      ManufactureDate = manufactureDate;
    }

    public override string PriceTag()
    {
      return Name + " (used) $ " + Price.ToString("F2", CultureInfo.InvariantCulture)
      + " (Manufacture date: " + ManufactureDate.ToString("dd/MM/yyyy") + ")";
    }
  }
}