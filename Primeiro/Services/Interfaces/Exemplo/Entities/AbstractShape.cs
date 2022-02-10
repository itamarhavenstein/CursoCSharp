using Primeiro.Services.Interfaces.Exemplo.Enums;

namespace Primeiro.Services.Interfaces.Exemplo.Entities
{
  public abstract class AbstractShape : IShape
  {
    public Color Color { get; set; }

    public abstract double Area();
  }
}