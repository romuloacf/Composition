using System;
using System.Globalization;
using Exer3_Composicao.Entities;

namespace Exer3_Composicao
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter cliente data:");            
            Console.WriteLine("Name:");
            string clientName = Console.ReadLine();
            Console.WriteLine("Email: ");
            string clientEmail = Console.ReadLine();
            Console.WriteLine("Birth date(DD / MM / YYYY):");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter order data:");

            Console.WriteLine("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(clientName, clientEmail, birthDate);
            Order order = new Order(DateTime.Now, status, client);

            Console.WriteLine("How many items to this order ?");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");

                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product product = new Product(productName, price);

                Console.WriteLine("Quantity of products: ");
                int quantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(quantity, price, product);

                order.AddItem(orderItem);
                
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);

        }
    }
}
