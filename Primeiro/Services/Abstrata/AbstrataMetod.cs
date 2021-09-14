using System;
using System.Collections.Generic;
using System.Globalization;
using Primeiro.Enumerador;
using Primeiro.Models;

namespace Primeiro.Services.Abstrata
{
  public class AbstrataMetod
  {
    public void MetodExemplo()
    {
      List<Shape> list = new List<Shape>();

      Console.Write("Enter the number of shapes: ");
      int n = int.Parse(Console.ReadLine());

      for (int i = 0; i < n; i++)
      {
        Console.WriteLine($"Shape #{i} data:");
        Console.Write("Retangulo ou Circulo (r/c)");
        char ch = char.Parse(Console.ReadLine());
        Console.Write("Color (Black/Blue/Red): ");
        Color color = Enum.Parse<Color>(Console.ReadLine());
        if (ch == 'r')
        {
          Console.Write("Largura: ");
          double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
          Console.Write("Altura: ");
          double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
          list.Add(new Retangulo(largura, altura, color));
        }
        else
        {
          Console.Write("Raio: ");
          double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
          list.Add(new Circulo(raio, color));
        }
      }
      Console.WriteLine();
      Console.WriteLine("SHAPE AREAS:");
      foreach (var item in list)
      {
        Console.WriteLine(item.Area().ToString("F2", CultureInfo.InvariantCulture));
      }
    }
  }
}