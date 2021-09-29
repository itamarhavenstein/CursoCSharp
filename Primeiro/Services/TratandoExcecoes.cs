using System;
using Primeiro.Exceptions;
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
      try
      {
        Console.Write("Room number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Check-in date (yyyy/MM/dd): ");
        DateTime checkIn = DateTime.Parse(Console.ReadLine());
        Console.Write("Check-out date (yyyy/MM/dd): ");
        DateTime checkOut = DateTime.Parse(Console.ReadLine());

        Reservation reservation = new Reservation(number, checkIn, checkOut);
        Console.WriteLine("Reservation: " + reservation.ToString());

        Console.WriteLine();
        Console.WriteLine("Enter data to update the reservation:");
        Console.Write("Check-in date (yyyy/MM/dd): ");
        checkIn = DateTime.Parse(Console.ReadLine());
        Console.Write("Check-out date (yyyy/MM/dd): ");
        checkOut = DateTime.Parse(Console.ReadLine());

        reservation.UpdateDates(checkIn, checkOut);

        Console.WriteLine("Reservation: " + reservation);
      }
      catch (DomainException e)
      {
        Console.WriteLine("Error in reservation: " + e.Message);
      }
      catch (FormatException e)
      {
        Console.WriteLine("Format error: " + e.Message);
      }
      catch (Exception e)
      {
        Console.WriteLine("Unexpected error: " + e.Message);
      }
    }
  }
}