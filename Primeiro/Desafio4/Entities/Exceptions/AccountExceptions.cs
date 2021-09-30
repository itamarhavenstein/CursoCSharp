using System;

namespace Primeiro.Desafio4.Entities.Exceptions
{
  public class AccountExceptions : ApplicationException
  {
    public AccountExceptions(string message) : base(message) { }
  }
}