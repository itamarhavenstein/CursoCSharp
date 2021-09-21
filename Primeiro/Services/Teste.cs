using System;
using System.Collections.Generic;

namespace Primeiro.Services
{
  public class Teste
  {
    public void Teste1()
    {
      IEnumerable<string> snapshot1 = new string[] { "um", "dois", "cinco", "seis" };
        IEnumerable<string> snapshot2 = new string[] { "um", "dois", "três", "quatro", "seis", "sete" };

        Answer res = ComputeChanges(snapshot1, snapshot2);

        Console.WriteLine("novos: " + string.Join(",", res.NewItems));
        Console.WriteLine("removidos: " + string.Join(",", res.RemovedItems));
        Console.WriteLine("mantidos: " + string.Join(",", res.KeptItems));

    }

/** NÃO ALTERE A ASSINATURA DESTE MÉTODO */
    public static Answer ComputeChanges(IEnumerable<string> snapshot1, IEnumerable<string> snapshot2)
    {
      List<string> snap2 = (List<string>)snapshot2;
       List<string> newItem = new List<string>();
       List<string> removedItem = new List<string>();
       List<string> keptItem = new List<string>();

       foreach (var item in snapshot1)
       {
           foreach (var item2 in snapshot2)
           {
               if(item == item2 && !keptItem.Contains(item)){
                 keptItem.Add(item);
               }
               if(!snap2.Contains(item)){
                 removedItem.Add(item);
               }
           }
           
       }

       return new Answer(newItem,removedItem,keptItem);
    }

    /** NÃO ALTERE ESTA CLASSE */
    public class Answer
    {
        public Answer(IEnumerable<string> newItems, IEnumerable<string> removedItems, IEnumerable<string> keptItems)
        {
            this.NewItems     = newItems;
            this.RemovedItems = removedItems;
            this.KeptItems    = keptItems;
        }

        public IEnumerable<string> NewItems { get; }
        public IEnumerable<string> RemovedItems { get; }
        public IEnumerable<string> KeptItems { get; }
    }

   









    ///
/// ------------------------------------------------------------------------------------
    // public class AnswerProvider : IPersonInfoProvider
    // {
    //   //mantenha este contrutor vazio
    //   public AnswerProvider() { }

    //   public Person person { get; set; }

    //   public bool HasLongName => LongName();

    //   private bool LongName()
    //   {
    //     if (person.Name.Length > 30)
    //     {
    //       return true;
    //     }
    //     return false;
    //   }
    //   public bool AllowedToDrive => ToDrive();

    //   private bool ToDrive()
    //   {
    //   if (person.Age >= 18){
    //       return true;
    //   }
    //     return false;
    //   }
    //   public void AttachPerson(Person p)
    //   {
    //     person = p;
    //   }

    //   public bool CanBeInvitedToBarbecueParty()
    //   {
    //     foreach (var item in person.FavouriteDishes)
    //     {
    //       if (item.ToUpper().Equals("CARNE") || item.ToUpper().Equals("CHOCOLATE"))
    //       {
    //         return true;
    //       }
    //       return false;
    //     }
    //     return false;
    //   }
    // }

    // //NÃO ALTERE ESTA CLASSE
    // public class Person
    // {
    //   public string Name { get; set; }
    //   public int Age { get; set; }
    //   public string[] FavouriteDishes { get; set; }
    // }

    // //NÃO ALTERE ESTA INTERFACE
    // public interface IPersonInfoProvider
    // {
    //   void AttachPerson(Person p);

    //   bool HasLongName { get; }

    //   bool AllowedToDrive { get; }

    //   bool CanBeInvitedToBarbecueParty();
    // }

    // //para efeitos de teste, você pode alterar o conteúdo do Main(), porém tome cuidado para não gerar erros de compilação!
// var p = new Person()
//       {
//         Name = "João Osvaldo Gonçalves",
//         Age = 40,
//         FavouriteDishes = new string[] { "Lasanha", "Chocolate", "Carne", "Paçoca" }
//       };

//       if (new AnswerProvider() is IPersonInfoProvider prov)
//       {
//         prov.AttachPerson(p);

//         Console.WriteLine($"Nome grande? {prov.HasLongName}");
//         Console.WriteLine($"Pode dirigir? {prov.AllowedToDrive}");
//         Console.WriteLine($"Pode ser convidado para churracos? {prov.CanBeInvitedToBarbecueParty()}");
//       }
//       else
//       {
//         Console.WriteLine("Erro: Classe de resposta não implementa interface requerida");
//       }


  }
}