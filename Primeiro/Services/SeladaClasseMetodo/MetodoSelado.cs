namespace Primeiro.Services.SeladaClasseMetodo
{
  public class MetodoSelado
  {
    public void ClasseSeladaM()
    {
      //se colocar o sealed na classe SavingsAccount dessa maneira não deixo 
      //que seja possível criar nenhuma classe abaixo dela.

      //só consigo colocar o sealed em um metodo que já foi sobreposto, 
      //pois dessa maneira não terá mais como sobrepor este metodo porque nós colocamos o sealed
      
    }
  }
}