﻿using System;
using Primeiro.Tarefa1.Service;
using Primeiro.Tarefa2.Services;
using Primeiro.Tarefa3.Services;
using Primeiro.Desafios.Desafio1.Service;
using Primeiro.Services.UpcastingDowncasting;
using Primeiro.Services.Sobreposicao;
using Primeiro.Services.SeladaClasseMetodo;
using Primeiro.Desafios.Desafio2.Service;
using Primeiro.Services.Abstrata;
using Primeiro.Desafios.Desafio3.Service;
using Primeiro.Services;
using Primeiro.Desafios.Desafio4.Service;
using Primeiro.Services.FileService;
using Primeiro.Desafios.Desafio5;
using Primeiro.Services.Interfaces.ProblemaComInterface;
using Primeiro.Services.Interfaces.ProblemaSemInterface;
using Primeiro.Services.Interfaces.Exercicio;
using Primeiro.Services.Interfaces.Exemplo;
using Primeiro.Services.Interfaces.ExemploDevices;
using Primeiro.Services.Interfaces.ExemploCompara;
using Primeiro.Services.Generics;
using Primeiro.Desafios.Desafio6;
using Primeiro.Services.Generics.Dictionaries;
using Primeiro.Desafios.Desafio7;
using Primeiro.ExtensionMethods;
using Primeiro.TopicosAvancados.Comparison;
using Primeiro.TopicosAvancados.ProgramFuntional;
using Primeiro.TopicosAvancados.Delegates;
using Primeiro.TopicosAvancados.Linq;
using Primeiro.TopicosAvancados.Exercicios;

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
      var pedido = new Pedido();
      var upDown = new UpDowncasting();
      var sobre = new PalavrasVirtuais();
      var sela = new MetodoSelado();
      var pagaFun = new PagamentoFuncio();
      var regisProduct = new RegisterProduct();
      var abstraCla = new AbstrataClasse();
      var abstraMetod = new AbstrataMetod();
      var tax = new TaxService();
      var teste = new Teste();
      var tratando = new TratandoExcecoes();
      var operation = new AccountOperations();
      var file = new OperationFile();
      var usingBlock = new UsingBlock();
      var arquivoCsv = new LeituraCSV();
      var semInterface = new ServicoPrincipalSemI();
      var comInterface = new ServicoPrincipalComI();
      var contratos = new Contratos();
      var forGeo = new FormasGeometricas();
      var device = new TesteDevices();
      var compara = new TesteDeComparacao();
      var genericReuso = new ReusoGenerico();
      var conjuntos = new AlunosNoCurso();
      var dictio = new ExemploDicSort();
      var desafioDict = new DesafioDictionary();
      var extension = new ExtensionData();
      var extension1 = new ExtensionString();
      var comparison = new ComparisonProgram();
      var funtional = new FunctionalProgram();
      var delegates = new DelegateProgram();
      var linqProg = new LinqProgram();
      var exerProg = new ExerciciosProgram();

      Console.WriteLine($"Escolha o que vc deseja testar!!!");
      Console.WriteLine($"1 - VerificaHora" +
                     "\r\n2 - CalculoTriangulo" +
                     "\r\n3 - PropriedadesDateTime" +
                     "\r\n4 - PropriedadesTimeSpan" +
                     "\r\n5 - DatetimeKindIso8601" +
                     "\r\n6 - Enumeradores" +
                     "\r\n7 = Contrato de Trabalho" +
                     "\r\n8 - Posts" +
                     "\r\n9 - PedidoCompra" +
                     "\r\n10 - Herança" +
                     "\r\n11 - Upcasting Downcasting" +
                     "\r\n12 - Sobreposição, palavras virtuais" +
                     "\r\n13 - Classe/Metodo Selada" +
                     "\r\n14 - Pagamento Funcionário" +
                     "\r\n15 - Register Product" +
                     "\r\n16 - Abstrata Classe" +
                     "\r\n17 - Abstrato Metodo" +
                     "\r\n18 - Imposto" +
                     "\r\n19 - teste" +
                     "\r\n20 - TryCatch" +
                     "\r\n21 - Exception personalizada" +
                     "\r\n22 - Desafio Exception" +
                     "\r\n23 - Matrizes com listas" +
                     "\r\n24 - File" +
                     "\r\n25 - FileStream" +
                     "\r\n26 - Using block" +
                     "\r\n27 - Stream writer" +
                     "\r\n28 - Directory info" +
                     "\r\n29 - Path" +
                     "\r\n30 - Ler Arquivo CSV" +
                     "\r\n31 - Problema Sem Interface" +
                     "\r\n32 - Problema Com Interface" +
                     "\r\n33 - Criando Contratos " +
                     "\r\n34 - Formas Geometricas" +
                     "\r\n35 - Teste Device" +
                     "\r\n36 - Generic" +
                     "\r\n37 - Exemplo sobre conjuntos:" +
                     "\r\n38 - Exemplo de dicionario" +
                     "\r\n39 - Desafio dictionary" +
                     "\r\n40 - Extension Methods " +
                     "\r\n41 - Comparison" +
                     "\r\n42 - Programação Funcional" +
                     "\r\n43 - Delegates" +
                     "\r\n44 - Linq" +
                     "\r\n45 - exercicio");
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
        case 9:
          pedido.PedidoCompra();
          break;
        case 11:
          upDown.UpDown();
          break;
        case 12:
          sobre.SobreposicaoPalavras();
          break;
        case 13:
          sela.ClasseSeladaM();
          break;
        case 14:
          pagaFun.PagamentoFunc();
          break;
        case 15:
          regisProduct.RegisterProd();
          break;
        case 16:
          abstraCla.AbstrataCla();
          break;
        case 17:
          abstraMetod.MetodExemplo();
          break;
        case 18:
          tax.CalculoImpostoHaPagar();
          break;
        case 19:
          teste.Teste1();
          break;
        case 20:
          tratando.tratandoException();
          break;
        case 21:
          tratando.ExceptionPersonalized();
          break;
        case 22:
          operation.Operations();
          break;
        case 23:
          teste.MatrizComLista();
          break;
        case 24:
          file.OpeFile();
          break;
        case 25:
          file.OpeFileStream();
          break;
        case 26:
          usingBlock.OpeUsingBlock();
          break;
        case 27:
          file.OpeFileStreamWrite();
          break;
        case 28:
          file.DirectoryInfo();
          break;
        case 29:
          file.PathInfo();
          break;
        case 30:
          arquivoCsv.LerArquivo();
          break;
        case 31:
          semInterface.SemInterface();
          break;
        case 32:
          comInterface.ComInterface();
          break;
        case 33:
          contratos.CriandoContratos();
          break;
        case 34:
          forGeo.FormasGeo();
          break;
        case 35:
          device.TestDevice();
          break;
        case 36:
          //Reuso
          //genericReuso.Reuso();
          // genericReuso.CalculationMax();
          // genericReuso.EqualsGetHashCode();
          //  genericReuso.HasetSortSet();
          // genericReuso.HasetSortSet2();
          genericReuso.HashSetEquals();
          break;
        case 37:
          conjuntos.QtdAlunosNosCursos();
          break;
        case 38:
          //dictio.DictionarExemplo();
          desafioDict.ContagemVotos();
          break;
        case 40:
          //extension.TratandoDatas();
          extension1.TratandoStrings();
          break;
        case 41:
          comparison.ComparisonProg();
          break;
        case 42:
          funtional.FuncProgram();
          break;
        case 43:
          // delegates.DelegaProgram();
          // delegates.DelegaProgram2();
          // delegates.DelegateActionProgram();
          delegates.DelegateFuncProgram();
          break;
        case 44:
          // linqProg.ProgramLinq();
          // linqProg.LinqSearch();
          linqProg.LinqSQL();
          break;
        case 45:
          exerProg.ExerProgram();
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

    // private static void CalculoTriangulo()
    // {
    //   string format = "N2";
    //   decimal? num2 = (decimal?)3.05;
    //   decimal? num3 = (decimal?)4.01;
    //   string num = num2?.ToString(format,CultureInfo.InvariantCulture)+"/"+num3?.ToString("N2",CultureInfo.InvariantCulture);
    //   Console.WriteLine(num);
    // }
  }
}
