using System;

namespace Primeiro.Services.Interfaces.ExemploDevices
{
  public class ComboDevice : Device, IScanner, IPrinter
  {
    public void Print(string document)
    {
      Console.WriteLine("ComboDevice print " + document);
    }

    public override void ProcessDoc(string document)
    {
      Console.WriteLine("ComboDevice processing " + document);
    }

    public string Scan()
    {
      return "ComboDevice scan result";
    }
  }
}