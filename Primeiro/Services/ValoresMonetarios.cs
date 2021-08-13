using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Primeiro.Models;

namespace Primeiro.Services
{
  public class ValoresMonetarios
  {
    public void AumentoDeSalario()
    {
      Console.WriteLine("Quantos de funcionários que seram cadastrados? ");
      var qtd = int.Parse(Console.ReadLine());

      var funcionarios = new List<Funcionario>();

      for (var i = 1; i <= qtd; i++)
      {
        var funcionario = new Funcionario();
        Console.WriteLine($"Funcionário " + i);

        Console.WriteLine($"Código: ");
        funcionario.Id = int.Parse(Console.ReadLine());

        Console.WriteLine($"Name: ");
        funcionario.Nome = Console.ReadLine();

        Console.WriteLine($"Salário(ex: 100.00): ");
        funcionario.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        funcionarios.Add(funcionario);
      }

      Console.WriteLine($"Gostaria de dar aumento para algum funcionário?(S/N)");
      var decisao = Console.ReadLine().ToUpper();

      if (decisao.Equals("S"))
      {
        Console.WriteLine($"Entre com o código do funcionário: ");
        var codigo = int.Parse(Console.ReadLine());

        Funcionario escolhido = funcionarios.Select(x => x).Where(x => x.Id == codigo).FirstOrDefault();

        if (escolhido != null)
        {
          Console.WriteLine($"Digite a porcentagem do aumento que queira dar para o funcionário: ");
          var aumento = double.Parse(Console.ReadLine());
          escolhido.AumentarSalario(aumento);
        }
        else
        {
          Console.WriteLine("Não existe esse funcionário cadastrado!!!");
        }

        Console.WriteLine($"Lista de funcionários: ");

        foreach (var item in funcionarios)
        {
          Console.WriteLine("{0}, {1}, {2}", item.Id, item.Nome, item.SalarioBruto.ToString("F2", CultureInfo.InvariantCulture));
        }
        Console.WriteLine($"Fim!!!");

      }
    }


    public void MovimentacoesBancarias()
    {
      Console.Write("Entre o número da conta: ");
      var numeroConta = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      Console.Write("Entre o titular da conta: ");
      var nome = Console.ReadLine();
      Console.Write("Haverá depósito inicial (s/n)? ");
      var deposita = Console.ReadLine();

      var saldo = 0d;
      if (deposita == "s")
      {
        Console.Write("Entre o valor de depósito inicial: ");
        saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      }

      var conta1 = new ContaBancaria(numeroConta, nome, saldo);

      Console.WriteLine("Dados da conta: \r\n" + conta1.ToString());

      Console.Write("Entre um valor para depósito: ");
      var deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      conta1.Deposito(deposito);

      Console.WriteLine("Dados da conta atualizados: \r\n" + conta1.ToString());

      Console.Write("Entre um valor para saque: ");
      var saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      conta1.Saque(saque);

      Console.WriteLine("Dados da conta atualizados: \r\n" + conta1.ToString());
    }


    public void ConverteMoeda()
    {
      Console.Write("Qual é a cotação do dólar? ");
      var dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      Console.Write("Quantos dólares você vai comprar? ");
      var qtd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      var valor = ConversorDeMoeda.ConverteMoeda(dolar, qtd);
      Console.WriteLine("Valor a ser pago em reais = " + valor.ToString("F2", CultureInfo.InvariantCulture));
    }
  }
}