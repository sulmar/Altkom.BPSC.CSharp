using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPSC.CSharp.Shop.Models
{
   
    public class OrderDetail
    {
        public int Id { get; set; }
        public Item Item { get; set; }


        // public decimal Quantity { get; set; }

        private decimal quantity;
        public decimal Quantity
        {
            get { return quantity; }
            set
            {
                // Walidacja
                if (value <= 0 || value > 1000)
                {
                    throw new ArgumentOutOfRangeException(nameof(Quantity));
                }

                quantity = value;

            }
        }



        public decimal UnitPrice { get; set; }

        public decimal Amount
        {
            get
            {
                return Quantity * UnitPrice;
              

                // throw new NotImplementedException();


            }
        }

        public OrderDetail(Item item, decimal quantity)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }

            if (quantity <= 0 || quantity > 1000)
            {
                throw new ArgumentOutOfRangeException(nameof(quantity));
            }

            this.Item = item;
            this.Quantity = quantity;
            this.UnitPrice = item.UnitPrice;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"| Name | Qty | UnitPrice | Amount |");
            stringBuilder.Append($"| {Item}");
            stringBuilder.Append($"| {Quantity}");
            stringBuilder.Append($"| {UnitPrice}");
            stringBuilder.Append($"| {Amount:C2}");
            stringBuilder.Append($"|");

            return stringBuilder.ToString();

        }

    }
}
