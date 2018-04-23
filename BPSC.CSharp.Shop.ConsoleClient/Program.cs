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
            var order = new Order
            {
                Id = 1,
                OrderNumber = "ZAM 001",
                OrderDate = DateTime.Now,
            };

        }

        // Inicjalizacja za pomocą konstruktora bezparametrycznego
        private static void CreateOrderTest()
        {
            Order order = new Order();
            order.Id = 1;
            order.OrderNumber = "ZAM 001";
            order.OrderDate = DateTime.Now;
        }
    }
}
