using System;
using System.Globalization;

namespace Primeiro.Models
{
  class Funcionario
  {
    public string Nome { get; set; }
    public double SalarioBruto { get; set; }
    public double Imposto { get; set; }

    public double SalarioLiquido(){
        return SalarioBruto - Imposto;
    }

    public void AumentarSalario(double porcentagem){
      SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem / 100);  
    }

    public override string ToString()
    {
      return Nome +", $"+ SalarioLiquido().ToString("f2", CultureInfo.InvariantCulture);
    }
  }
}