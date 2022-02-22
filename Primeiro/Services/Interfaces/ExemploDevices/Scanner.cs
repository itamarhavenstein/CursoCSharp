using System;

namespace Primeiro.Services.Interfaces.ExemploDevices
{
  public class Scanner : Device, IScanner
  {
    public override void ProcessDoc(string document)
    {
      Console.WriteLine("Scanner processing: " + document);
    }

    public string Scan()
    {
      return "Scanner scan result";
    }
  }
}