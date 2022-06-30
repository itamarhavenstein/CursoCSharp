using System;
using System.Collections.Generic;

namespace Primeiro.Desafio6
{
  public class AlunosNoCurso
  {
    public void QtdAlunosNosCursos()
    {
      Console.Write("How many students for course A?");
      var qtdAlunosA = int.Parse(Console.ReadLine());
      var alunosA = new SortedSet<int>();
      ListCodigosAlunos(alunosA, qtdAlunosA);

      Console.Write("How many students for course B?");
      var qtdAlunosB = int.Parse(Console.ReadLine());
      var alunosB = new SortedSet<int>();
      ListCodigosAlunos(alunosB, qtdAlunosB);

      Console.Write("How many students for course C?");
      var qtdAlunosC = int.Parse(Console.ReadLine());
      var alunosC = new SortedSet<int>();
      ListCodigosAlunos(alunosC, qtdAlunosC);

      //verificar quantos alunos
      SortedSet<int> novo = new SortedSet<int>(alunosA);
      novo.UnionWith(alunosB);
      novo.UnionWith(alunosC);

      var qtdAlunosTotal = novo.Count;
      Console.WriteLine("Total de estudantes matriculados: {0}",qtdAlunosTotal.ToString());
    }

    private static void ListCodigosAlunos(SortedSet<int> alunos, int qtdAlunos)
    {
      for (var i = 0; i < qtdAlunos; i++)
      {
        Console.Write("Digite o código do aluno:");
        var codAluno = int.Parse(Console.ReadLine());
        alunos.Add(codAluno);
      };
    }
  }
}