using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Pedido.Entities.Enums;

namespace Pedido.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; } //composicao com class client
        public List<OrderItem> ListOrder { get; set; } = new List<OrderItem>();

        public Order()
        {

        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem orderItem)
        {
            ListOrder.Add(orderItem); // adicionando objeto a lista
        }

        public void RemoveItem(OrderItem orderItem)
        {
            ListOrder.Remove(orderItem); // removendo objeto da lista
        }

        public double Total()
        {
            double sum = 0.0;
            foreach(OrderItem order in ListOrder)
            {
                sum += order.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY:");
            sb.Append("Order moment: ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.Append("Order status: ");
            sb.AppendLine(Status.ToString());
            sb.Append("Client: ");
            sb.AppendLine(Client.ToString());
            sb.AppendLine("Order Items:");
            foreach (OrderItem order in ListOrder)
            {
                sb.AppendLine(order.ToString());
            }
            sb.Append("Total price: $");
            sb.AppendLine(Total().ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }
    }
}
