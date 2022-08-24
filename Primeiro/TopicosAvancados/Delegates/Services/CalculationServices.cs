using System;

namespace Primeiro.TopicosAvancados.Delegates.Services
{
  public class CalculationServices
  {
    #region Exemplo1
    public static double Max(double x, double y){
      return (x > y) ? x : y;
    }

    public static double Sum(double x, double y){
      return x + y;
    }

    public static double Square(double x){
      return x * x;
    }
    #endregion

    #region Exemplo2
    public static void ShowMax(double x, double y)
    {
      double max = (x > y) ? x : y;
      Console.WriteLine(max);
    }

    public static void ShowSum(double x, double y)
    {
      double sum = x + y;
      Console.WriteLine(sum);
    }
    #endregion
  }
}