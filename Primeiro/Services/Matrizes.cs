using System;

namespace Primeiro.Services
{
  public class Matrizes
  {

    public void DesafioMatrizes()
    {
      //melhorar isso aqui.
      string[] mn = Console.ReadLine().Split(' ');
      int m = int.Parse(mn[0]);
      int n = int.Parse(mn[1]);

      int[,] mat = new int[m, n];
      CriaMatriz(m, n, mat);

      int escolha = int.Parse(Console.ReadLine());

      for (int i = 0; i < m; i++)
      {
        for (int j = 0; j < n; j++)
        {
          if (mat[i, j] == escolha)
          {
            Console.WriteLine("Position: {0},{1}:", i, j);
            if (j != 0)
            {
              Console.WriteLine("Left: {0}", mat[i, (j - 1)]);
            }
            if (j < (n - 1))
            {
              Console.WriteLine("Right: {0}", mat[i, (j + 1)]);
            }
            if (i != 0)
            {
              Console.WriteLine("Up: {0}", mat[(i - 1), j]);
            }
            if (i < (m - 1))
            {
              Console.WriteLine("Down: {0}", mat[(i + 1), j]);
            }

          }
        }
      }

    }

    public void ExemploMatrizes()
    {
      //double [,] mat = new Double[2,3];
      //mat.Length -> diz quantos locais tenho para colocar as variaveis
      //mat.rank => diz quantos espaços tenho na primeira casa da matriz
      int n = int.Parse(Console.ReadLine());

      int[,] mat = new int[n, n];
      CriaMatriz(n, n, mat);

      Console.WriteLine($"Main diagonal:");
      for (var i = 0; i < n; i++)
      {
        Console.Write(mat[i, i] + " ");
      }
      Console.WriteLine();

      int count = 0;
      for (int i = 0; i < n; i++)
      {
        for (int j = 0; j < n; j++)
        {
          if (mat[i, j] < 0)
          {
            count++;
          }
        }
      }
      Console.WriteLine("Negative number: " + count);

    }

    private void CriaMatriz(int linha, int coluna, int[,] mat)
    {
      for (int i = 0; i < linha; i++)
      {
        string[] values = Console.ReadLine().Split(' ');
        for (var j = 0; j < coluna; j++)
        {
          mat[i, j] = int.Parse(values[j]);
        }
      }
    }
  }
}