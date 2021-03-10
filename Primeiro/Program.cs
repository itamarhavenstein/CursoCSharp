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
      //CalculoTriangulo();
      //mostrando informação da pessoal
      //MostraPessoa();
      //mostrando os funcionarios
      //MostraFuncionario();
      // EstoqueProdutos();
      //CalculoRetangulo();
      //NotasAluno();
      //CalculandoCircunferencia();
      //ConverteMoeda();
      //EstoqueProdutosEncapsulamento();
      //fazer transferencias de bancos
      MovimentacoesBancarias();
    }

    private static void MovimentacoesBancarias()
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

    private static void EstoqueProdutosEncapsulamento()
    {
      var p = new Produto("TV", 500.00, 10);
    }

    private static void ConverteMoeda()
    {
      Console.Write("Qual é a cotação do dólar? ");
      var dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      Console.Write("Quantos dólares você vai comprar? ");
      var qtd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      var valor = ConversorDeMoeda.ConverteMoeda(dolar, qtd);
      Console.WriteLine("Valor a ser pago em reais = " + valor.ToString("F2", CultureInfo.InvariantCulture));
    }

    private static void CalculandoCircunferencia()
    {
      Console.WriteLine("Entre com o valor do raio: ");
      double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      double circ = Calculadora.Circunferencia(raio);
      double volume = Calculadora.Volume(raio);

      Console.WriteLine(" Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
      Console.WriteLine(" Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
      Console.WriteLine(" Valor de PI: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));

    }

    private static void NotasAluno()
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

    private static void CalculoRetangulo()
    {
      var ret = new Retangulo();

      Console.WriteLine(" Entre a largura e altura do retângulo: ");
      Console.Write("Largura: ");
      ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      Console.Write("Altura: ");
      ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      Console.WriteLine(" Area = " + ret.Area().ToString("F2"));
      Console.WriteLine(" Perímetro = " + ret.Perimetro().ToString("F2"));
      Console.WriteLine(" Diagonal = " + ret.Diagonal().ToString("F2"));

      Console.ReadKey();
    }

    private static void EstoqueProdutos()
    {
      Console.WriteLine("Entre os dados do produto:");
      Console.Write("Nome: ");
      var nome = Console.ReadLine();
      Console.Write("Preço: ");
      var preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      Console.WriteLine("Quantidade no estoque: ");
      var qtd = int.Parse(Console.ReadLine());

      var p = new Produto(nome, preco, qtd);

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
