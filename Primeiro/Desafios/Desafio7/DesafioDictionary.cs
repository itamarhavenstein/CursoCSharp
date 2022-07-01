using System;
using System.Collections.Generic;
using System.IO;

namespace Primeiro.Desafios.Desafio7
{
  public class DesafioDictionary
  {
    public void ContagemVotos()
    {
      string docVotos = @"/media/itamar/e3581c8e-0362-4a8c-9f37-d22f02b5fe5e/lost+found/Documentos/Desafio7/votos.txt";

      string[] lines = File.ReadAllLines(docVotos);

      Dictionary<string, int> listCandidatos = new Dictionary<string, int>();

      foreach (var item in lines)
      {
        var nq = item.Split(',');
        if (!listCandidatos.ContainsKey(nq[0]))
        {
          listCandidatos[nq[0].ToString()] = int.Parse(nq[1]);
        }else{
          var votos = listCandidatos[nq[0].ToString()];
          listCandidatos[nq[0].ToString()] = int.Parse(nq[1]) + votos;
        }
      }
      
      Console.WriteLine("Total de votos: ");
      foreach(var item in listCandidatos){
        Console.WriteLine(item.Key + ": " + item.Value);
      }

      Console.WriteLine("Parou");
    }
  }
}