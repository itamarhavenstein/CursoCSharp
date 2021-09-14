using Primeiro.Enumerador;
using System;

namespace Primeiro.Models
{
  public class Circulo : Shape
  {
    public double Raio { get; set; }

    public Circulo(double raio, Color color) : base(color)
    {
      Raio = raio;
    }

    public override double Area()
    {
      return Math.PI * Raio * Raio;
    }
  }
}