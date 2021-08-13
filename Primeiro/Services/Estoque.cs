using System;
using System.Globalization;
using Primeiro.Models;

namespace Primeiro.Services
{
  public class Estoque
  {
    public void EstoqueProdutos()
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

    public void EstoqueProdutosEncapsulamento()
    {
      var p = new Produto("TV", 500.00, 10);
    }
  }
}