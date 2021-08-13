using System;
using System.Globalization;

namespace Primeiro.Services
{
  public class DataHora
  {
    public DataHora() { }

    public void VerificaHora()
    {
      Console.WriteLine("Digite uma hora?");
      var hora = int.Parse(Console.ReadLine());
      if (hora < 12)
      {
        Console.WriteLine("Bom Dia!!!");
      }
      else if (hora >= 12 && hora < 18)
      {
        Console.WriteLine("Boa tarde!!!");
      }
      else
      {
        Console.WriteLine("Boa noite!!!");
      }

      Console.ReadKey();
    }

    public void FuncoesDateTime()
    {
      //hora atual do sistema
      DateTime d1 = DateTime.Now;
      //sobrecarga que defino a data que quero
      DateTime d2 = new DateTime(2021, 08, 13);
      DateTime d3 = new DateTime(2021, 08, 13, 20, 45, 3);
      DateTime d4 = new DateTime(2021, 08, 13, 20, 45, 3, 500);
      DateTime d5 = DateTime.Today;
      DateTime d6 = DateTime.UtcNow;
      DateTime d7 = DateTime.Parse("2000-08-15");
      DateTime d8 = DateTime.Parse("2000-08-15 13:55:02");
      //verificar por que esses 2 exemplos a seguir não estão funcinando?
      //DateTime d9 = DateTime.Parse("15/08/2000");
      //DateTime d10 = DateTime.Parse("15/08/2000 15:55:51");
      DateTime d11 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
      //DateTime d12 = DateTime.ParseExact("15/8/2000 13:05:59", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);


      Console.WriteLine($"Data de hoje: " + d1);
      Console.WriteLine($"Data que coloquei: " + d2);
      Console.WriteLine($"Data e hora que coloquei: " + d3);
      Console.WriteLine($"Data e hora com milessegundos: " + d4);
      Console.WriteLine($"Data de hoje com o horario zero: " + d5);
      Console.WriteLine($"Data utc: " + d6);
      Console.WriteLine($"Parse: " + d7);
      Console.WriteLine($"Parse hora: " + d8);
      //Console.WriteLine($"Parse Brasil: " + d9);
      //Console.WriteLine($"Parse Brasil hora: " + d10);
      Console.WriteLine($"ParseExact: " + d11);
    }


    public void funcoesTimeSpan()
    {
      TimeSpan t1 = new TimeSpan(0,1,30);
      TimeSpan t3 = new TimeSpan();
      TimeSpan t2 = new TimeSpan(900000000L);
      TimeSpan t4 = new TimeSpan(2,11,21);
      TimeSpan t5 = new TimeSpan(2, 2,11,21);

      TimeSpan t6 = TimeSpan.FromDays(1.5);
      TimeSpan t7 = TimeSpan.FromHours(1.5);
      TimeSpan t8 = TimeSpan.FromMinutes(1.5);
      TimeSpan t9 = TimeSpan.FromSeconds(1.5);
      TimeSpan t10 = TimeSpan.FromMilliseconds(1.5);

      Console.WriteLine(t1);
      Console.WriteLine(t1.Ticks);
      Console.WriteLine(t3);
      Console.WriteLine(t2);
      Console.WriteLine(t4);
      Console.WriteLine(t5);

      Console.WriteLine(t6);
      Console.WriteLine(t7);
      Console.WriteLine(t8);
      Console.WriteLine(t9);
      Console.WriteLine(t10);      
    }

  }
}