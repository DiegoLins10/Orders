using Pedido.Entities;
using Pedido.Entities.Enums;
using System;
using System.Globalization;

namespace Pedido
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /******** Populando construtor da classe cliente ****************/
            Console.WriteLine("Enter client data");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth Date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Client c = new Client(name, email, birthDate);

            /******** Pegando o status do pedido do enum ****************/
            Console.WriteLine("Enter order data:");
            Console.Write("Status: (PendingPayment/Processing/Shipped/Delivered): ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine()); //chama o enum de status

            /******** Construtor da Order com nome dados dos clientes ****************/
            Order order = new Order(DateTime.Now, status, c); // objeto order tem que ser criado fora do for

            /******** Solicitando o numero de itens ****************/
            Console.Write("How many items to this order? ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine();
            
            /******** adicionando e criando os objetos do pedido ****************/
            for ( int i = 0; i<number; i++)
            {
                Console.WriteLine($"Enter #{i+1} item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();

                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Quantity: ");
                int productQuantity = int.Parse(Console.ReadLine());

                
                Product p = new Product(productName, productPrice );
                OrderItem orderItem = new OrderItem(productQuantity, productPrice, p);
                order.AddItem(orderItem);

            }

            //order.Moment = DateTime.Now;
            //order.Status = OrderStatus.Processing;

            //string txt = OrderStatus.PendingPayment.ToString();
            //OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            //Console.WriteLine(txt);
            //Console.WriteLine(os);
            //Order or = new Order();
            Console.WriteLine();
            Console.WriteLine(order);
        }
    }
}
