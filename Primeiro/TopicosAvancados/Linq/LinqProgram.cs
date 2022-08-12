using System;
using System.Collections.Generic;
using System.Linq;

namespace Primeiro.TopicosAvancados.Linq
{
  public class LinqProgram
  {
    public void ProgramLinq()
    {
      //Specify the data source
      int[] numbers = new int[] { 2, 3, 4, 5 };

      //define the query expression
      IEnumerable<int> result = numbers.Where(x => x % 2 == 0).Select(x => x * 10);

      foreach (int item in result)
      {
        Console.WriteLine(item);
      }
    }
  }
}