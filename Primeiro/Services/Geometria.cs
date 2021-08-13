using System;
using System.Globalization;
using Primeiro.Models;

namespace Primeiro.Services
{
  public class Geometria
  {
    public void CalculoTriangulo()
    {
      Triangulo x, y;
      x = new Triangulo();
      y = new Triangulo();

      Console.WriteLine("Entre com as medidas do triângulo x: ");
      x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      Console.WriteLine("Entre com as medidas do triângulo y: ");
      y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      double areaX = x.Area();

      double areaY = y.Area();

      Console.WriteLine("Área de x = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
      Console.WriteLine("Área de y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

      if (areaX > areaY)
      {
        Console.WriteLine("Maior área é a do X");
      }
      else
      {
        Console.WriteLine("Maior área é a do Y");
      }
    }

    public void CalculoRetangulo()
    {
      var ret = new Retangulo();

      Console.WriteLine(" Entre a largura e altura do retângulo: ");
      Console.Write("Largura: ");
      ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      Console.Write("Altura: ");
      ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      Console.WriteLine(" Area = " + ret.Area().ToString("F2"));
      Console.WriteLine(" Perímetro = " + ret.Perimetro().ToString("F2"));
      Console.WriteLine(" Diagonal = " + ret.Diagonal().ToString("F2"));

      Console.ReadKey();
    }
    public void CalculandoCircunferencia()
    {
      Console.WriteLine("Entre com o valor do raio: ");
      double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      double circ = Calculadora.Circunferencia(raio);
      double volume = Calculadora.Volume(raio);

      Console.WriteLine(" Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
      Console.WriteLine(" Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
      Console.WriteLine(" Valor de PI: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));

    }
  }
}