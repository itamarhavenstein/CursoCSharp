using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Primeiro.TopicosAvancados.Exercicios
{
    public class ExerciciosProgram
    {
      public void ExerProgram(){
        string sourcePath = @"/media/itamar/e3581c8e-0362-4a8c-9f37-d22f02b5fe5e/lost+found/teste";
        Console.Write("Enter full file path: ");
        string path = Console.ReadLine();

        List<Product> list = new List<Product>();
        using(StreamReader sr = File.OpenText(path)){
          
          while(!sr.EndOfStream){
            string[] fields = sr.ReadLine().Split(',');
            string name = fields[0];
            double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
            list.Add(new Product(name, price));
          }
        }

        var avg = list.Select(p => p.Price).DefaultIfEmpty().Average();
        Console.WriteLine("Average price = " + avg.ToString("F2", CultureInfo.InvariantCulture));
        
        var names = list.Where(p => p.Price < avg).OrderByDescending(p => p.Name).Select(p => p.Name);
        foreach(var item in names){
          Console.WriteLine(item);
        }
      }
    }
}