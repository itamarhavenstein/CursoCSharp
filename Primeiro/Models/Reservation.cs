using System;

namespace Primeiro.Models
{
  public class Reservation
  {
    public int RoomNumber { get; set; }
    public DateTime CheckIn { get; set; }
    public DateTime CheckOut { get; set; }

    public Reservation() { }

    public Reservation(int roomNumber, DateTime checkIn, DateTime chackOut)
    {
      RoomNumber = roomNumber;
      CheckIn = checkIn;
      CheckOut = chackOut;
    }

    public int Duration()
    {
      TimeSpan duration = CheckOut.Subtract(CheckIn);
      return (int)duration.TotalDays;
    }

    public void UpdateDates(DateTime checkin, DateTime checkout)
    {
      CheckIn = checkin;
      CheckOut = checkout;
    }

    public override string ToString()
    {
      return "Room "
      + RoomNumber
      + ", check-in: "
      + CheckIn.ToString("dd/MM/yyyy")
      + ", Check-out: "
      + CheckOut.ToString("dd/MM/yyyy")
      + ", "
      + Duration()
      + " nights";
    }
  }
}