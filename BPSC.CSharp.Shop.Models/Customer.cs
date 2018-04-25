using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPSC.CSharp.Shop.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        public Address HomeAddress { get; set; }
        public Address DeliveryAddress { get; set; }
        public Location Location { get; set; }

        public Customer()
        {
#if DEBUG
            Console.WriteLine("XXXX");
#endif
        }

        public Customer(string firstName, string lastName)
        {
           if (string.IsNullOrEmpty(firstName))
           {
                throw new ArgumentNullException(nameof(firstName));
           }

            if (string.IsNullOrEmpty(lastName))
            {
                throw new ArgumentNullException(nameof(lastName));
            }
           
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        
        
    }

}
