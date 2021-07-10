using Pedido.Entities;
using Pedido.Entities.Enums;
using System;

namespace Pedido
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();
            order.Id = 01;
            order.Moment = DateTime.Now;
            order.Status = OrderStatus.Processing;

            string txt = OrderStatus.PendingPayment.ToString();
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(txt);
            Console.WriteLine(os);
            Console.WriteLine(order);
        }
    }
}
