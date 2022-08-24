using System;

namespace Primeiro.TopicosAvancados.ProgramFuntional
{
  public class FunctionalProgram
  {
    public static int globalValue = 3;
    public void FuncProgram()
    {
      int[] vect = new int[] { 3, 4, 5 };
      ChangeOddValues(vect);
      Console.WriteLine(string.Join(" ", vect));
    }

    public static void ChangeOddValues(int[] numbers){
      for(int i = 0; i < numbers.Length; i++){
        if(numbers[i] % 2 != 0){
          numbers[i] += globalValue;
        }
      }
    }
  }
}