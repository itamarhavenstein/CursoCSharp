using System;
using System.Collections.Generic;
using Primeiro.Desafio3.Entities;

namespace Primeiro.Desafio3.Service
{
  public class TaxService
  {
    public void CalculoImpostoHaPagar()
    {
      List<BankAccount> accounts = new List<BankAccount>();

      Console.Write("Enter the number of tax payers: ");
      int qtdPayers = int.Parse(Console.ReadLine());

      for (int i = 1; i <= qtdPayers; i++)
      {
        Console.WriteLine($"Tax payer #{i} data:");
        Console.Write("Individual or Company (c/i): ");
        char tipo = char.Parse(Console.ReadLine());

        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Anual Income: ");
        double gasto = double.Parse(Console.ReadLine());

        if (tipo == 'i')
        {
          Console.Write("Health expenditure: ");
          double saude = double.Parse(Console.ReadLine());
          accounts.Add(new Individual(name, gasto, saude));
        }
        else
        {
          Console.Write("Number of employees: ");
          int employe = int.Parse(Console.ReadLine());
          accounts.Add(new Company(name, gasto, employe));
        }
      }
      foreach (var item in accounts)
      {
        Console.WriteLine(item.ToString());
      }

      double totalTaxas = 0;
      foreach (var item in accounts)
      {
        totalTaxas += item.Tax();
      }
      Console.WriteLine($"TOTAL TAXES: $ {totalTaxas}");
    }
  }
}