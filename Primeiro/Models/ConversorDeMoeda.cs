namespace Primeiro.Models
{
    public class ConversorDeMoeda
    {
        public static double ConverteMoeda(double dolar, double qtd){
          var real = (dolar * qtd);
          var total = real + (real * 6 / 100);
          return total;
        }
    }
}