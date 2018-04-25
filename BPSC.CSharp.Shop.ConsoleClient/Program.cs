using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPSC.CSharp.Shop.Models;

namespace BPSC.CSharp.Shop.ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateOrderTest();

            CreateOrderTest2();
        }

        // Inicjalizacja za pomocą inicjalizatorów
        private static void CreateOrderTest2()
        {
            Customer customer = new Customer("Marcin", "Sulecki");

            var order = new Order(customer)
            {
                Id = 1,
                OrderNumber = "ZAM 001",
               // OrderDate = DateTime.Now,
            };

        }

        // Inicjalizacja za pomocą konstruktora bezparametrycznego
        private static void CreateOrderTest()
        {
            Customer customer = new Customer("Marcin", "Sulecki");

            Order order = new Order(customer);
            order.Id = 1;
            order.OrderNumber = "ZAM 001";
            // order.OrderDate = DateTime.Now;

            Item item1 = new Product
            {
                Id = 100,
                Name = "Klawiatura",
                Code = "KEY645645",
                Color = "Black",
                UnitPrice = 30
            };

            Item item2 = new Service
            {
                Id = 101,
                Name = "Usługi informatyczne",
                Code = "SRV44884",
                UnitPrice = 100
            };


            OrderDetail orderDetail1 = new OrderDetail(item1, 9)
            {
                Id = 1,                
            };

            OrderDetail orderDetail2 = new OrderDetail(item2, 1);

            orderDetail1.Quantity = 100;

           // Console.WriteLine($"Kwota pozycji: {orderDetail1.Amount}");

            order.Details.Add(orderDetail1);
            order.AddOrderDetail(orderDetail2);

            Console.WriteLine(order.ToString());
            
        }
    }
}
