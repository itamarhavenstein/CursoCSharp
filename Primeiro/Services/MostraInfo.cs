using System;
using System.Globalization;
using Primeiro.Models;

namespace Primeiro.Services
{
  public class MostraInfo
  {
    public void MostraFuncionario()
    {
      var funcionario = new Funcionario();

      Console.WriteLine("Dados do Primeiro Funcionário: ");
      Console.Write("Nome: ");
      funcionario.Nome = Console.ReadLine();
      Console.Write("Salário bruto: ");
      funcionario.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      Console.Write("Imposto: ");
      funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      Console.WriteLine("Funcionário: " + funcionario.ToString());

      Console.Write("Digite a porcentagem para aumentar o salário: ");
      var aumento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      funcionario.AumentarSalario(aumento);

      Console.WriteLine("Dados atualizados: " + funcionario.ToString());
    }

    public void MostraPessoa()
    {
      var pessoa1 = new Pessoa();
      var pessoa2 = new Pessoa();

      Console.WriteLine("Insira os dados da primeira pessoa: ");
      Console.Write("Nome: ");
      pessoa1.Nome = Console.ReadLine();
      Console.Write("Idade: ");
      pessoa1.Idade = int.Parse(Console.ReadLine());

      Console.WriteLine("Insira os dados da segunda pessoa: ");
      Console.Write("Nome: ");
      pessoa2.Nome = Console.ReadLine();
      Console.Write("Idade: ");
      pessoa2.Idade = int.Parse(Console.ReadLine());

      if (pessoa1.Idade > pessoa2.Idade)
      {
        Console.WriteLine("Pessoa mais velha: " + pessoa1.Nome);
      }
      else
      {
        Console.WriteLine("Pessoa mais velha: " + pessoa2.Nome);
      }

      Console.ReadKey();
    }
   
    public void NotasAluno()
    {
      var aluno = new Aluno();
      Console.WriteLine("Nome do aluno: ");
      aluno.Nome = Console.ReadLine();
      Console.WriteLine("Digite as três notas do aluno: ");
      for (var i = 1; i <= 3; i++)
      {
        aluno.Notas.Add(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
      }

      Console.WriteLine("Nota Final = " + aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
      Console.WriteLine(aluno.VerificarNota());
    }
  }
}