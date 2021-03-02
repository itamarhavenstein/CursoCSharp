using System;
using System.Globalization;
using Primeiro.Models;

namespace Primeiro
{
  class Program
  {
    static void Main(string[] args)
    {
      //VerificaHora();
      //Calculo do triangulo
      CalculoTriangulo();
      //mostrando informação da pessoal
      //MostraPessoa();
      //mostrando os funcionarios
      //MostraFuncionario();
      var p = new Produto();

      Console.WriteLine("Entre os dados do produto:");
      Console.Write("Nome: ");
      p.Nome = Console.ReadLine();
      Console.Write("Preço: ");
      p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      Console.WriteLine("Quantidade no estoque: ");
      p.Quantidade = int.Parse(Console.ReadLine());

      Console.WriteLine();
      Console.WriteLine("Dados do produto: " + p);

      Console.WriteLine();
      Console.Write("Digite o número de produtos a ser adicionado no estoque: ");
      int qte = int.Parse(Console.ReadLine());
      Console.WriteLine();
      p.AdicionarProdutos(qte);

      
      Console.WriteLine();
      Console.WriteLine("Dados do produto: " + p);

      Console.WriteLine();
      Console.WriteLine("Digite o número de produtos a ser removido do estoque: ");
      int qte1 = int.Parse(Console.ReadLine());
      Console.WriteLine();
      p.RemoverProdutos(qte1);
    }

    private static void MostraFuncionario()
    {
      var funcionario = new Funcionario();
      var funcionario1 = new Funcionario();

      Console.WriteLine("Dados do Primeiro Funcionário: ");
      Console.Write("Nome: ");
      funcionario.Nome = Console.ReadLine();
      Console.Write("Salário: ");
      funcionario.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      Console.WriteLine("Dados do Segundo Funcionário: ");
      Console.Write("Nome: ");
      funcionario1.Nome = Console.ReadLine();
      Console.Write("Salário: ");
      funcionario1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      var soma = funcionario.Salario + funcionario1.Salario;
      var media = soma / 2;
      Console.WriteLine("Salário médio = " + media.ToString("F2", CultureInfo.InvariantCulture));
    }

    private static void MostraPessoa()
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

    private static void CalculoTriangulo()
    {
      Triangulo x, y;
      x = new Triangulo();
      y = new Triangulo();

      Console.WriteLine("Entre com as medidas do triângulo x: ");
      x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      Console.WriteLine("Entre com as medidas do triângulo y: ");
      y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      double areaX = x.Area();

      double areaY = y.Area();

      Console.WriteLine("Área de x = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
      Console.WriteLine("Área de y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

      if (areaX > areaY)
      {
        Console.WriteLine("Maior área é a do X");
      }
      else
      {
        Console.WriteLine("Maior área é a do Y");
      }
    }

    private static void VerificaHora()
    {
      Console.WriteLine("Digite uma hora?");
      var hora = int.Parse(Console.ReadLine());
      if (hora < 12)
      {
        Console.WriteLine("Bom Dia!!!");
      }
      else if (hora >= 12 && hora < 18)
      {
        Console.WriteLine("Boa tarde!!!");
      }
      else
      {
        Console.WriteLine("Boa noite!!!");
      }

      Console.ReadKey();
    }
  }
}
