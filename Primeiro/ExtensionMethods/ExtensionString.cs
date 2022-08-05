using System;

namespace Primeiro.ExtensionMethods
{
  public class ExtensionString
  {
    public void TratandoStrings()
    {
      string s1 = "Good morning dear students!";
      Console.WriteLine(s1.Cut(10));
    }
  }
}