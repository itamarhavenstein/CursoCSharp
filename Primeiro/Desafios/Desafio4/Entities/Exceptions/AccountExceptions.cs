using System;

namespace Primeiro.Desafios.Desafio4.Entities.Exceptions
{
  public class AccountExceptions : ApplicationException
  {
    public AccountExceptions(string message) : base(message) { }
  }
}