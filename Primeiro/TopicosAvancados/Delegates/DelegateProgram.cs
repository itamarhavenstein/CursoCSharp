using System;
using Primeiro.TopicosAvancados.Delegates.Services;

namespace Primeiro.TopicosAvancados.Delegates
{
  delegate double BinaryNumericOperation(double n1, double n2);

  public class DelegateProgram
  {
    public void DelegaProgram()
    {
      double a = 10;
      double b = 12;
      BinaryNumericOperation op = CalculationServices.Sum;

      double result = op(a, b);
      Console.WriteLine(result);
    }
  }
}