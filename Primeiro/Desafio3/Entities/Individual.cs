using System.Globalization;

namespace Primeiro.Desafio3.Entities
{
  public class Individual : BankAccount
  {
    public double HealthExpenditure { get; set; }

    /// <summary>
    /// Valores fixos de taxas para calculo do imposto
    /// </summary>
    private double Renda = 20000.00;
    private int TaxaImpostoMinimo = 15;
    private int TaxaImpostoMaximo = 25;
    private int TaxaRessarcimentoSaude = 50;

    public Individual(string nome, double rendaAnual, double healthExpenditure) : base(nome, rendaAnual)
    {
      HealthExpenditure = healthExpenditure;
    }

    public override double Tax()
    {
      double valorHaPagar = 0;
      double valorDesconto = 0;
      if (AnnualIncome < Renda)
      {
        valorHaPagar = AnnualIncome * (TaxaImpostoMinimo / 100.00);
      }
      else
      {
        valorHaPagar = AnnualIncome * (TaxaImpostoMaximo / 100.00);
      }

      if (HealthExpenditure != 0)
      {
        valorDesconto = (HealthExpenditure * (TaxaRessarcimentoSaude / 100.00));
      }

      return valorHaPagar - valorDesconto;
    }

    public override string ToString()
    {
      return Name + ": $ " + Tax().ToString("F2", CultureInfo.InvariantCulture);
    }
  }
}