using System.Collections.Generic;
using System.Globalization;

namespace Primeiro.Models
{
  public class Aluno
  {

    public string Nome { get; set; }
    public List<double> Notas { get; set; }
    public Aluno()
    {
        Notas = new List<double>();
    }

    private double TotalNotas { get; set; }

    public double NotaFinal()
    {
      foreach (var nota in Notas)
      {
        TotalNotas += nota;
      }
      return TotalNotas;
    }

    public string VerificarNota()
    {
      var notaMinima = 60D;
      if (TotalNotas > notaMinima)
      {
        return "Aprovado";
      }
      else
      {
        var faltaNota = notaMinima - TotalNotas;
        return "Reprovado \r\nFaltaram " + faltaNota.ToString("F2", CultureInfo.InvariantCulture) + " Pontos";
      }
    }
  }
}