using System;
using Primeiro.Models;

namespace Primeiro.Services
{
  public class TratandoExcecoes
  {
    public void tratandoException()
    {
      try
      {
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());

        int result = n1 / n2;
        Console.WriteLine(result);

      }
      catch (DivideByZeroException)
      {
        Console.WriteLine("Division by zero is not allowed!!");
      }
    }

    public void ExceptionPersonalized()
    {
      Console.Write("Room number: ");
      int number = int.Parse(Console.ReadLine());
      Console.Write("Check-in date (yyyy/MM/dd): ");
      DateTime checkIn = DateTime.Parse(Console.ReadLine());
      Console.Write("Check-out date (yyyy/MM/dd): ");
      DateTime checkOut = DateTime.Parse(Console.ReadLine());

      if (checkOut <= checkIn)
      {
        Console.WriteLine(" Error in reservation: check-Out date must be after check-in date");
      }
      else
      {
        Reservation reservation = new Reservation(number, checkIn, checkOut);
        Console.WriteLine("Reservation: " + reservation.ToString());

        Console.WriteLine();
        Console.WriteLine("Enter data to update the reservation:");
        Console.Write("Check-in date (yyyy/MM/dd): ");
        checkIn = DateTime.Parse(Console.ReadLine());
        Console.Write("Check-out date (yyyy/MM/dd): ");
        checkOut = DateTime.Parse(Console.ReadLine());

        string error = reservation.UpdateDates(checkIn, checkOut);
        
        if (error != null)
        {
          Console.WriteLine("Error in reservation: " + error);
        }
        else
        {
          Console.WriteLine("Reservation: " + reservation);
        }
      }

    }
  }
}