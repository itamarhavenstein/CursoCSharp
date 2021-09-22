using System;

namespace Primeiro.Services
{
    public class TratandoExcecoes
    {
        public void tratandoException(){
          try
          {
               int n1 = int.Parse(Console.ReadLine());
               int n2 = int.Parse(Console.ReadLine());
               
               int result = n1/n2;
               Console.WriteLine(result);
            
          }
          catch (DivideByZeroException)
          {
              Console.WriteLine("Division by zero is not allowed!!");
          }
        }
    }
}