using System;
using System.Globalization;
using Primeiro.Desafios.Desafio4.Entities;
using Primeiro.Desafios.Desafio4.Entities.Exceptions;

namespace Primeiro.Desafios.Desafio4.Service
{
  public class AccountOperations
  {
    public void Operations()
    {
      try
      {
        //Entrando com os dados da conta.
        Console.WriteLine("Enter account data:");
        Console.Write("Number: ");
        var number = int.Parse(Console.ReadLine());
        Console.Write("Holder: ");
        var holder = Console.ReadLine();
        Console.Write("Initial balance: ");
        var balance = double.Parse(Console.ReadLine());
        Console.Write("Withdraw limit: ");
        var withdrawLimit = double.Parse(Console.ReadLine());
        Account account = new Account(number, holder, balance, withdrawLimit);

        Console.WriteLine();
        //sacando uma grana
        Console.Write("Enter amount for withdraw: ");
        var withdraw = double.Parse(Console.ReadLine());
        account.Withdraw(withdraw);

        //mostrando o saldo da conta atualizado
        Console.Write("New balance: "+ account.Balance.ToString("F2", CultureInfo.InvariantCulture));
      }
      catch (AccountExceptions e)
      {
        Console.Write(e.Message);
      }
      catch (Exception e)
      {
        Console.Write("System error: " + e.Message);
      }
    }
  }
}