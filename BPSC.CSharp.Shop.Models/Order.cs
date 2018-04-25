using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BPSC.CSharp.Shop.Models
{
    public class Order
    {
        public int Id { get; set; }

        #region
        //public void SetOrderDate(DateTime orderDate)
        //{
        //    this.orderDate = orderDate;
        //}

        //public DateTime GetOrderDate()
        //{
        //    return this.orderDate;
        //}

        #endregion

        // backfield
        private DateTime orderDate;

        // Właściwość (property)
        public DateTime OrderDate
        {
            get
            {
                return this.orderDate;
            }

            set
            {
                this.orderDate = value;
            }
        }

        public string OrderNumber { get; set;  }
        public DateTime? DeliveryDate { get; set; }
        public Customer Customer { get; set; }
        public List<OrderDetail> Details { get; set; }

        public decimal TotalAmount
        {
            get
            {
                decimal totalAmount = 0;

                foreach (var detail in this.Details)
                {
                    totalAmount += detail.Amount;
                }

                return totalAmount;
            }
        }


        public decimal TotalAmountLinq => this.Details
            .Sum(d => d.Amount);


        // Konstruktor
        public Order(Customer customer)
        {
            if (customer == null)
            {
                throw new ArgumentNullException(nameof(customer));
            }

            this.Details = new List<OrderDetail>();

            this.OrderDate = DateTime.Now;
            this.Customer = customer;

        }

        public void AddOrderDetail(OrderDetail orderDetail)
        {
            orderDetail.UnitPrice = orderDetail.Item.UnitPrice;

            this.Details.Add(orderDetail);
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"Order #{OrderNumber}");
            stringBuilder.AppendLine($"Order date: {OrderDate}");
            stringBuilder.AppendLine($"Total amount: {TotalAmount:C2}");

            stringBuilder.AppendLine($"Details: ");
            foreach (var detail in this.Details)
            {
                stringBuilder.AppendLine(detail.ToString());
            }

            return stringBuilder.ToString();

            // return $"Order #{OrderNumber} Order date: {OrderDate} Total amount: {TotalAmount}";
            // return base.ToString();
        }


    }
}
