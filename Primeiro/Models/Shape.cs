using Primeiro.Enumerador;

namespace Primeiro.Models
{
  public abstract class Shape
  {
    public Color Color { get; set; }


    public Shape(Color color)
    {
      Color = color;
    }

    protected Shape()
    {
    }

    public abstract double Area();
  }
}