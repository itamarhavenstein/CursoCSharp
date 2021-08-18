using System;
using Primeiro.Enumerador;
using Primeiro.Models;

namespace Primeiro.Services
{
    public class Enumeradores
    {
        public void Pedido()
        {
            Order pedido = new Order{Id = 1080, Moment= DateTime.Now, Status = OrderStatus.PendingPayment};

            Console.WriteLine(pedido);

            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);
            
        }
    }
}