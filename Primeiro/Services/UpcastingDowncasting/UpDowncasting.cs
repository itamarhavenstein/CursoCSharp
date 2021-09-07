using System;
using Primeiro.Models;

namespace Primeiro.Services.UpcastingDowncasting
{
  public class UpDowncasting
  {
    //vamos utilizar as classes que foram criadas na aula de herança.
    public void UpDown()
    {
      //não podemos mais fazer isso pois alteramos a classe para abtrata 
      //Account acc = new Account(1001, "Alex", 0.0);
      BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.00);

      //UPCASTING
      Account acc1 = bacc;
      Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
      Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

      //DOWNCASTING - utilizar somente se for necessário e ainda precisará testar para ver se é compatível com o objeto.
      BusinessAccount bacc1 = (BusinessAccount)acc2;
      bacc1.Loan(100.0);
      
      //nesse caso o compilador não mostrará problema,
      //apenas irá mostrar um erro em tempo de execução
      //BusinessAccount bacc2 = (BusinessAccount)acc3;

      if(acc3 is BusinessAccount){
        BusinessAccount bacc3 = acc3 as BusinessAccount;
        bacc3.Loan(200.00);
        Console.WriteLine("Loan!");
      }

      if(acc3 is SavingsAccount){
        SavingsAccount sav = (SavingsAccount)acc3;
        sav.UpdateBalance();
        Console.WriteLine("Update!");
      }
    }
  }
}