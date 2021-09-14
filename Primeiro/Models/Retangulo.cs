using System;
using Primeiro.Enumerador;

namespace Primeiro.Models
{
  class Retangulo : Shape
  {
    public double Largura { get; set; }
    public double Altura { get; set; }

    public Retangulo() { }

    public Retangulo(double largura, double altura, Color color) : base(color)
    {
      Largura = largura;
      Altura = altura;
    }

    public override double Area()
    {
      return Largura * Altura;
    }

    public double Perimetro()
    {
      return 2 * (Largura + Altura);
    }

    public double Diagonal()
    {
      return Math.Sqrt((Math.Pow(Altura, 2) + Math.Pow(Largura, 2)));
    }
  }
}