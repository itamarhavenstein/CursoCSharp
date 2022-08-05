using System;

namespace Primeiro.ExtensionMethods
{
  public class ExtensionData
  {
    public void TratandoDatas()
    {
      DateTime dt = new DateTime(2022, 08, 4, 8, 10, 45);
      Console.WriteLine(dt.ElapsedTime());
    }
  }
}