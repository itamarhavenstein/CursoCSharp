using System;
using System.Collections.Generic;

namespace Primeiro.Services.Generics
{
    public class ReusoGenerico
    {
        public void Reuso(){

          PrintService<int> printService = new PrintService<int>();

          Console.Write(" How many values? ");
          int n = int.Parse(Console.ReadLine());

          for (int i = 0; i<n;i++){
            int x = int.Parse(Console.ReadLine());
            printService.AddValue(x);
          }

          printService.Print();
          Console.WriteLine("First: " + printService.First());
        }

        public void CalculationMax(){
          List<int> list = new List<int>();

          Console.Write("Enter N: ");
          int n = int.Parse(Console.ReadLine());

          for (int i = 0; i < n; i++)
          {
            int x = int.Parse(Console.ReadLine());
            list.Add(x);
          }

          CalculationService calculationService = new CalculationService();

          int max = calculationService.Max(list);

          Console.WriteLine("Max:");
          Console.WriteLine(max);
        }
    }
}