using System;
using System.Collections.Generic;
using System.Globalization;
using System.Data;
using System.Linq;
using Primeiro.Models;
using Primeiro.Services;
using Primeiro.Tarefa1.Service;
using Primeiro.Tarefa2.Services;

namespace Primeiro
{
  class Program
  {
    /**
    terminar de colocar os metodos dentro do case e começar a utilizar para
    os novos métodos que seram criados. ver se a separação dos serviços podem ser melhorados
    colocar maneira de voltar dos métodos para o menu principal e poder escolher
    outro e continuar a testar.
    */
    static void Main(string[] args)
    {
      var dataHora = new DataHora();
      var geometria = new Geometria();
      var enumera = new Enumeradores();
      var contrato = new ContratoDeTrabalho();
      var social = new SocialPosts();

      Console.WriteLine($"Escolha o que vc deseja testar!!!");
      Console.WriteLine($"1 - VerificaHora" +
                     "\r\n2 - CalculoTriangulo" +
                     "\r\n3 - PropriedadesDateTime" +
                     "\r\n4 - PropriedadesTimeSpan" +
                     "\r\n5 - DatetimeKindIso8601" +
                     "\r\n6 - Enumeradores" +
                     "\r\n7 = Contrato de Trabalho" +
                     "\r\n8 - Posts");
      int escolha = int.Parse(Console.ReadLine());

      switch (escolha)
      {
        case 1:
          dataHora.VerificaHora();
          break;
        case 2:
          geometria.CalculoTriangulo();
          break;
        case 3:
          dataHora.PropriedadesDateTime();
          break;
        case 4:
          dataHora.PropriedadesTimeSpan();
          break;
        case 5:
          dataHora.DateTimeKindIso8601();
          break;
        case 6:
          enumera.Pedido();
          break;
        case 7:
          contrato.AddWorker();
          break;
        case 8:
          social.SocialMidia();
          break;
        default:
          Console.WriteLine($"Não temos esta opção tente novamente!!!");
          break;
      }



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
      //MovimentacoesBancarias();
      //AlugandoQuartos();
      //UsandoListas();
      //AumentoDeSalario();
      //Matrizes();
      //exercicio M linhas e N colunas
      //DesafioMatrizes();
      //funções string 
      //FuncoesString();
      //funções datetime
      //FuncoesDateTime();
      //TimeSpan
      //funcoesTimeSpan();
    }
  }
}
