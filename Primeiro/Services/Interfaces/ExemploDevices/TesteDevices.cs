using System;

namespace Primeiro.Services.Interfaces.ExemploDevices
{
  public class TesteDevices
  {
    public void TestDevice()
    {
      Printer p = new Printer() { SerialNumber = 1080 };
      p.ProcessDoc("My letter");
      p.Print("My letter");

      Scanner s = new Scanner() { SerialNumber = 2003 };
      s.ProcessDoc("My email");
      Console.WriteLine(s.Scan());
    }
  }
}