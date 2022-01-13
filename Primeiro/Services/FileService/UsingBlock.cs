using System;
using System.IO;

namespace Primeiro.Services.FileService
{
  public class UsingBlock
  {
    public void OpeUsingBlock()
    {
      string sourcePath = @"/media/itamar/e3581c8e-0362-4a8c-9f37-d22f02b5fe5e/lost+found/teste";
      try
      {

        using (StreamReader sr = File.OpenText(sourcePath))
        {
          while (!sr.EndOfStream)
          {
            string line = sr.ReadLine();
            Console.WriteLine(line);
          }
        }
      }
      catch (IOException ex)
      {
        Console.WriteLine("An error occurred");
        Console.WriteLine(ex.Message);
      }


    }
  }
}