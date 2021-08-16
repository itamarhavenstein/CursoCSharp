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
      TimeSpan t1 = new TimeSpan(0, 1, 30);
      TimeSpan t3 = new TimeSpan();
      TimeSpan t2 = new TimeSpan(900000000L);
      TimeSpan t4 = new TimeSpan(2, 11, 21);
      TimeSpan t5 = new TimeSpan(2, 2, 11, 21);

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

    public void PropriedadesDateTime()
    {
      Console.WriteLine($"Propriedades do DateTime:");
      DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);
      Console.WriteLine(d);
      Console.WriteLine($"1) Date: " + d.Date);
      Console.WriteLine($"2) Day: " + d.Day);
      Console.WriteLine($"3) DayOfWeek: " + d.DayOfWeek);
      Console.WriteLine($"4) DayOfYear: " + d.DayOfYear);
      Console.WriteLine($"5) Hour: " + d.Hour);
      Console.WriteLine($"6) Kind: " + d.Kind);
      Console.WriteLine($"7) Millisecond: " + d.Millisecond);
      Console.WriteLine($"8) Minute: " + d.Minute);
      Console.WriteLine($"9) Month: " + d.Month);
      Console.WriteLine($"10) Second: " + d.Second);
      Console.WriteLine($"11) Ticks: " + d.Ticks);
      Console.WriteLine($"12) TimeOfDay: " + d.TimeOfDay);
      Console.WriteLine($"13) Year: " + d.Year);
      Console.Write("");

      Console.WriteLine($"Formatação da Data:");
      DateTime d2 = new DateTime(2001, 8, 15, 13, 45, 58);
      Console.WriteLine(d2.ToLongDateString());
      Console.WriteLine(d2.ToLongTimeString());
      Console.WriteLine(d2.ToShortDateString());
      Console.WriteLine(d2.ToShortTimeString());
      Console.WriteLine(d2.ToString());
      Console.WriteLine(d2.ToString("yyyy-MM-dd HH:mm:ss"));
      Console.WriteLine(d2.ToString("yyyy-MM-dd HH:mm:ss.fff"));

      Console.Write("");
      Console.WriteLine($"Operações com DateTime:");
      DateTime d3 = new DateTime(2001, 8, 15, 13, 45, 58);
      DateTime d4 = d3.AddHours(2);
      DateTime d5 = d3.AddMinutes(3);
      DateTime d6 = d3.AddDays(7);

      Console.WriteLine(d3);
      Console.WriteLine(d4);
      Console.WriteLine(d5);
    }

    public void PropriedadesTimeSpan()
    {
      TimeSpan t1 = TimeSpan.MaxValue;
      TimeSpan t2 = TimeSpan.MinValue;
      TimeSpan t3 = TimeSpan.Zero;

      Console.WriteLine(t1);
      Console.WriteLine(t2);
      Console.WriteLine(t3);

      TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);
      Console.WriteLine(t);
      Console.WriteLine($"Days: " + t.Days);
      Console.WriteLine($"Hours: " + t.Hours);
      Console.WriteLine($"Minutes: " + +t.Minutes);
      Console.WriteLine($"Seconds: " + t.Seconds);
      Console.WriteLine($"Ticks: " + t.Ticks);

      Console.WriteLine($"TotalDays: " + t.TotalDays);
      Console.WriteLine($"TotalHours: " + t.TotalHours);
      Console.WriteLine($"TotalMinutes: " + t.TotalMinutes);
      Console.WriteLine($"TotalSeconds: " + t.TotalSeconds);
      Console.WriteLine($"TotalMilliseconds: " + t.TotalMilliseconds);
      Console.Write("");
      Console.WriteLine($"Operações com TimeSpan:");
      TimeSpan t4 = new TimeSpan(1, 30, 10);
      TimeSpan t5 = new TimeSpan(0, 10, 5);

      TimeSpan sum = t4.Add(t5);
      TimeSpan dif = t4.Subtract(t5);
      TimeSpan mult = t4.Multiply(2.0);
      TimeSpan sub = t4.Divide(2);

      Console.WriteLine($"Tempo somado: " + sum);
      Console.WriteLine($"Tempo subtração: " + dif);
      Console.WriteLine($"Tempo multiplicado: " + mult);
      Console.WriteLine($"Tempo dividido: " + sub);
    }

    public void DateTimeKindIso8601()
    {
      DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
      DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
      DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);

      Console.WriteLine("d1: " + d1);
      Console.WriteLine($"d1 Kind: " + d1.Kind);
      Console.WriteLine($"d1 ToLocal: " + d1.ToLocalTime());
      Console.WriteLine($"d1 toUTC: " + d1.ToUniversalTime());
      Console.WriteLine("");
      Console.WriteLine("d2: " + d2);
      Console.WriteLine($"d2 Kind: " + d2.Kind);
      Console.WriteLine($"d2 ToLocal: " + d2.ToLocalTime());
      Console.WriteLine($"d2 toUTC: " + d2.ToUniversalTime());
      Console.WriteLine("");
      Console.WriteLine("d3: " + d3);
      Console.WriteLine($"d3 Kind: " + d3.Kind);
      Console.WriteLine($"d3 ToLocal: " + d3.ToLocalTime());
      Console.WriteLine($"d3 toUTC: " + d3.ToUniversalTime());

      Console.WriteLine($"Iso 8601:");
      DateTime t4 = DateTime.Parse("2000-08-15 13:05:58");
      DateTime t5 = DateTime.Parse("2000-08-15T13:05:58Z");

      Console.WriteLine($"t4: " + t4);
      Console.WriteLine($"t4 Kind: " + t4.Kind);
      Console.WriteLine($"t4 ToLocal: " + t4.ToLocalTime());
      Console.WriteLine($"t4 toUTC: " + t4.ToUniversalTime());
      Console.WriteLine("");
      Console.WriteLine($"t5: " + t5);
      Console.WriteLine($"t5 Kind: " + t5.Kind);
      Console.WriteLine($"t5 ToLocal: " + t5.ToLocalTime());
      Console.WriteLine($"t5 toUTC: " + t5.ToUniversalTime());
      Console.WriteLine("");
      Console.WriteLine(t5.ToString("yyyy-MM-ddTHH:mm:ssZ"));//Cuidado
      //faça o que está na próxima linha primeiro garanta que a data esta em UtC 
      //e depois aplique a mascara na data que vc queira, senão vai dar errado.
      Console.WriteLine(t5.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));
    }
  }
}