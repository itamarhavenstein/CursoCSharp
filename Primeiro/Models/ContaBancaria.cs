using System.Globalization;

namespace Primeiro.Models
{
  public class ContaBancaria
  {
    public int NumeroConta { get; private set; }
    public string Nome { get; private set; }
    public double Saldo { get; private set; }
    private double Taxa = 5;

    public ContaBancaria(int numeroConta, string nome)
    {
      NumeroConta = numeroConta;
      Nome = nome;
    }
    public ContaBancaria(int numeroConta, string nome, double saldo) : this(numeroConta, nome)
    {
      Saldo = saldo;
    }

    public void Deposito(double deposito)
    {
      Saldo = Saldo + deposito;
    }

    public void Saque(double saque)
    {
      Saldo = Saldo - saque - Taxa;
    }

    public override string ToString()
    {
      return "Conta " + NumeroConta
            + ", Titular: " + Nome
            + ", Saldo: $" + Saldo.ToString("F2", CultureInfo.InvariantCulture);
    }
  }
}