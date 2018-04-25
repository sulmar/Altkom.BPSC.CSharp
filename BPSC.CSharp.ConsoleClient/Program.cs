using BPSC.CSharp.Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPSC.CSharp.ConsoleClient
{
   

    class Program
    {
        static void Main()
        {
            VariantTest();
            DynamicTest();

            Console.WriteLine("Podaj imię: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Podaj nazwisko: ");
            string lastName = Console.ReadLine();

            Console.WriteLine("Podaj wiek");
            byte age = byte.Parse(Console.ReadLine());
            string displayAge = age.ToString();

            Console.WriteLine("Podaj cenę: ");
            decimal price = decimal.Parse(Console.ReadLine());

            TypesTest(price);

            // konkatenacja ciągów tekstowych 

            ConcatTest(firstName, lastName);
        }

        private static void DynamicTest()
        {
            dynamic x = 10;

            string text = x.ToStringXXXXXX();

            x++;

            Console.WriteLine(x);

            x = "Hello World";

            Console.WriteLine(x);
        }

        private static void VariantTest()
        {
            var x = "World";

            Customer customer = new Customer("Marcin", "Sulecki");

            var customerInfo = new
            {
                Imie = customer.FirstName,
                Nazwisko = "Sulecki",
                LoginDate = DateTime.Now,
            };
        }

        private static void TypesTest(decimal price)
        {
            // konwersja liczby na tekst + formatowanie
            string priceString = price.ToString("C2");


            // Liczby całkowite

            // 0..255
            // byte age = 18;
            sbyte temp = -32;

            // 16-bit (2-bajtowy) -32768 .. 32767
            short points;

            // 32-bit (4-bajtowy)
            int personId;

            personId = 65000;

            // 64-bit
            long tempId;

            // Liczby rzeczywiste

            // Liczby stałoprzecinkowe

            decimal amount = 100.50m;

            // Liczby zmiennoprzecinkowe

            float temperature = 10.05f;

            double gravity = 9.81;


            // Data
            DateTime dateTime = DateTime.Now;

            // Wartość logiczna
            bool isDeleted = true;
        }

        private static void ConcatTest(string firstName, string lastName)
        {
            // zla praktyka
            // string fullname = firstName + " " + lastName;

            // dobra praktyka
            // string fullname = string.Format("{0} {1}", firstName, lastName);

            // C# 6.0 ułatwienie (lukier syntaktyczny)
            string fullname = $"{lastName} {firstName}";

            Hello(fullname);

            Hello(fullname);
        }


        static void Hello(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(message);
            Console.ResetColor();
        }


        
    }
}
