using System;
using System.IO;

namespace Primeiro.Services.FileService
{
  public class OperationFile
  {
    public void OpeFile()
    {

      string sourcePath = @"/media/itamar/e3581c8e-0362-4a8c-9f37-d22f02b5fe5e/lost+found/teste";
      //string targetPath = @"/media/itamar/e3581c8e-0362-4a8c-9f37-d22f02b5fe5e/lost+found/teste1.txt";

      try
      {
        FileInfo fileINfo = new FileInfo(sourcePath);
        // fileINfo.CopyTo(targetPath);

        string[] lines = File.ReadAllLines(sourcePath);

        foreach (var x in lines)
        {
          Console.WriteLine(x);
        }
      }
      catch (IOException ex)
      {
        Console.WriteLine("An error occured");
        Console.WriteLine(ex.Message);
      }
    }

    public void OpeFileStream()
    {
      string sourcePath = @"/media/itamar/e3581c8e-0362-4a8c-9f37-d22f02b5fe5e/lost+found/teste";
      FileStream fs = null;
      StreamReader sr = null;

      try
      {
        fs = new FileStream(sourcePath, FileMode.Open);
        sr = new StreamReader(fs);
        string line = sr.ReadLine();
        Console.WriteLine(line);

      }
      catch (IOException ex)
      {
        Console.WriteLine(ex.Message);
      }finally{
        if(sr != null) sr.Close();
        if(fs != null) fs.Close();
      }
    }
  }
}