using System.Globalization;

namespace Primeiro.Desafio3.Entities
{
  public class Company : BankAccount
  {
    public int Employees { get; set; }

    /// <summary>
    /// valores fixos para calculo de impostos
    /// </summary>
    private int TaxaImpostoMaximo = 16;
    private int TaxaImpostoMinimo = 14;
    private int QtdFuncionarios = 10;

    public Company(string nome, double rendaAnual, int employees) : base(nome, rendaAnual)
    {
      Employees = employees;
    }

    public override double Tax()
    {
      double valorHaPagar= 0;
      if (Employees < QtdFuncionarios)
      {
        valorHaPagar = AnnualIncome * (TaxaImpostoMinimo / 100.00);
      }
      else
      {
        valorHaPagar = AnnualIncome * (TaxaImpostoMaximo / 100.00);
      }
      return valorHaPagar;
    }

    public override string ToString()
    {
      return Name + ": $ " + Tax().ToString("F2", CultureInfo.InvariantCulture);
    }
  }
}