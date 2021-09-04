namespace Primeiro.Tarefa3.Entities
{
  public class OutsourcedEmployee : Employee
  {
    public double AdditionalCharge { get; set; }

    public OutsourcedEmployee() { }

    public OutsourcedEmployee(string name, int hours, double valuePerHour, double addCharge) : base(name, hours, valuePerHour)
    {
      AdditionalCharge = addCharge;
    }

    public override double Payment()
    {
      return base.Payment() + 1.1 * AdditionalCharge;
    }
  }
}