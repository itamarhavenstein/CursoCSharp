namespace Primeiro.Desafio3.Entities
{
  public abstract class BankAccount
  {
    public string Name { get; set; }
    public double AnnualIncome { get; set; }

    public BankAccount() { }

    public BankAccount(string nome, double rendaAnual)
    {
      Name = nome;
      AnnualIncome = rendaAnual;
    }

    public abstract double Tax();
  }
}