using System;
using System.Globalization;
using System.IO;

namespace Primeiro.Desafios.Desafio5
{
  public class LeituraCSV
  {
    public void LerArquivo()
    {
      string sourcePath = @"/media/itamar/e3581c8e-0362-4a8c-9f37-d22f02b5fe5e/lost+found/Documentos/Desafio5/teste.csv";
      string pathDestino = @"/media/itamar/e3581c8e-0362-4a8c-9f37-d22f02b5fe5e/lost+found/Documentos/Desafio5";

      try
      {
        //leitura do arquivo
        string[] lines = File.ReadAllLines(sourcePath);
        //criação da pasta e novo arquivo
        //cria diretorio
        var pathCriado = Directory.CreateDirectory(pathDestino + "/out");
        //Cria o arquivo
        string arquivo = pathCriado.FullName + "/summary.csv";
        File.Create(arquivo).Close();
        
        //abre o arquivo destino
        using (StreamWriter sw = File.AppendText(arquivo))
        {
          foreach (string line in lines)
          {
            //transforma em uma lista a string
            string[] val = line.Split(",");
            
            //monta a linha novamente da maneira que precisa ficar
            string novo =  val[0].ToString()+ " ," + (float.Parse(val[1]) * float.Parse(val[2])).ToString("F2", CultureInfo.InvariantCulture);
            sw.WriteLine(novo);
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